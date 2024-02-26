using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;
using NUnit.Framework;

namespace EVEOnline.ESI.Communication.UnitTests.Extensions
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
    }
}
