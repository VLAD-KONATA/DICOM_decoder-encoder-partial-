using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DICOMLib
{
    public class DCMFileMeta : DCMDataSet
    {
        public DCMFileMeta(TransferSyntax ts):base(ts)
        {}
        public override List<DCMAbstractType> Parse(byte[] data, ref uint idx)
        {
            DCMAbstractType elem = syntax.Decode(data, ref idx); //读取头元素组长度
            if (elem.gtag == 0x0002 && elem.etag == 0x0000)
            {
                uint ulidx = 0;
                int glen = (int)elem.GetValue<UInt32>();
                byte[] val = new byte[glen];
                Array.Copy(data, idx, val, 0, glen);    //复制头元素的整个组
                base.Parse(val, ref ulidx);             //解析头元素
                idx += ulidx;
            }
            return items;
        }
    }

    public class DCMFile : DCMDataSet
    {
        protected string filename;
        public DCMFileMeta filemeta;
        public DCMFile(TransferSyntax ts) : base(ts)
        {  //头元素：显式VRLE传输语法
            filemeta = new DCMFileMeta(TransferSyntaxs.Trans["1.2.840.10008.1.2.1"]);
        }
        public DCMFile() : base(TransferSyntaxs.Trans["1.2.840.10008.1.2"])  //初始化为默认传输语法
        {
        }
        public override List<DCMAbstractType> Parse(byte[] data, ref uint idx)
        {
            filemeta = new DCMFileMeta(TransferSyntaxs.Trans["1.2.840.10008.1.2.1"]);  //头元素：显式VRLE传输语法

            List<DCMAbstractType> meta = filemeta.Parse(data, ref idx);
            foreach (DCMAbstractType elem in meta)
            {
                if (elem.gtag == 0x0002 && elem.etag == 0x0010)
                {
                        string syn = elem.GetValue<string>();
                        base.syntax = TransferSyntaxs.Trans[syn];
                        base.Parse(data, ref idx);
                        break;
                }
            }
            return items;
        }

        public bool Parse(string fname)
        {
            filename = fname;
            FileStream fs = new FileStream(fname, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            br.ReadChars(128);
            byte[] dicm = br.ReadBytes(4);
            string strDICM = Encoding.Default.GetString(dicm, 0,4);
            if (strDICM == "DICM")
            {
                uint len = (uint)br.BaseStream.Length - 128 - 4;
                byte[] data = br.ReadBytes((int)len);
                len = 0;
                items = Parse(data, ref len);
                return true;
            }
            else
                return false;
        }

        public override string ToString(string head)
        {
            return filemeta.ToString("") + "\n" + base.ToString("");
        }

        public bool Save(string filename, bool isUndefinedLength)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);

            byte[] data;
            fs.Write(new byte[128], 0, 128);    //128字节前导符
            fs.Write(Encoding.Default.GetBytes("DICM"), 0, 4);  //DICM标志
            data = filemeta.Encode(isUndefinedLength);  //头元素组编码
            fs.Write(data, 0, data.Length);
            data = Encode(isUndefinedLength);    //数据集编码
            fs.Write(data, 0, data.Length);
            fs.Close();                         //关闭文件
            return true;
        }

    }
}