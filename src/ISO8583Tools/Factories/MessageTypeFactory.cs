using ISO8583Tools.Modles;
using ISO8583Tools.Modles.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ISO8583Tools.Factories
{
    public static class MessageTypeFactory
    {
        public const EnumVersion Version = EnumVersion.V2;

        /// <summary>
        /// Acquirer Reversal Request
        /// </summary>
        /// <returns></returns>
        public static DtoMessageType CreateAcquirerReversalRequestMessage()
        {
            return new DtoMessageType(null);
        }
    }
}
