using System;
using System.Collections.Generic;
using System.Text;

namespace ISO8583Tools.Modles.Enums
{
    public enum EnumMessageOrigin
    {
        /// <summary>
        /// Acquirer
        /// </summary>
        MO0 = 0,

        /// <summary>
        /// Acquirer repeat
        /// </summary>
        MO1 = 1,

        /// <summary>
        /// Issuer
        /// </summary>
        MO2 = 2,

        /// <summary>
        /// Issuer repeat
        /// </summary>
        MO3 = 3,

        /// <summary>
        /// Other
        /// </summary>
        MO4 = 4,

        /// <summary>
        /// Other repeat
        /// </summary>
        MO5 = 5,
    }
}
