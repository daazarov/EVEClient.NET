using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEClient.NET.IntegrationTests.Fakes
{
    internal class AccessTokenProviderEmptyFake : IAccessTokenProvider
    {
        public Task<string> RequestAccessToken()
        {
            return Task.FromResult(string.Empty);
        }
    }
}
