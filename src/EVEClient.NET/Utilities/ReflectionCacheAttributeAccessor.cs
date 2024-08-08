using System.Linq;
using EVEClient.NET.Utilities.Stores;

namespace EVEClient.NET.Utilities
{
    internal class ReflectionCacheAttributeAccessor : AttributeAccessor
    {
        internal static ReflectionCacheAttributeAccessor Instance => new ReflectionCacheAttributeAccessor();

        public override bool ContainsAttribute<T>(object attributeProvider)
        {
            return GetAttribute<T>(attributeProvider) != null;
        }

        public override T? GetAttribute<T>(object attributeProvider) where T : class
        {
            return GetAttributes<T>(attributeProvider)?.FirstOrDefault();
        }

        public override T[]? GetAttributes<T>(object attributeProvider)
        {
            return AttributeThreadSaveStore<T>.GetAttributes(attributeProvider, provider => GetAttributes<T>(provider, true));
        }
    }
}
