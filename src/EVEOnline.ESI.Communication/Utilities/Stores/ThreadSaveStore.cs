using System;
using System.Collections.Concurrent;

namespace EVEOnline.ESI.Communication.Utilities.Stores
{
    internal class ThreadSaveStore<TKey, TValue> where TKey : notnull
    {
        private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore = new ConcurrentDictionary<TKey, TValue>();

        public TValue? Get(TKey key, Func<TKey, TValue> getter)
        {
            return _concurrentStore.GetOrAdd(key, getter);
        }
    }
}
