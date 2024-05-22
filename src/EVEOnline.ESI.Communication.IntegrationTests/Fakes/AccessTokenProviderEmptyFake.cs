using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.IntegrationTests.Fakes
{
    internal class AccessTokenProviderEmptyFake : IAccessTokenProvider
    {
        public Task<string> RequestAccessToken()
        {
            return Task.FromResult(string.Empty);
        }
    }
}
