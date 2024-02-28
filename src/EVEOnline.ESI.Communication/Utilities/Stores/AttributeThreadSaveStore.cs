using System;

namespace EVEOnline.ESI.Communication.Utilities.Stores
{
    internal static class AttributeThreadSaveStore<T> where T : Attribute
    {
        private static readonly ThreadSaveStore<object, T[]> _arrayStore = new ThreadSaveStore<object, T[]>();

        public static T[] GetAttributes(object attributeProvider, Func<object, T[]> getter)
        {
            return _arrayStore.Get(attributeProvider, getter);
        }
    }
}
