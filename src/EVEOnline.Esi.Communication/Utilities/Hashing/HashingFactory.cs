using System;
using System.Collections.Generic;

namespace EVEOnline.ESI.Communication.Utilities.Hashing
{
    internal class HashingFactory
    {
        public static HashingFactory Instance => new HashingFactory();

        private readonly Dictionary<string, Func<IHashing>> _hashingRegistry;

        public HashingFactory()
        {
            _hashingRegistry = new Dictionary<string, Func<IHashing>>()
            {
                { string.Empty, () => new Md5Hashing() },
                { HashingAliases.Default, () => new Md5Hashing() },
                { HashingAliases.SHA256, () => new Sha256Hashing() }
            };
        }

        public IHashing CreateHashingInstance(string alias = "")
        {
            if (_hashingRegistry.TryGetValue(alias, out var predicate))
            {
                return predicate.Invoke();
            }

            return _hashingRegistry[HashingAliases.Default]();
        }
    }
}
