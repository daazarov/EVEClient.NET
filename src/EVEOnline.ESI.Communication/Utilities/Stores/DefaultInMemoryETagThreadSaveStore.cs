using System.Collections;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.Utilities.Stores
{
    internal class DefaultInMemoryETagThreadSaveStore : IETagStorage
    {
        private readonly Hashtable _store = new Hashtable();

        public Task StoreETagAsync(string eTagKey, string eTag)
        {
            if (_store.ContainsKey(eTagKey))
            {
                return ReplaceETagAsync(eTagKey, eTag);
            }

            _store.Add(eTagKey, eTag);

            return Task.CompletedTask;
        }

        public Task<bool> TryGetETagAsync(string eTagKey, out string eTag)
        {
            eTag = null;

            if (_store.ContainsKey(eTagKey))
            {
                eTag = _store[eTagKey].ToString();

                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task ReplaceETagAsync(string eTagKey, string eTag)
        {
            _store[eTagKey] = eTag;

            return Task.CompletedTask;
        }

        /// <summary>
        /// For tests porpouse only
        /// </summary>
        internal void Clear()
        {
            _store.Clear();
        }
    }
}
