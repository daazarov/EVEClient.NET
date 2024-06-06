using System;
using System.Net.Http;

using EVEClient.NET.Models;

namespace EVEClient.NET
{
    internal class EsiContextFactory : IEsiContextFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IServiceProvider _scoped;

        public EsiContextFactory(IHttpClientFactory httpClientFactory, IServiceProvider scoped)
        {
            _httpClientFactory = httpClientFactory;
            _scoped = scoped;
        }

        public EsiContext CreateContext(EndpointMarker marker)
        {
            return new EsiContext(_httpClientFactory.CreateClient(ESI.HttpClientName), marker, _scoped);
        }

        public EsiContext CreateContext(EndpointMarker marker, IRequestModel requestModel)
        {
            return new EsiContext(_httpClientFactory.CreateClient(ESI.HttpClientName), marker, _scoped, requestModel);
        }
    }
}
