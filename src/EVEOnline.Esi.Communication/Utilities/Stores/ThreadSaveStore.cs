using System;
using System.Collections.Concurrent;

namespace EVEOnline.Esi.Communication.Utilities.Stores
{
    internal class ThreadSaveStore<TKey, TValue>
    {
        private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore = new ConcurrentDictionary<TKey, TValue>();

        public TValue? Get(TKey key, Func<TKey, TValue> getter)
        {
            return _concurrentStore.GetOrAdd(key, getter);
        }
    }
}
