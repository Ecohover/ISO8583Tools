using System;
using System.Globalization;
using ISO8583Tools.Extension;
using ISO8583Tools.Modles.Enums;

namespace ISO8583Tools.Modles
{
    public class DtoMessageType
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="stringMessage"></param>
        public DtoMessageType(byte[] vs)
        {
            var hexString = vs.ToHexString();
            /*
            this.Version = (EnumVersion)Convert.ToInt16(stringMessage.Substring(0, 1), CultureInfo.CurrentCulture);
            this.MessageClass = (EnumMessageClass)Convert.ToInt16(stringMessage.Substring(1, 1), CultureInfo.CurrentCulture);
            this.MessageFunction = (EnumMessageFunction)Convert.ToInt16(stringMessage.Substring(2, 1), CultureInfo.CurrentCulture);
            this.MessageOrigin = (EnumMessageOrigin)Convert.ToInt16(stringMessage.Substring(3, 1), CultureInfo.CurrentCulture);

            this.Value = stringMessage;
            */
        }

        public EnumVersion Version { get; set; }

        public EnumMessageClass MessageClass { get; set; }

        public EnumMessageFunction MessageFunction { get; set; }

        public EnumMessageOrigin MessageOrigin { get; set; }

        public string Value { get; }
    }
}
