using EVEClient.NET.Utilities;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.Utilities
{
    public class EndpointsMapperTests
    {
        [Test]
        public void EndpointsMapper_UniqiueValues()
        {
            Assert.That(() => EndpointsMapper.Instance.Select(x => x.Value).Distinct().Count() == EndpointsMapper.Instance.Count());
        }

        [Test]
        public void EndpointsMapper_NotEmpryValues()
        {
            Assert.That(() => !EndpointsMapper.Instance.Any(x => string.IsNullOrEmpty(x.Value)));
        }
    }
}
