using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ISO8583Tools.Extension
{
    public static class ConverterExtension
    {
        public static string ToHexString(this byte[] byteArray)
        {
            if (byteArray == null)
            {
                throw new ArgumentNullException($"({byteArray}) is null");
            }

            StringBuilder sb = new StringBuilder(byteArray.Length * 2);
            foreach (byte b in byteArray)
            {
                sb.AppendFormat("{0:X2}", b);
            }

            return sb.ToString();
        }

        public static byte[] ToByteArray(this string hexString)
        {
            if (hexString == null)
            {
                throw new ArgumentNullException($"({hexString}) is null");
            }

            int numberChars = hexString.Length / 2;
            byte[] bytes = new byte[numberChars];
            for (int i = 0; i < numberChars; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(2 * i, 2), 16);
            }

            return bytes;
        }

        public static byte[] ToAscii(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException($"({str}) is null");
            }

            return ASCIIEncoding.ASCII.GetBytes(str);
        }

        public static string AsciiToString(this byte[] vs)
        {
            if (vs == null)
            {
                throw new ArgumentNullException($"({vs}) is null");
            }

            return ASCIIEncoding.ASCII.GetString(vs);
        }

        public static byte[] GetBytes(this int self)
        {
            return BitConverter.GetBytes(self);
        }
    }
}
