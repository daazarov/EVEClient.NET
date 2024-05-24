using System;
using System.Net.Http;

using EVEClient.NET.Models;

namespace EVEClient.NET
{
    internal class EsiContextFactory : IEsiContextFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EsiContextFactory(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public EsiContext CreateContext(Type callingMemberType, string callingMemberName)
        {
            return new EsiContext(_httpClientFactory.CreateClient(ESI.HttpClientName), new CallingContext(callingMemberName, callingMemberType));
        }

        public EsiContext CreateContext(Type callingMemberType, string callingMemberName, IRequestModel requestModel)
        {
            return new EsiContext(_httpClientFactory.CreateClient(ESI.HttpClientName), new CallingContext(callingMemberName, callingMemberType), requestModel);
        }
    }
}
