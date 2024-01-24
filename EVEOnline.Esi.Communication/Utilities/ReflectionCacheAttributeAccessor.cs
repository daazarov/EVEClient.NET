using EVEOnline.Esi.Communication.Utilities.Stores;

namespace EVEOnline.Esi.Communication.Utilities
{
    internal class ReflectionCacheAttributeAccessor : AttributeAccessor
    {
        internal static ReflectionCacheAttributeAccessor Instance => new ReflectionCacheAttributeAccessor();

        public override bool ContainsAttribute<T>(object attributeProvider)
        {
            return GetAttribute<T>(attributeProvider) != null;
        }

        public override T[] GetAttributes<T>(object attributeProvider)
        {
            return AttributeThreadSaveStore<T>.GetAttributes(attributeProvider, provider => GetAttributes<T>(provider, true));
        }

        public override T GetAttribute<T>(object attributeProvider)
        {
            return AttributeThreadSaveStore<T>.GetAttribute(attributeProvider, provider => GetAttribute<T>(provider, true));
        }
    }
}
