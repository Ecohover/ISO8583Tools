using System;
using System.Collections.Generic;
using System.Text;
using ISO8583Tools.Modles;

namespace ISO8583Tools
{
    public interface IPackager
    {
        byte[] Package<TMessage, TElements>(TMessage dtoMessage)
            where TElements : DtoAbstractElements
            where TMessage : DtoAbstractMessage<TElements>;

        TMessage UnPackage<TMessage, TElements>(byte[] vs)
            where TElements : DtoAbstractElements
            where TMessage : DtoAbstractMessage<TElements>;
    }
}
