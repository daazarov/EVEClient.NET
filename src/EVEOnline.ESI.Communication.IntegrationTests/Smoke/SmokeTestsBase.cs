using EVEOnline.ESI.Communication.Utilities.Stores;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace EVEOnline.ESI.Communication.IntegrationTests.Smoke
{
    [TestFixture]
    [Category("SmokeTest")]
    public class SmokeTestsBase
    {
        protected ServiceProvider _serviceProvider;
        protected ServiceCollection _serviceCollection;
        protected IEsiLogicAccessor _logicAccessor;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _serviceCollection = new ServiceCollection();

            _serviceCollection.AddEVEOnlineEsiClient(config =>
            {
                config.Server = "tranquility";
                config.UserAgent = "github.com/daazarov/EVEOnline.ESI.Communication smoke tests";
                config.BaseUrl = "https://esi.evetech.net";
                config.EnableETag = true;
            });

            _serviceProvider = _serviceCollection.BuildServiceProvider();
            _logicAccessor = _serviceProvider.GetService<IEsiLogicAccessor>()!;
        }

        [SetUp]
        public void PerTestsSetup()
        {
            (_serviceProvider.GetService<IETagStorage>() as DefaultInMemoryETagThreadSaveStore)!.Clear();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _serviceProvider.Dispose();
        }
    }
}
