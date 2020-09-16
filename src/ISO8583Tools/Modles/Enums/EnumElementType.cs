using System;
using System.Collections.Generic;
using System.Text;

namespace ISO8583Tools.Modles.Enums
{
    public enum EnumElementType
    {
        /// <summary>
        /// Alpha, including blanks
        /// </summary>
        A,

        /// <summary>
        /// Numeric values only
        /// </summary>
        N,

        /// <summary>
        /// Numeric (amount) values, where the first byte is either 'C' to indicate a positive or Credit value, or 'D' to indicate a negative or Debit value, followed by the numeric value (using n digits)
        /// </summary>
        XN,

        /// <summary>
        /// Special characters only
        /// </summary>
        S,

        /// <summary>
        /// Alphanumeric
        /// </summary>
        AN,

        /// <summary>
        /// Alpha & special characters only
        /// </summary>
        AS,

        /// <summary>
        /// Numeric and special characters only
        /// </summary>
        NS,

        /// <summary>
        /// Alphabetic, numeric and special characters.
        /// </summary>
        ANS,

        /// <summary>
        /// Binary data
        /// </summary>
        B,

        /// <summary>
        /// Tracks 2 and 3 code set as defined in ISO/IEC 7813 and ISO/IEC 4909 respectively
        /// </summary>
        Z,

        /// <summary>
        /// Bcd Binary Coded Decimal
        /// </summary>
        Bcd,

        /// <summary>
        /// Ascii The American Standard Code for Information Interchange
        /// </summary>
        Ascii,
    }
}
