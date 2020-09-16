using System;
using System.Collections.Generic;
using System.Text;

namespace ISO8583Tools.Modles.Enums
{
    public enum EnumMessageClass
    {
        /// <summary>
        /// Reserved by ISO
        /// </summary>
        MC0 = 0,

        /// <summary>
        /// Authorization message
        /// </summary>
        /// <remarks>
        /// Determine if funds are available, get an approval but do not post to account for reconciliation. Dual message system (DMS), awaits file exchange for posting to the account.
        /// </remarks>
        MC1 = 1,

        /// <summary>
        /// Financial messages
        /// </summary>
        /// <remarks>
        /// Determine if funds are available, get an approval and post directly to the account. Single message system (SMS), no file exchange after this.
        /// </remarks>
        MC2 = 2,

        /// <summary>
        /// File actions message
        /// </summary>
        /// <remarks>
        /// Used for hot-card, TMS and other exchanges
        /// </remarks>
        MC3 = 3,

        /// <summary>
        /// Reversal and chargeback messages
        /// </summary>
        /// <remarks>
        /// Reversal (x4x0 or x4x1): Reverses the action of a previous authorization.
        /// Chargeback (x4x2 or x4x3): Charges back a previously cleared financial message.
        /// </remarks>
        MC4 = 4,

        /// <summary>
        /// Reconciliation message
        /// </summary>
        /// <remarks>
        /// Transmits settlement information message.
        /// </remarks>
        MC5 = 5,

        /// <summary>
        /// Administrative message
        /// </summary>
        /// <remarks>
        /// Transmits administrative advice. Often used for failure messages (e.g., message reject or failure to apply).
        /// </remarks>
        MC6 = 6,

        /// <summary>
        /// Fee collection messages
        /// </summary>
        MC7 = 7,

        /// <summary>
        /// Network management message
        /// </summary>
        /// <remarks>
        /// Used for secure key exchange, logon, echo test and other network functions.
        /// </remarks>
        MC8 = 8,
    }
}
