using System;
using System.Linq;
using System.Reflection;
using EVEClient.NET.Extensions;

namespace EVEClient.NET.Utilities
{
    public abstract class AttributeAccessor
    {
        public abstract bool ContainsAttribute<T>(object attributeProvider) where T : Attribute;
        public abstract T? GetAttribute<T>(object attributeProvider) where T : Attribute;
        public abstract T[]? GetAttributes<T>(object attributeProvider) where T : Attribute;

        public T? GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
        {
            T[] attributes = GetAttributes<T>(attributeProvider, inherit);

            return attributes?.FirstOrDefault();
        }

        public T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
        {
            Attribute[] a = GetAttributes(attributeProvider, typeof(T), inherit);

            if (a is T[] attributes)
            {
                return attributes;
            }

            return a.Cast<T>().ToArray();
        }

        public Attribute[] GetAttributes(object attributeProvider, Type? attributeType, bool inherit)
        {
            attributeProvider.ArgumentNotNull(nameof(attributeProvider));

            object provider = attributeProvider;

            switch (provider)
            {
                case Type t:
                    object[] array = attributeType != null ? t.GetCustomAttributes(attributeType, inherit) : t.GetCustomAttributes(inherit);
                    Attribute[] attributes = array.Cast<Attribute>().ToArray();
                    return attributes;
                case Assembly a:
                    return attributeType != null ? Attribute.GetCustomAttributes(a, attributeType) : Attribute.GetCustomAttributes(a);
                case MemberInfo mi:
                    return attributeType != null ? Attribute.GetCustomAttributes(mi, attributeType, inherit) : Attribute.GetCustomAttributes(mi, inherit);
                case ParameterInfo p:
                    return attributeType != null ? Attribute.GetCustomAttributes(p, attributeType, inherit) : Attribute.GetCustomAttributes(p, inherit);
                default:
                    ICustomAttributeProvider customAttributeProvider = (ICustomAttributeProvider)attributeProvider;
                    object[] result = attributeType != null ? customAttributeProvider.GetCustomAttributes(attributeType, inherit) : customAttributeProvider.GetCustomAttributes(inherit);

                    return (Attribute[])result;
            }
        }
    }
}
