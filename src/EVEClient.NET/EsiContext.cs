using System;
using System.Collections.Generic;
using System.Net.Http;

using EVEClient.NET.Models;

namespace EVEClient.NET
{
    public class EsiContext
    {
        public IRequestModel RequestModel { get; }
        public EndpointMarker EndpointMarker { get; }
        public IServiceProvider ScopedServices { get; }
        public HttpClient HttpClient { get; }
        public RequestContext RequestContext { get; }
        public HttpResponseMessage Response { get; private set; }
        public Dictionary<string, object> Items { get; } = [];

        public EsiContext(HttpClient httpClient, EndpointMarker endpointMarker, IServiceProvider scopedServices) : this(httpClient, endpointMarker, scopedServices, null)
        {
        }

        public EsiContext(HttpClient httpClient, EndpointMarker endpointMarker, IServiceProvider scopedServices, IRequestModel requestModel)
        {
            HttpClient = httpClient;
            EndpointMarker = endpointMarker;
            ScopedServices = scopedServices;
            RequestModel = requestModel;

            RequestContext = new RequestContext { EndpointId = EndpointMarker };
        }

        public void SetHttpResponseMessage(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage == null)
            { 
                throw new ArgumentNullException(nameof(httpResponseMessage));
            }

            Response = httpResponseMessage;
        }
    }

    public class RequestContext
    {
        public string RequestUrl { get; internal set; }
        public string EndpointId { get; internal set; }
        public HttpContent? Body { get; internal set; }
        public Dictionary<EndpointVersion, string> EndpointUrls { get; } = [];
        public Dictionary<string, string> PathParametersMap { get; } = [];
        public Dictionary<string, string> QueryParametersMap { get; } = [];
    }
}
