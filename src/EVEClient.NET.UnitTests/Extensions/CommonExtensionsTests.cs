using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.Extensions
{
    public class CommonExtensionsTests
    {
        [Test]
        public void ToEsiString_Single()
        {
            var roureType = RoutesFlag.Insecure;
            var esiString = roureType.ToEsiString();

            Assert.That(esiString, Is.EqualTo("insecure"));
        }

        [Test]
        public void ToEsiString_FlagAttribute_Single()
        {
            var categories = SearchCategory.Structure;
            var esiString = categories.ToEsiString();

            Assert.That(esiString, Is.EqualTo("structure"));
        }

        [Test]
        public void ToEsiString_FlagAttribute_Multiple()
        {
            var categories = SearchCategory.Structure | SearchCategory.Alliance | SearchCategory.Character;
            var esiString = categories.ToEsiString();

            Assert.That(esiString, Is.EqualTo("alliance,character,structure"));
        }

        [Test]
        public void ToEsiString_NullValue_ThrowException()
        {
            RoutesFlag? categories = null;

            Assert.Throws<ArgumentNullException>(() => categories.ToEsiString());
        }
    }
}
