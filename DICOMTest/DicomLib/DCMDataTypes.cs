using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICOMLib
{
    public abstract class DCMAbstractType
    {
        public string name;
        public string vr;
        public string vm;
        public ushort gtag;
        public ushort etag;
        public uint length;
        public byte[] value;
        public TransferSyntax syntax;
        public VR vrparser;
        public abstract byte[] Encode(bool isUndefinedLength);
        public DCMAbstractType(TransferSyntax ts)
        {
            syntax = ts;
        }

        public uint UIntTag
        {
            get
            {
                return (uint)(gtag << 16) + etag;
            }
        }

        public abstract string ToString(string head);
        public abstract List<DCMAbstractType> Parse(byte[] data, ref uint idx);

        public virtual T GetValue<T>()
        {
            return vrparser.GetValue<T>((byte[])value, 0);// (int)length);
        }

        public virtual uint SetValue<T>(T val)
        {
            value = vrparser.SetValue<T>(val);
            length = (uint)value.Length;
            uint cnt = 4;  //tag
            if (syntax.isExplicit)  //显式VR
            {
                cnt += 2;  //vr
                if (vrparser.isLongVR) cnt += 6; //length
                else cnt += 2;
            }
            else cnt += 4;  //隐式VR    length

            cnt += length % 2 == 0 ? length : length + 1;  //value
            return cnt;
        }

    }

    public class DCMDataElement : DCMAbstractType
    {
        public DCMDataElement(TransferSyntax ts) : base(ts)
        { }

        public override List<DCMAbstractType> Parse(byte[] data, ref uint idx)
        {
            return null;
        }

        public override string ToString(string head)
        {
            string str = head;
            str += gtag.ToString("X4") + "," + etag.ToString("X4") + "\t";
            str += name + "\t";
            str += vr + "\t";
            str += length.ToString();
            str += "\t";
            //value怎么返回字符串需要根据不同VR
            if(vrparser!= null)
                str += vrparser.ToString(value, 0, head);
            return str;
        }

        public override byte[] Encode(bool isUndefinedLength)
        {
            length = isUndefinedLength ? 0xffffffff : 0;
            return syntax.Encode(this, isUndefinedLength);
        }

    }

    public class DCMDataSet : DCMAbstractType
    {
        public List<DCMAbstractType> items = new List<DCMAbstractType>();
        public DCMDataSet(TransferSyntax ts) : base(ts)
        { }

        public DCMDataSet GetSet()
        {
            return this;
        }

        public string SelectVR(UInt16 gtag, UInt16 etag)
        {
            string res = "OB";    //默认OB
            if (gtag == 0x7fe0 && etag == 0x0010) //OB or OW
            {
                foreach (DCMAbstractType item in items)
                {
                    if (item.gtag == 0x0028 && item.etag == 0x0100)//BitsAllocated
                    {
                        UInt16 val = item.vrparser.GetValue<UInt16>(item.value, 0);
                        if (val == 16)
                        {
                            res = "OW";
                        }
                        break;
                    }
                }
            }
            return res;
        }

        public DCMAbstractType this[uint tag]
        {
            get
            {  //查找对应元素
                DCMAbstractType item = items.Find(elem => elem.UIntTag == tag);
                if (item == null)  //没找到
                {   //用tag中的组号元素号初始化数据
                    byte[] src = BitConverter.GetBytes(tag);
                    byte[] data = { src[2], src[3], src[0], src[1], 0, 0, 0, 0, 0, 0, 0, 0 };
                    if (syntax.isBE)
                    {
                        Array.Reverse(data, 0, 2); Array.Reverse(data, 2, 2);
                    }
                    uint idx = 0;
                    item = syntax.Decode(data, ref idx);  //通过解析实例化数据元素对象
                    items.Add(item);
                    //组号递增元素号递增排序
                    items.Sort((left, right) => left.UIntTag.CompareTo(right.UIntTag));
                }
                return item;
            }

            set
            {
                int idx = items.FindIndex(elem => elem.UIntTag == tag);//查找对应下标
                if (idx != -1)     //找到直接替换
                {
                    items[idx] = value;
                }
                else
                {
                    items.Add(value);//否则添加              
                    items.Sort((left, right)
                        => left.UIntTag.CompareTo(right.UIntTag)); //组号递增元素号递增排序
                }
            }
        }

        public override List<DCMAbstractType> Parse(byte[] data, ref uint idx)
        {
            items = new List<DCMAbstractType>();
            syntax.delWhichVR = SelectVR;   //实例化委托
            while (idx < data.Length)
            {
                DCMAbstractType elem = null;
                //此处调用传输语法对象解码一条数据元素
                elem = syntax.Decode(data, ref idx);
                items.Add(elem);
            }
            return items;
        }

        public override string ToString(string head)
        {
            string str = "";
            foreach (DCMAbstractType elem in items)
            {
                if (elem != null)
                {
                    if (str != "") str += "\r\n";  //两个数据元素之间用换行符分割
                    str += elem.ToString(head);
                }
            }
            return str;
        }

        public override byte[] Encode(bool isUndefinedLength)
        {
            MemoryStream ms = new MemoryStream();   //编码缓冲区
            byte[] data;
            foreach (DCMAbstractType item in items)  //遍历数据集中每条数据元素
            {
                data = item.Encode(isUndefinedLength); //调用数据元素的编码方法
                ms.Write(data, 0, data.Length);       //编码结果写入编码缓冲区
            }
            data = ms.ToArray();                    //得到编码结果字节数组
            ms.Close();                             //关闭编码缓冲区
            return data;
        }

    }
    public class DCMDataItem : DCMDataSet
    {
        public DCMDataItem(TransferSyntax syn) : base(syn)
        {
            gtag = 0xfffe;
            etag = 0xe000;
            name = "ITEM";
            vr = "UL";
            length = 0xffffffff;
        }

        public override List<DCMAbstractType> Parse(byte[] data, ref uint idx)
        {
            DCMAbstractType item = syntax.Decode(data, ref idx);
            //条目未定义长度就暂时把data剩余字节都作为值域,通过条目结束标记结束
            bool isUndefined = item.length == 0xffffffff;
            int len = isUndefined ? data.Length : (int)(item.length + idx);
            if (item.gtag == 0xfffe && item.etag == 0xe000)  //条目开始标记
            {
                items = new List<DCMAbstractType>();

                while (idx < len)
                {
                    item = syntax.Decode(data, ref idx);
                    if (isUndefined && item.gtag == 0xfffe && item.etag == 0xe00d)    //条目结束标记
                        break;  //结束
                    else
                        items.Add(item);
                }
            }
            else if (item.gtag == 0xfffe && item.etag == 0xe0dd)  //序列结束标记
            {
                items = new List<DCMAbstractType>();     //返回一个空的items
            }
            return items;
        }

        public override string ToString(string head)
        {
            return base.ToString(head);
        }
        /*
                public override bool FromString(string line, string head)
                {
                    return base.FromString(line, head);
                }
        */
        public override byte[] Encode(bool isUndefinedLength)
        {
            MemoryStream ms = new MemoryStream();
            byte[] data;
            //写入条目起始标记，隐式VR
            if (syntax.isBE)  //写入条目起始标记，BE
                ms.Write(new byte[] { 0xFF, 0xFE, 0xE0, 0x00, 0xFF, 0xFF, 0xFF, 0xFF }, 0, 8);
            else  //写入条目起始标记，LE
                ms.Write(new byte[] { 0xFE, 0xFF, 0x00, 0xE0, 0xFF, 0xFF, 0xFF, 0xFF }, 0, 8);

            foreach (DCMAbstractType item in items)
            {
                data = item.Encode(isUndefinedLength);
                ms.Write(data, 0, data.Length);  //写入子数据集
            }

            if (isUndefinedLength)  //未定义长度则写入条目结束标记，隐式VR
            {
                if (syntax.isBE)  //写入条目结束标记，BE
                    ms.Write(new byte[] { 0xFF, 0xFE, 0xE0, 0x0D, 0x00, 0x00, 0x00, 0x00 }, 0, 8);
                else  //写入条目结束标记，LE
                    ms.Write(new byte[] { 0xFE, 0xFF, 0x0D, 0xE0, 0x00, 0x00, 0x00, 0x00 }, 0, 8);
            }
            else   //更新条目起始标识的值域，位于第4字节开始的4个字节
            {
                byte[] itemLen = BitConverter.GetBytes((UInt32)(ms.Length - 8));  //子数据集开始于条目起始标记的8字节后面
                if (syntax.isBE) Array.Reverse(itemLen);
                ms.Position = 4;
                ms.Write(itemLen, 0, 4);
            }
            data = ms.ToArray();
            ms.Close();
            return data;
        }
    }

    public class DCMDataSequence : DCMDataSet
    {
        public DCMDataSequence(TransferSyntax syn) : base(syn)
        {
        }

        public override List<DCMAbstractType> Parse(byte[] data, ref uint idx)
        {
            //SQ未定义长度就暂时把data剩余字节都作为值域，读到序列结束标记结束
            int len = length == 0xffffffff ? data.Length : (int)(length + idx);
            while (idx < len)
            {
                DCMDataItem item = new DCMDataItem(syntax);
                item.Parse(data, ref idx);  //解码一个item，加入items列表
                if (item.items == null)     //没有读到条目
                    break;
                else if (item.items.Count == 0)   //读到序列结束标记
                    break;
                else
                    items.Add(item);
            }
            return items;
        }

        public override string ToString(string head)
        {
            string str = head;
            str += gtag.ToString("X4") + "," + etag.ToString("X4") + "\t";
            str += name + "\t";
            str += vr + "\t";
            str += length.ToString();
            str += "\t";
            int i = 1;
            foreach (DCMAbstractType elem in items)
            {
                if (elem != null)
                {
                    str += ("\n" + head + ">ITEM" + i.ToString() + "\n");
                    str += elem.ToString(head + ">");
                    i++;
                }
            }
            return str;
        }

        //public override bool FromString(string line, string head)
        //{
        //    string[] arr = line.Split('\n');
        //    items.Clear();
        //    string str="";
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i].Substring(0, head.Length) == head)   //同层或下层
        //        {
        //            if (arr[i].Substring(head.Length+1,4) == "ITEM")  //条目开始
        //            {
        //                if (str != "")    //编码前面一条条目
        //                {
        //                    DCMDataItem item = new DCMDataItem(syntax);
        //                    item.FromString(str, head);
        //                    items.Add(item);
        //                    str = "";
        //                }
        //            }
        //            else   //子数据集中的数据元素，加入
        //            {
        //                if (str != "") str += "\n";
        //                str += arr[i].Substring(head.Length+1);
        //            }
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    if(str != "")  //编码最后一条条目
        //    {
        //        DCMDataItem item = new DCMDataItem(syntax);
        //        item.FromString(str, head);
        //        items.Add(item);
        //    }
        //    return true;
        //}

        public override byte[] Encode(bool isUndefinedLength)
        {
            MemoryStream ms = new MemoryStream();
            byte[] data;
            length = isUndefinedLength ? 0xffffffff : 0;
            data = syntax.Encode(this, isUndefinedLength);
            ms.Write(data, 0, data.Length);
            long sqLen = ms.Position - 4;
            foreach (DCMDataItem item in items)
            {
                data = item.Encode(isUndefinedLength);
                ms.Write(data, 0, data.Length);  //写入条目
            }

            if (isUndefinedLength)  //未定义长度则写入序列结束标记，隐式VR
            {
                if (syntax.isBE)
                    ms.Write(new byte[] { 0xFF, 0xFE, 0xE0, 0xDD, 0x00, 0x00, 0x00, 0x00 }, 0, 8);  //写入序列结束标记，BE
                else
                    ms.Write(new byte[] { 0xFE, 0xFF, 0xDD, 0xE0, 0x00, 0x00, 0x00, 0x00 }, 0, 8);  //写入序列结束标记，LE
                length = 0xffffffff;
            }
            else
                length = (uint)(ms.Length - sqLen - 4);
            ms.Position = sqLen;
            data = BitConverter.GetBytes((UInt32)length);
            if (syntax.isBE) Array.Reverse(data);
            ms.Write(data, 0, 4);
            data = ms.ToArray();
            ms.Close();
            return data;
        }
    }
}
