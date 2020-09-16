using System;
using System.Collections.Generic;
using ISO8583Tools.Extension;

namespace ISO8583Tools.Modles
{
    /// <summary>
    /// Iso8583Message.
    /// </summary>
    public class DtoTsMessage<TElements> : DtoAbstractMessage<TElements>
        where TElements : DtoAbstractElements
    {
        public DtoTsMessage()
        {
        }

        public DtoTsMessage(byte[] vs)
        {
            var index = 0;
            var sizeLength = this.Size.GetLength();
            var sizeBuffer = new byte[sizeLength];
            Array.Copy(vs, index, sizeBuffer, 0, sizeLength);
            this.Size = BitConverter.ToInt32(sizeBuffer, 0);

            var tpudLength = this.Tpud.GetLength();
            index += tpudLength;
            byte[] tpudBuffer = new byte[tpudLength];
            Array.Copy(vs, 0, tpudBuffer, 0, tpudLength);
            this.Tpud = tpudBuffer.ToHexString();

            var messageTypeLength = this.MessageType.GetLength();
            index += messageTypeLength;
            byte[] messageTypeBuffer = new byte[messageTypeLength];
            Array.Copy(vs, 0, messageTypeBuffer, 0, messageTypeLength);
            this.MessageType = new DtoMessageType(messageTypeBuffer);

            byte[] mtiArray = new byte[5];
            this.MessageType = new DtoMessageType(vs);
        }

        /// <summary>
        /// It's the number of data.(Exclude itself, Stx, etx and checksun).
        /// </summary>
        [Element(Index = 0, ElementType = Enums.EnumElementType.B, BytesLength = 2)]
        public int Size { get; set; }

        /// <summary>
        /// Starting to transfer data.
        /// </summary>
        public int Stx { get; set; }

        /// <summary>
        /// Ending to transfer data.
        /// </summary>
        public int Etx { get; set; }

        /// <summary>
        /// Checksum(Exclude itself, Stx, etx and Size).
        /// </summary>
        public int Checksum { get; set; }
    }
}
