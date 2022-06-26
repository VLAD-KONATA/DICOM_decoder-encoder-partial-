using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DICOMLib
{
    class BinaryReaderBE : BinaryReader
    {
        private byte[] a16 = new byte[2];
        private byte[] a32 = new byte[4];
        private byte[] a64 = new byte[8];

        public BinaryReaderBE(System.IO.Stream stream) : base(stream) { }

        public override int ReadInt32()
        {
            a32 = base.ReadBytes(4);
            Array.Reverse(a32);
            return BitConverter.ToInt32(a32, 0);
        }

        public override Int16 ReadInt16()
        {
            a16 = base.ReadBytes(2);
            Array.Reverse(a16);
            return BitConverter.ToInt16(a16, 0);
        }
        public override UInt16 ReadUInt16()
        {
            a16 = base.ReadBytes(2);
            Array.Reverse(a16);
            return BitConverter.ToUInt16(a16, 0);
        }

        public override UInt32 ReadUInt32()
        {
            a32 = base.ReadBytes(4);
            Array.Reverse(a32);
            return BitConverter.ToUInt32(a32, 0);
        }

        public override Int64 ReadInt64()
        {
            a64 = base.ReadBytes(8);
            Array.Reverse(a64);
            return BitConverter.ToInt16(a64, 0);
        }
        public override UInt64 ReadUInt64()
        {
            a64 = base.ReadBytes(8);
            Array.Reverse(a64);
            return BitConverter.ToUInt16(a64, 0);
        }

        public override Single ReadSingle()
        {
            a32 = base.ReadBytes(4);
            Array.Reverse(a32);
            return BitConverter.ToSingle(a32, 0);
        }
        public override Double ReadDouble()
        {
            a64 = base.ReadBytes(8);
            Array.Reverse(a64);
            return BitConverter.ToDouble(a64, 0);
        }
    }

    class BinaryWriterBE : BinaryWriter
    {
        private byte[] a16 = new byte[2];
        private byte[] a32 = new byte[4];
        private byte[] a64 = new byte[8];

        public BinaryWriterBE(System.IO.Stream stream) : base(stream) { }

        public override void Write(Int32 val)
        {
            a32 = BitConverter.GetBytes(val);
            Array.Reverse(a32);
            base.Write(a32);
        }

        public override void Write(Int16 val)
        {
            a16 = BitConverter.GetBytes(val);
            Array.Reverse(a16);
            base.Write(a16);
        }

        public override void Write(UInt32 val)
        {
            a32 = BitConverter.GetBytes(val);
            Array.Reverse(a32);
            base.Write(a32);
        }

        public override void Write(UInt16 val)
        {
            a16 = BitConverter.GetBytes(val);
            Array.Reverse(a16);
            base.Write(a16);
        }

        public override void Write(Int64 val)
        {
            a64 = BitConverter.GetBytes(val);
            Array.Reverse(a64);
            base.Write(a64);
        }

        public override void Write(UInt64 val)
        {
            a64 = BitConverter.GetBytes(val);
            Array.Reverse(a64);
            base.Write(a64);
        }
        public override void Write(Single val)
        {
            a32 = BitConverter.GetBytes(val);
            Array.Reverse(a32);
            base.Write(a32);
        }
        public override void Write(Double val)
        {
            a64 = BitConverter.GetBytes(val);
            Array.Reverse(a64);
            base.Write(a64);
        }
    }
}
