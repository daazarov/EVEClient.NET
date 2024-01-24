using System;
using System.Net.Http;

using EVEOnline.Esi.Communication.DataContract.Requests.Internal;

namespace EVEOnline.Esi.Communication
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
            return new EsiContext(endpointId, _httpClientFactory.CreateClient("EsiHttpClient"), new CallingContext(callingMemberName, callingMemberType));
        }

        public EsiContext CreateContext(string endpointId, Type callingMemberType, string callingMemberName, IRequestModel requestModel)
        {
            return new EsiContext(endpointId, _httpClientFactory.CreateClient("EsiHttpClient"), new CallingContext(callingMemberName, callingMemberType), requestModel);
        }
    }
}
