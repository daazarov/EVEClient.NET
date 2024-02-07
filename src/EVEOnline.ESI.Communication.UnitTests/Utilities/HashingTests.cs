using EVEOnline.ESI.Communication.Utilities.Hashing;
using NUnit.Framework;

namespace EVEOnline.ESI.Communication.UnitTests.Utilities
{
    public class HashingTests
    {
        [Test]
        public void HashingFactory_CreateHashingInstance_Empty_ReturnMD5Hashing()
        {
            var factory = new HashingFactory();

            var hashing = factory.CreateHashingInstance();

            Assert.That(hashing is Md5Hashing);
        }

        [Test]
        public void HashingFactory_CreateHashingInstance_Default_ReturnMD5Hashing()
        {
            var factory = new HashingFactory();

            var hashing = factory.CreateHashingInstance(HashingAliases.Default);

            Assert.That(hashing is Md5Hashing);
        }

        [Test]
        public void HashingFactory_CreateHashingInstance_MD5_ReturnMD5Hashing()
        {
            var factory = new HashingFactory();

            var hashing = factory.CreateHashingInstance(HashingAliases.MD5);

            Assert.That(hashing is Md5Hashing);
        }

        [Test]
        public void HashingFactory_CreateHashingInstance_SHA256_ReturnSHA256Hashing()
        {
            var factory = new HashingFactory();

            var hashing = factory.CreateHashingInstance(HashingAliases.SHA256);

            Assert.That(hashing is Sha256Hashing);
        }

        [Test]
        public void Md5Hashing_GenerateHash_MD5_SameHashFromSameValue()
        {
            var value = "test_value";
            var hashing = new HashingFactory().CreateHashingInstance(HashingAliases.MD5);

            var hash1 = hashing.GenerateHash(value);
            var hash2 = hashing.GenerateHash(value);

            Assert.That(hash1, Is.EqualTo(hash2));
        }

        [Test]
        public void Md5Hashing_GenerateHash_SHA256_SameHashFromSameValue()
        {
            var value = "test_value";
            var hashing = new HashingFactory().CreateHashingInstance(HashingAliases.SHA256);

            var hash1 = hashing.GenerateHash(value);
            var hash2 = hashing.GenerateHash(value);

            Assert.That(hash1, Is.EqualTo(hash2));
        }

        [Test]
        public void Md5Hashing_GenerateHash_MD5_DifferentHashFromDifferentValue()
        {
            var value1 = "test_value1";
            var value2 = "test_value2";
            var hashing = new HashingFactory().CreateHashingInstance(HashingAliases.MD5);

            var hash1 = hashing.GenerateHash(value1);
            var hash2 = hashing.GenerateHash(value2);

            Assert.That(hash1, Is.Not.EqualTo(hash2));
        }

        [Test]
        public void Md5Hashing_GenerateHash_SHA256_DifferentHashFromDifferentValue()
        {
            var value1 = "test_value1";
            var value2 = "test_value2";
            var hashing = new HashingFactory().CreateHashingInstance(HashingAliases.SHA256);

            var hash1 = hashing.GenerateHash(value1);
            var hash2 = hashing.GenerateHash(value2);

            Assert.That(hash1, Is.Not.EqualTo(hash2));
        }
    }
}
