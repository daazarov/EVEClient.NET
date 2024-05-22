using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;

using EVEOnline.ESI.Communication.Models;
using EVEOnline.ESI.Communication.Extensions;
using EVEOnline.ESI.Communication.Utilities;

namespace EVEOnline.ESI.Communication
{
    public class EsiContext
    {
        private readonly IRequestModel _requestModel;
        private readonly HttpClient _httpClient;
        private readonly CallingContext _callingContext;
        private readonly RequestContext _request;
        private HttpResponseMessage _httpResponseMessage;

        public IRequestModel RequestModel => _requestModel;
        public CallingContext CallingContext => _callingContext;
        public HttpClient HttpClient => _httpClient;
        public RequestContext RequestContext => _request;
        public HttpResponseMessage Response => _httpResponseMessage;

        public EsiContext(HttpClient httpClient, CallingContext callingContext, IRequestModel requestModel)
            : this(httpClient, callingContext)
        {
            _requestModel = requestModel.ArgumentNotNull(nameof(requestModel));
        }

        public EsiContext(HttpClient httpClient, CallingContext callingContext)
        {
            _httpClient = httpClient.ArgumentNotNull(nameof(httpClient));
            _callingContext = callingContext.ArgumentNotNull(nameof(httpClient));

            _request = new RequestContext
            { 
                EndpointId = CallerMemberToEnpointIdConverter.ToEndpointId(CallingContext.CallingMemberType, CallingContext.CallingMemberName)
            };
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

        public MethodInfo MethodInfo => _methodInfo;
        public Type CallingMemberType => _callingMemberType;
        public string CallingMemberName => _callingMemberName;

        public CallingContext(string callingMemberName, Type callingMemberType)
        { 
            _callingMemberName = callingMemberName;
            _callingMemberType = callingMemberType;

            _methodInfo = _callingMemberType.GetMethod(_callingMemberName);
        }
    }

    public class RequestContext
    {
        public string RequestUrl { get; internal set; }
        public string EndpointId { get; internal set; }
        public HttpContent? Body { get; internal set; }
        public Dictionary<EndpointVersion, string> EndpointUrls { get; internal set; } = new Dictionary<EndpointVersion, string>();
        public Dictionary<string, string>? PathParametersMap { get; internal set; } = new Dictionary<string, string>();
        public Dictionary<string, string>? QueryParametersMap { get; internal set; } = new Dictionary<string, string>();
    }
}
