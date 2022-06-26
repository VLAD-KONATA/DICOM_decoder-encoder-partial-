using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICOMLib
{
    public static class CxEndian
    {
        public static byte[] ReverseForBE(this byte[] byteArray, int
        startIndex, int count)
        {
            byte[] ret = new byte[count];
            if (BitConverter.IsLittleEndian)
            {
                for (int i = startIndex + (count - 1); i >= startIndex; --i)
                    ret[(startIndex + (count - 1)) - i] = byteArray[i];
            }
            else
            {
                for (int i = 0; i < count; ++i)
                    ret[i] = byteArray[i + startIndex];
            }
            return ret;
        }
    }}
