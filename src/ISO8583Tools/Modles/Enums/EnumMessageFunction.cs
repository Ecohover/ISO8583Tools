using System;
using System.Collections.Generic;
using System.Text;

namespace ISO8583Tools.Modles.Enums
{
    public enum EnumMessageFunction
    {
        /// <summary>
        /// Request
        /// </summary>
        /// <remarks>
        /// Request from acquirer to issuer to carry out an action; issuer may accept or reject
        /// </remarks>
        MF0 = 0,

        /// <summary>
        /// Request response
        /// </summary>
        /// <remarks>
        /// Issuer response to a request
        /// </remarks>
        MF1 = 1,

        /// <summary>
        /// Advice
        /// </summary>
        /// <remarks>
        /// Advice that an action has taken place; receiver can only accept, not reject
        /// </remarks>
        MF2 = 2,

        /// <summary>
        /// Advice response
        /// </summary>
        /// <remarks>
        /// Response to an advice
        /// </remarks>
        MF3 = 3,

        /// <summary>
        /// Notification
        /// </summary>
        /// <remarks>
        /// Notification that an event has taken place; receiver can only accept, not reject
        /// </remarks>
        MF4 = 4,

        /// <summary>
        /// Notification acknowledgement
        /// </summary>
        /// <remarks>
        /// Response to a notification
        /// </remarks>
        MF5 = 5,

        /// <summary>
        /// Instruction
        /// </summary>
        /// <remarks>
        /// ISO 8583:2003
        /// </remarks>
        MF6 = 6,

        /// <summary>
        /// Instruction acknowledgement
        /// </summary>
        /// <remarks>
        /// ISO 8583:2003
        /// </remarks>
        MF7 = 7,
    }
}
