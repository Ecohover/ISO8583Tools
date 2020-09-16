using ISO8583Tools.Extension;
using ISO8583Tools.Modles;
using System.Collections.Generic;

namespace ISO8583Tools
{
    /// <summary>
    /// Packager.
    /// </summary>
    public class Packager : IPackager
    {
        private const int MaxLength = 128;

        public byte[] Package<TMessage, TElements>(TMessage dtoMessage)
            where TElements : DtoAbstractElements
            where TMessage : DtoAbstractMessage<TElements>
        {
            List<byte> result = new List<byte>();
            
            for (int i = 2; i <= MaxLength; i++)
            {

            }

            return result.ToArray();
        }

        public TMessage UnPackage<TMessage, TElements>(byte[] bytes)
            where TElements : DtoAbstractElements
            where TMessage : DtoAbstractMessage<TElements>
        {

            return null;
        }
    }
}
