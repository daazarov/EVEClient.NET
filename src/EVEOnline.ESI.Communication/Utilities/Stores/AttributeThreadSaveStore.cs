using System;

namespace EVEOnline.ESI.Communication.Utilities.Stores
{
    internal static class AttributeThreadSaveStore<T> where T : Attribute
    {
        private static readonly ThreadSaveStore<object, T> _store = new ThreadSaveStore<object, T>();
        private static readonly ThreadSaveStore<object, T[]> _arrayStore = new ThreadSaveStore<object, T[]>();

        public static T GetAttribute(object attributeProvider, Func<object, T> getter)
        {
            return _store.Get(attributeProvider, getter);
        }

        public static T[] GetAttributes(object attributeProvider, Func<object, T[]> getter)
        {
            return _arrayStore.Get(attributeProvider, getter);
        }
    }
}
