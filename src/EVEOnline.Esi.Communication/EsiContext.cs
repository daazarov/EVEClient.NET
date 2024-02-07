﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;

using EVEOnline.Esi.Communication.DataContract.Requests.Internal;
using EVEOnline.Esi.Communication.Extensions;

namespace EVEOnline.Esi.Communication
{
    internal class EsiContext
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

    internal class CallingContext
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

    internal class RequestContext
    {
        public RouteQueue RouteQueue { get; set; }
        public HttpContent? Body { get; set; }
        public Dictionary<string, string>? RouteParametersMap { get; set; }
        public Dictionary<string, string>? QueryParametersMap { get; set; }
    }
}
