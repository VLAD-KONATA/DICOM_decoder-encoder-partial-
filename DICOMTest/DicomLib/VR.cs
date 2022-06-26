using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DICOMLib
{
    public abstract class VR
    {
        protected bool _isBE;
        protected bool _isLongVR;

        public VR(bool isbe, bool islongvr)
        {
            _isBE = isbe;
            _isLongVR = islongvr;
        }
        public bool isBE { get { return _isBE; } set { _isBE = value; } }
        public bool isLongVR { get { return _isLongVR; } }

        public abstract T GetValue<T>(byte[] data, int startIndex);
        public abstract string ToString(byte[] data, int startIndex, string head);

        public abstract byte[] SetValue<T>(T val);
        public abstract byte[] FromString(string str, string head);
    }

    public class UL : VR
    {
        public UL(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(UInt32))
            {
                byte[] val = data;
                int idx;
                if (isBE)
                {
                    val = data.ReverseForBE(startIndex, 4);
                    idx = 0;
                }
                else
                    idx = startIndex;

                return (T)(object)BitConverter.ToUInt32(val, idx);
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            UInt32 value = GetValue<UInt32>(data, startIndex);
            return value.ToString();
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(UInt32))
            {
                byte[] data = BitConverter.GetBytes((UInt32)(object)val);
                if (isBE)
                    data = data.ReverseForBE(0, 4);

                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<UInt32>(UInt32.Parse(str));
        }
    }

    public class SS : VR
    {
        public SS(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(Int16))
            {
                byte[] val = data;
                int idx;
                if (isBE)
                {
                    val = data.ReverseForBE(startIndex, 2);
                    idx = 0;
                }
                else
                    idx = startIndex;

                return (T)(object)BitConverter.ToUInt16(val, idx);
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            Int16 value = GetValue<Int16>(data, startIndex);
            return value.ToString();
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(Int16))
            {
                byte[] data = BitConverter.GetBytes((Int16)(object)val);
                if (isBE)
                    data = data.ReverseForBE(0, 2);

                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<Int16>(Int16.Parse(str));
        }
    }

    public class US : VR
    {
        public US(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(UInt16))
            {
                byte[] val = data;
                int idx;
                if (isBE)
                {
                    val = data.ReverseForBE(startIndex, 2);
                    idx = 0;
                }
                else
                    idx = startIndex;

                return (T)(object)BitConverter.ToUInt16(val, idx);
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            UInt16 value = GetValue<UInt16>(data, startIndex);
            return value.ToString();
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(UInt16))
            {
                byte[] data = BitConverter.GetBytes((UInt16)(object)val);
                if (isBE)
                    data = data.ReverseForBE(0, 2);

                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<UInt16>(UInt16.Parse(str));
        }
    }

    public class SL : VR
    {
        public SL(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(Int32))
            {
                byte[] val = data;
                int idx;
                if (isBE)
                {
                    val = data.ReverseForBE(startIndex, 4);
                    idx = 0;
                }
                else
                    idx = startIndex;

                return (T)(object)BitConverter.ToInt32(val, idx);
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            Int32 value = GetValue<Int32>(data, startIndex);
            return value.ToString();
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(Int32))
            {
                byte[] data = BitConverter.GetBytes((Int32)(object)val);
                if (isBE)
                    data = data.ReverseForBE(0, 4);

                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<Int32>(Int32.Parse(str));
        }
    }

    public class FL : VR
    {
        public FL(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(Single))
            {
                byte[] val = data;
                int idx;
                if (isBE)
                {
                    val = data.ReverseForBE(startIndex, 4);
                    idx = 0;
                }
                else
                    idx = startIndex;

                return (T)(object)BitConverter.ToSingle(val, idx);
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            Single value = GetValue<Single>(data, startIndex);
            return value.ToString();
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(Single))
            {
                byte[] data = BitConverter.GetBytes((Single)(object)val);
                if (isBE)
                    data = data.ReverseForBE(0, 4);

                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<Single>(Single.Parse(str));
        }
    }

    public class FD : VR
    {
        public FD(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(Double))
            {
                byte[] val = data;
                int idx;
                if (isBE)
                {
                    val = data.ReverseForBE(startIndex, 8);
                    idx = 0;
                }
                else
                    idx = startIndex;

                return (T)(object)BitConverter.ToDouble(val, idx);
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            double value = GetValue<Double>(data, startIndex);
            return value.ToString();
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(Double))
            {
                byte[] data = BitConverter.GetBytes((Double)(object)val);
                if (isBE)
                    data = data.ReverseForBE(0, 8);

                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<Double>(Double.Parse(str));
        }
    }

    public class ST : VR
    {
        public ST(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class IS : VR
    {
        public IS(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class DS : VR
    {
        public DS(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            string value = GetValue<string>(data, startIndex);
            return value;
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class DA : VR
    {
        public DA(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class CS : VR
    {
        public CS(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class UN : VR
    {
        public UN(bool isbe) : base(isbe, true)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class UT : VR
    {
        public UT(bool isbe) : base(isbe, true)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class LT : VR
    {
        public LT(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class SH : VR
    {
        public SH(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class LO : VR
    {
        public LO(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class PN : VR
    {
        public PN(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    public class AS : VR
    {
        public AS(bool isbe) : base(isbe, false)
        {
        }

        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    class OW : VR
    {
        public OW(bool isBE) : base(isBE, true) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(UInt16[]))
            {
                UInt16[] vals = new UInt16[(data.Length - startIndex) / 2];
                byte[] val = data;
                int idx, i = 0;
                while (startIndex < data.Length)
                {
                    if (isBE)
                    {
                        val = data.ReverseForBE(startIndex, 2);
                        idx = 0;
                    }
                    else
                        idx = startIndex;
                    vals[i++] = BitConverter.ToUInt16(val, idx);
                    startIndex += 2;
                }
                return (T)(object)vals;
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            UInt16[] value = GetValue<UInt16[]>(data, startIndex);
            string str = "";
            for (int i = 0; i < (data.Length < 10 ? data.Length / 2 : 5); i++)
                str += value[i].ToString("X4") + " ";
            if (data.Length >= 10)
                str += "...";
            return str;
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(UInt16[]))
            {
                UInt16[] value = (UInt16[])(object)val;
                byte[] data = new byte[value.Length * 2];
                for (int i = 0; i < value.Length; i++)
                {
                    byte[] bts = BitConverter.GetBytes(value[i]);
                    if (isBE)
                        Array.Reverse(bts);
                    Array.Copy(bts, 0, data, i * 2, 2);
                }
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            string[] vals = str.Split(' ');
            int len = vals.Length < 5 ? vals.Length : 5;
            UInt16[] value = new UInt16[len];
            for (int i = 0; i < len; i++)
                value[i] = UInt16.Parse(vals[i], System.Globalization.NumberStyles.HexNumber);
            return SetValue<UInt16[]>(value);
        }
    }

    class DT : VR
    {
        public DT(bool isBE) : base(isBE, false) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    class SQ : VR
    {
        public SQ(bool isBE) : base(isBE, true) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return "";
        }

        public override byte[] SetValue<T>(T val)
        {
            throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return null;
        }
    }

    class AE : VR
    {
        public AE(bool isBE) : base(isBE, false) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    class UI : VR
    {
        public UI(bool isBE) : base(isBE, false) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd('\0');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    class TM : VR
    {
        public TM(bool isBE) : base(isBE, false) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(string))
            {
                string val = Encoding.Default.GetString(data, startIndex, data.Length);
                return (T)(object)val.TrimEnd(' ');
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            return GetValue<string>(data, startIndex);
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    class AT : VR
    {
        public AT(bool isBE) : base(isBE, false) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(UInt16[]))
            {
                UInt16[] vals = new UInt16[(data.Length - startIndex) / 2];
                byte[] val = data;
                int idx, i = 0;
                while (startIndex < data.Length)
                {
                    if (isBE)
                    {
                        val = data.ReverseForBE(startIndex, 2);
                        idx = 0;
                    }
                    else
                        idx = startIndex;
                    vals[i++] = BitConverter.ToUInt16(val, idx);
                    startIndex += 2;
                }
                return (T)(object)vals;
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            UInt16[] value = GetValue<UInt16[]>(data, startIndex);
            string str = "";
            for (int i = 0; i < value.Length; i++)
                str += value[i].ToString("X4") + " ";
            return str;
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(String))
            {
                byte[] data = Encoding.Default.GetBytes((String)(object)val);
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            return SetValue<String>(str);
        }
    }

    class OB : VR
    {
        public OB(bool isBE) : base(isBE, true) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(byte[]))
            {
                byte[] vals = new byte[data.Length - startIndex];
                Array.Copy(data, startIndex, vals, 0, vals.Length);
                return (T)(object)vals;
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            byte[] value = GetValue<byte[]>(data, startIndex);
            string str = "";
            for (int i = 0; i < (value.Length < 10 ? value.Length : 10); i++)
                str += value[i].ToString("X2") + " ";
            if (value.Length >= 10)
                str += "...";
            return str;
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(byte[]))
            {
                return (byte[])(object)val;
            }
            else

                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            string[] vals = str.TrimEnd(' ').Split(' ');
            int len = vals.Length < 10 ? vals.Length : 10;
            byte[] value = new byte[len];
            for (int i = 0; i < len; i++)
                value[i] = byte.Parse(vals[i]);
            return value;
        }
    }

    class OF : VR
    {
        public OF(bool isBE) : base(isBE, true) { }
        public override T GetValue<T>(byte[] data, int startIndex)
        {
            if (typeof(T) == typeof(UInt32[]))
            {
                Single[] vals = new Single[(data.Length - startIndex) / 4];
                byte[] val = data;
                int idx, i = 0;
                while (startIndex < data.Length)
                {
                    if (isBE)
                    {
                        val = data.ReverseForBE(startIndex, 4);
                        idx = 0;
                    }
                    else
                        idx = startIndex;
                    vals[i++] = BitConverter.ToSingle(val, idx);
                    startIndex += 4;
                }
                return (T)(object)vals;
            }
            else
                throw new NotSupportedException();
        }
        public override string ToString(byte[] data, int startIndex, string head)
        {
            UInt32[] value = GetValue<UInt32[]>(data, startIndex);
            string str = "";
            for (int i = 0; i < (value.Length < 10 ? value.Length : 10); i++)
                str += value[i].ToString("X8") + " ";
            if (value.Length >= 10)
                str += "...";
            return str;
        }

        public override byte[] SetValue<T>(T val)
        {
            if (typeof(T) == typeof(UInt32[]))
            {
                UInt32[] value = (UInt32[])(object)val;
                byte[] data = new byte[value.Length * 4];
                for (int i = 0; i < value.Length; i++)
                {
                    byte[] bts = BitConverter.GetBytes(value[i]);
                    if (isBE)
                        Array.Reverse(bts);
                    Array.Copy(bts, 0, data, i * 4, 4);
                }
                return data;
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] FromString(string str, string head)
        {
            string[] vals = str.Split(' ');
            int len = vals.Length < 10 ? vals.Length : 10;
            UInt32[] value = new UInt32[len];
            for (int i = 0; i < len; i++)
                value[i] = UInt32.Parse(vals[i]);
            return SetValue<UInt32[]>(value);
        }
    }
}