using System;
using System.Threading.Tasks;

namespace EVEClient.NET.Defaults
{
    internal class PublicAccessTokenProvider : IAccessTokenProvider
    {
        public Task<string> RequestAccessToken()
        {
            throw new InvalidOperationException("This provider is designed to call only public esi endpoints.");
        }
    }
}
