using System;
using ISO8583Tools.Extension;

namespace ISO8583Tools.Modles
{
    /// <summary>
    /// Iso8583Message.
    /// </summary>
    public abstract class DtoAbstractMessage<TElements>
        where TElements : DtoAbstractElements
    {
        /// <summary>
        /// Header.
        /// </summary>
        public byte[] Header { get; set; }

        /// <summary>
        /// TPDU (Transaction Protocol Data Unit).
        /// </summary>
        [Element(ElementType = Enums.EnumElementType.B, BytesLength = 5)]
        public string Tpud { get; set; }

        /// <summary>
        /// MTI (Message type indicator).
        /// </summary>
        [Element(ElementType = Enums.EnumElementType.B, BytesLength = 2)]
        public DtoMessageType MessageType { get; set; }

        /// <summary>
        /// Primary BitMap
        /// </summary>
        [Element(ElementType = Enums.EnumElementType.B, BytesLength = 8)]
        public DtoBitMap PrimaryBitMap { get; set; }

        /// <summary>
        /// Secondary BitMap
        /// </summary>
        public DtoBitMap SecondaryBitMap
        {
            get { return this.Elements.SecondBitmap; }
        }

        /// <summary>
        /// Elements
        /// </summary>
        public TElements Elements { get; set; }
    }
}
