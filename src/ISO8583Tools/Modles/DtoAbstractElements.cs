using System;
using System.Collections.Generic;
using System.Text;

namespace ISO8583Tools.Modles
{
    public abstract class DtoAbstractElements
    {
        /// <summary>
        /// Second Bitmap
        /// </summary>
        [Element(Index = 1, ElementType = Enums.EnumElementType.B, BytesLength = 8)]
        public DtoBitMap SecondBitmap { get; set; }
    }
}
