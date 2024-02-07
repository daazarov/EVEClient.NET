using System;
using System.Net.Http;

using EVEOnline.ESI.Communication.Models;

namespace EVEOnline.ESI.Communication
{
    internal class EsiContextFactory : IEsiContextFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EsiContextFactory(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public EsiContext CreateContext(string endpointId, Type callingMemberType, string callingMemberName)
        {
            return new EsiContext(endpointId, _httpClientFactory.CreateClient(ESI.HttpClientName), new CallingContext(callingMemberName, callingMemberType));
        }

        public EsiContext CreateContext(string endpointId, Type callingMemberType, string callingMemberName, IRequestModel requestModel)
        {
            return new EsiContext(endpointId, _httpClientFactory.CreateClient(ESI.HttpClientName), new CallingContext(callingMemberName, callingMemberType), requestModel);
        }
    }
}
