using System;
using System.Collections.Generic;
using System.Text;
using ISO8583Tools.Modles.Enums;

namespace ISO8583Tools
{
    /// <summary>
    /// ElementAttribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ElementAttribute : Attribute
    {
        public int Index { get; set; }

        public int BytesLength { get; set; }

        public EnumElementType ElementType { get; set; }

        public bool Fixed { get; set; } = true;
    }
}
