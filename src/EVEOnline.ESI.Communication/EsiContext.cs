using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;

using EVEOnline.ESI.Communication.Models;
using EVEOnline.ESI.Communication.Extensions;

namespace EVEOnline.ESI.Communication
{
    public class EsiContext
    {
        private readonly IRequestModel _requestModel;
        private readonly HttpClient _httpClient;
        private readonly CallingContext _callingContext;
        private readonly RequestContext _request;
        private readonly string _endpointId;
        private HttpResponseMessage _httpResponseMessage;

        public string EndpointId
        {
            get => _endpointId;
        }
        public IRequestModel RequestModel
        {
            get => _requestModel;
        }
        public CallingContext CallingContext
        {
            get => _callingContext;
        }
        public HttpClient HttpClient
        { 
            get => _httpClient;
        }
        public RequestContext RequestContext
        {
            get => _request;
        }
        public HttpResponseMessage Response
        {
            get => _httpResponseMessage;
        }

        public EsiContext(string endpointId, HttpClient httpClient, CallingContext callingContext, IRequestModel requestModel)
            : this(endpointId, httpClient, callingContext)
        {
            _requestModel = requestModel.ArgumentNotNull(nameof(httpClient));
        }

        public EsiContext(string endpointId, HttpClient httpClient, CallingContext callingContext)
        {
            _httpClient = httpClient.ArgumentNotNull(nameof(httpClient));
            _callingContext = callingContext.ArgumentNotNull(nameof(httpClient));
            _endpointId = endpointId.ArgumentStringNotNullOrEmpty(nameof(endpointId));

            _request = new RequestContext();
        }

        public void SetHttpResponseMessage(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage == null)
            { 
                throw new ArgumentNullException(nameof(httpResponseMessage));
            }

            _httpResponseMessage = httpResponseMessage;
        }
    }

    public class CallingContext
    {
        private readonly string _callingMemberName;
        private readonly Type _callingMemberType;
        private readonly MethodInfo _methodInfo;

        public MethodInfo MethodInfo
        {
            get => _methodInfo;
        }

        public CallingContext(string callingMemberName, Type callingMemberType)
        { 
            _callingMemberName = callingMemberName;
            _callingMemberType = callingMemberType;

            _methodInfo = _callingMemberType.GetMethod(_callingMemberName);
        }
    }

    public class RequestContext
    {
        public RouteQueue RouteQueue { get; set; }
        public HttpContent? Body { get; set; }
        public Dictionary<string, string>? PathParametersMap { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string>? QueryParametersMap { get; set; } = new Dictionary<string, string>();
    }
}
