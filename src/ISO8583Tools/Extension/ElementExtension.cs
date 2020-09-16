using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ISO8583Tools.Modles;

namespace ISO8583Tools.Extension
{
    public static class ElementExtension
    {
        public static TProperty GetElementByIndex<TClass, TProperty>(this DtoAbstractElements self, int index)
            where TClass : DtoAbstractElements
        {
            if (self == null)
            {
                throw new ArgumentNullException($"({self}) is null");
            }

            PropertyInfo[] propertyInfo = typeof(TProperty).GetProperties(BindingFlags.Public);

            if (propertyInfo != null)
            {
                return (TProperty)propertyInfo.Where(p => p.CheckIndex(index)).FirstOrDefault().GetValue(self);
            }

            return default(TProperty);
        }

        public static bool CheckIndex(this PropertyInfo self, int index)
        {
            ElementAttribute attribute = (ElementAttribute)self.GetCustomAttribute(typeof(ElementAttribute), false);
            return attribute.Index == index;
        }

        public static int GetLength(this object self)
        {
            FieldInfo fi = self.GetType().GetField(self.ToString());
            ElementAttribute[] attributes = null;

            if (fi != null)
            {
                attributes = (ElementAttribute[])fi.GetCustomAttributes(typeof(ElementAttribute), false);

                if (attributes != null && attributes.Length > 0)
                {
                    return attributes[0].BytesLength;
                }
            }

            return 0;
        }
    }
}
