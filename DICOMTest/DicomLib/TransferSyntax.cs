using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DICOMLib
{
    public abstract class TransferSyntax
    {
        public bool isBE;
        public bool isExplicit;
        public string uid;
        public string name;
        protected MemoryStream ms;
        protected BinaryReader reader;
        protected DicomDictionary dict;
        protected VRFactory vrfactory;
        public delegate string AskActualVR(UInt16 gtag,UInt16 etag);
        public AskActualVR delWhichVR = null;
        protected byte[] databuf;
        protected BinaryWriter writer;
        protected abstract int Encode(DCMAbstractType item);
        /// <summary>
        /// 判断是否是OB/OF/OW/SQ/UT/UN
        /// </summary>
        /// <param name="vr">数据元素VR</param>
        /// <returns>true/false</returns>
        protected bool isLongVR(string vr)
        {
            return (vr == "OB" || vr == "OF" || vr == "OW" || vr == "SQ" || vr == "UN" || vr == "UT");
        }
        /// <summary>
        /// 解码一条数据元素
        /// </summary>
        /// <param name="data">数据缓冲区</param>
        /// <param name="idx">当前位置</param>
        /// <returns>数据元素</returns>
        public DCMAbstractType Decode(byte[] data, ref uint idx)
        {
            databuf = data;
            if (ms != null)
            {
                if (data.Length != ms.Length || ms.Position != idx) //有数据更改就关闭流
                {
                    reader.Close();
                    ms.Close();
                    ms = null;
                }
            }

            if (ms == null)                 //流为空则初始化流及reader
            {
                ms = new MemoryStream(data);
                ms.Position = idx;
                
                if (isBE)
                    reader = new BinaryReaderBE(ms);
                else
                    reader = new BinaryReader(ms);
            }
            DCMAbstractType element;
            UInt16 gtag = reader.ReadUInt16();

            if (gtag == 0xfffe)   //三个特殊标记按照隐式VR读
            {
                element = new DCMDataElement(null);
                //读取TAG
                element.gtag = gtag;
                element.etag = reader.ReadUInt16();
                element.vr = "UL";
                element.vrparser = vrfactory.GetVR(element.vr);
                element.length = reader.ReadUInt32();//读4字节值长度
            }
            else
            {
                reader.BaseStream.Position -= 2;
                element = this.Decode(reader);  //调用具体传输语法类解码数据元素
            }
            idx = (uint)ms.Position;  //返回解码数据元素后的位置
            return element;
        }


        /// <summary>
        /// 抽象解码方法，待具体传输语法类根据三种格式解析
        /// </summary>
        /// <param name="reader">数据流读出器对象</param>
        /// <returns>数据元素</returns>
        protected abstract DCMAbstractType Decode(BinaryReader reader);

        /// <summary>
        /// 查询数据字典
        /// </summary>
        protected void LookupDictionary(DCMDataElement element)
        {
            //查数据字典得到VR,Name,VM
            DicomDictionaryEntry entry = dict.Find(element.gtag.ToString("X4"), element.etag.ToString("X4"));
            if (entry != null)
            {
                if (element.vr == "" || element.vr == null || element.vr == "\0\0")
                {
                    if (entry.VR == "OB or OW" && delWhichVR != null)  //确定不了，求援
                    {
                        element.vr = delWhichVR(element.gtag, element.etag);
                    }
                    else
                    {
                        element.vr = entry.VR;
                    }
                }
                element.name = entry.Keyword;
                element.vm = entry.VM;
            }
            //else if ((element.vr == "" || element.vr == null) && element.etag == 0)
            else if (element.etag == 0)   //组长度统一处理
            {
                element.name = "Group Length";
                element.vr = "UL";
            }
            else
            {
                element.name = "Private Tag";
                if (element.vr == "" || element.vr == null)
                    element.vr = "UN";
            }
            element.vrparser = vrfactory.GetVR(element.vr);
            element.syntax = this;
        }
        protected void WriteValue(DCMAbstractType element)
        {
            int len = element.value.Length;
            writer.Write(element.value);
            if (len % 2 != 0)     //填充为偶数字节长
            {
                if (element.vr == "OB" || element.vr == "UI")
                    writer.Write((byte)0x00);
                else
                    writer.Write((byte)0x20);
            }
        }
        public virtual byte[] Encode(DCMAbstractType item, bool isUndefinedLength)
        {
            ms = new MemoryStream();
            ms.Position = 0;

            if (isBE)
                writer = new BinaryWriterBE(ms);
            else
                writer = new BinaryWriter(ms);
            int n = Encode(item);
            BinaryReader reader = new BinaryReader(ms);
            ms.Position = 0;
            byte[] data = reader.ReadBytes(n);
            writer.Close();
            reader.Close();
            ms.Close();

            ms = null;
            return data;
        }

    }

    public class implicitVRLittleEndian:TransferSyntax
    {
        public implicitVRLittleEndian()
        {
            isExplicit = false;
            isBE = false;
            uid = "1.2.840.10008.1.2";
            name = "implicitVRLittleEndian";
            dict = new DicomDictionary();
            vrfactory = new VRFactory(isBE);
        }

        /// <summary>
        /// 解码数据元素
        /// </summary>
        /// <param name="reader">BinaryReader实例</param>
        /// <returns>数据元素</returns>
        protected override DCMAbstractType Decode(BinaryReader reader)
        {
            DCMDataElement element = new DCMDataElement(null);
            //读取TAG
            element.gtag = reader.ReadUInt16();
            element.etag = reader.ReadUInt16();
            //查字典
            LookupDictionary(element);
            //读取值长度
            element.length = reader.ReadUInt32();
            //读取值
            if (element.vr == "SQ")
            {
                TransferSyntax syn = new implicitVRLittleEndian();
                DCMDataSequence sq = new DCMDataSequence(syn);
                sq.gtag = element.gtag;
                sq.etag = element.etag;
                sq.name = element.name;
                sq.vr = element.vr;
                sq.vrparser = element.vrparser;
                sq.length = element.length;
                sq.value = new byte[0];
                uint idx = (uint)reader.BaseStream.Position;  //获取流位置
                sq.Parse(databuf, ref idx);
                reader.BaseStream.Position = idx;             //修正流位置
                return sq;
            }
            element.value = reader.ReadBytes((int)element.length);
            return element;
        }
        protected override int Encode(DCMAbstractType element)
        {
            long pos = writer.BaseStream.Position;
            //写入TAG
            writer.Write(element.gtag);
            writer.Write(element.etag);
            //写入值长度
            int len = element.value.Length;
            if (len % 2 != 0) len++;          //偶数
            writer.Write((UInt32)len);        //四字节长度
            //写入值
            WriteValue(element);

            return (int)(writer.BaseStream.Position - pos);
        }

    }
    public class ExplicitVRLittleEndian:TransferSyntax
    {
        public ExplicitVRLittleEndian()
        {
            isExplicit = true;
            isBE = false;
            uid = "1.2.840.10008.1.2.1";
            name = "explicitVRLittleEndian";
            dict = new DicomDictionary();
            vrfactory = new VRFactory(isBE);
        }

        /// <summary>
        /// 解码数据元素
        /// </summary>
        /// <param name="reader">BinaryReader实例</param>
        /// <returns>数据元素</returns>
        protected override DCMAbstractType Decode(BinaryReader reader)
        {
            DCMDataElement element = new DCMDataElement(null);
            //读取TAG
            element.gtag = reader.ReadUInt16();
            element.etag = reader.ReadUInt16();
            //读取VR
            element.vr = Encoding.Default.GetString(reader.ReadBytes(2));
            //查字典
            LookupDictionary(element);
            //读取值长度
            //            if (isLongVR(element.vr))
            if (element.vrparser.isLongVR)
            {
                reader.ReadBytes(2); //跳过两字节
                element.length = reader.ReadUInt32();//读4字节值长度
            }
            else
                element.length = reader.ReadUInt16();//读2字节值长度
                                                     //读取值
            if (element.vr == "SQ")
            {
                TransferSyntax syn = new ExplicitVRLittleEndian();
                DCMDataSequence sq = new DCMDataSequence(syn);
                sq.gtag = element.gtag;
                sq.etag = element.etag;
                sq.name = element.name;
                sq.vr = element.vr;
                sq.vrparser = element.vrparser;
                sq.length = element.length;
                sq.value = new byte[0];
                uint idx = (uint)reader.BaseStream.Position;  //获取流位置
                sq.Parse(databuf, ref idx);
                reader.BaseStream.Position = idx;             //修正流位置
                return sq;
            }

            element.value = reader.ReadBytes((int)element.length);
            return element;
        }
        protected override int Encode(DCMAbstractType element)
        {
            long pos = writer.BaseStream.Position;
            //写入TAG
            writer.Write(element.gtag);
            writer.Write(element.etag);
            //写入VR
            writer.Write(Encoding.Default.GetBytes(element.vr));
            //写入值长度
            int len = element.value.Length;
            if (len % 2 != 0) len++;          //偶数
            if(isLongVR(element.vr))
            {
                writer.Write(new byte[] { 0, 0 });
                writer.Write((UInt32)len);        //四字节长度
            }
            else
            {
                writer.Write((UInt16)len);        //二字节长度
            }
            //写入值
            WriteValue(element);

            return (int)(writer.BaseStream.Position - pos);
        }

    }

    public class ExplicitVRBigEndian : TransferSyntax
    {
        public ExplicitVRBigEndian()
        {
            isExplicit = true;
            isBE = true;
            uid = "1.2.840.10008.1.2.2";
            name = "explicitVRBigEndian";
            dict = new DicomDictionary();
            vrfactory = new VRFactory(isBE);
        }

        /// <summary>
        /// 解码数据元素
        /// </summary>
        /// <param name="reader">BinaryReaderBE实例</param>
        /// <returns>数据元素</returns>
        protected override DCMAbstractType Decode(BinaryReader reader)
        {
            DCMDataElement element = new DCMDataElement(null);
            //读取TAG
            element.gtag = reader.ReadUInt16();
            element.etag = reader.ReadUInt16();
            //读取VR
            element.vr = Encoding.Default.GetString(reader.ReadBytes(2));
            //查字典
            LookupDictionary(element);
            //读取值长度
            //            if (isLongVR(element.vr))
            if (element.vrparser.isLongVR)
            {
                reader.ReadBytes(2); //跳过两字节
                element.length = reader.ReadUInt32();//读4字节值长度
            }
            else
                element.length = reader.ReadUInt16();//读2字节值长度
            //读取值
            if (element.vr == "SQ")
            {
                TransferSyntax syn = new ExplicitVRBigEndian();
                DCMDataSequence sq = new DCMDataSequence(syn);
                sq.gtag = element.gtag;
                sq.etag = element.etag;
                sq.name = element.name;
                sq.vr = element.vr;
                sq.vrparser = element.vrparser;
                sq.length = element.length;
                sq.value = new byte[0];
                uint idx = (uint)reader.BaseStream.Position;  //获取流位置
                sq.Parse(databuf, ref idx);
                reader.BaseStream.Position = idx;             //修正流位置
                return sq;
            }
            element.value = reader.ReadBytes((int)element.length);
            return element;
        }
        protected override int Encode(DCMAbstractType element)
        {
            long pos = writer.BaseStream.Position;
            //写入TAG
            writer.Write(element.gtag);
            writer.Write(element.etag);
            //写入VR
            writer.Write(Encoding.Default.GetBytes(element.vr));
            //写入值长度
            int len = element.value.Length;
            if (len % 2 != 0) len++;          //偶数
            if (isLongVR(element.vr))
            {
                writer.Write(new byte[] { 0, 0 });
                writer.Write((UInt32)len);        //四字节长度
            }
            else
            {
                writer.Write((UInt16)len);        //二字节长度
            }
            //写入值
            WriteValue(element);

            return (int)(writer.BaseStream.Position - pos);
        }
    }

    public static class TransferSyntaxs
    {
        static Dictionary<string, TransferSyntax> TSs = null;
        public static Dictionary<string, TransferSyntax> Trans
        {
            get
            {
                if (TSs == null)
                {
                    TSs = new Dictionary<string, TransferSyntax>();
                    TransferSyntax ts = new implicitVRLittleEndian();
                    TSs.Add(ts.uid, ts);
                    ts = new ExplicitVRLittleEndian();
                    TSs.Add(ts.uid, ts);
                    ts = new ExplicitVRBigEndian();
                    TSs.Add(ts.uid, ts);
                }
                return TSs;
            }
        }
    }

}