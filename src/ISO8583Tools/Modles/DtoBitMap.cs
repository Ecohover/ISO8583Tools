using System;
using System.Collections.Generic;
using System.Text;

namespace ISO8583Tools.Modles
{
    public class DtoBitMap
    {
        public DtoBitMap(byte[] bytes)
        {

        }

        public Dictionary<int, bool> keyValues = new Dictionary<int, bool>();

        public string HexString { get; set; }
    }
}
