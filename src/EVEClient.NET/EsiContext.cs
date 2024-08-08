using System;
using System.Collections.Generic;
using System.Net.Http;

using EVEClient.NET.Models;

namespace EVEClient.NET
{
    public class EsiContext
    {
        /// <summary>
        /// Get the internal model built on the basis of passed parameters.
        /// </summary>
        public IRequestModel? RequestModel { get; }

        /// <summary>
        /// Linking marker between EVEClient.NET methods and ESI endpoints Ids.
        /// </summary>
        public EndpointMarker EndpointMarker { get; }

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> that provides access to the request's service container.
        /// </summary>
        public IServiceProvider ScopedServices { get; }

        /// <summary>
        /// Gets the <see cref="HttpClient"/> that will be used to send the request.
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// Gets the <see cref="RequestContext"/> that contains data for forming a ready URL.
        /// </summary>
        public RequestContext RequestContext { get; }

        /// <summary>
        /// Gets the <see cref="HttpResponseMessage"/> received from the ESI API.
        /// </summary>
        public HttpResponseMessage Response { get; private set; } = default!;

        /// <summary>
        /// A container for storing custom objects between midleware components with per-request life cycle.
        /// </summary>
        public Dictionary<string, object> Items { get; } = new();

        public EsiContext(HttpClient httpClient, EndpointMarker endpointMarker, IServiceProvider scopedServices, string? token)
            : this(httpClient, endpointMarker, scopedServices, null!, token)
        {
        }

        public EsiContext(HttpClient httpClient, EndpointMarker endpointMarker, IServiceProvider scopedServices, IRequestModel requestModel, string? token)
        {
            HttpClient = httpClient;
            EndpointMarker = endpointMarker;
            ScopedServices = scopedServices;
            RequestModel = requestModel;

            var endpointId = EndpointMarker.ToEndpointId();
            if (string.IsNullOrEmpty(endpointId))
            {
                throw new InvalidOperationException($"Can not convert EndpointMartker to endpoint id. HttpMethodType: {endpointMarker.HttpMethodType}; CallerType: {endpointMarker.CallerType}; CallerName: {endpointMarker.CallerName}");
            }

            RequestContext = new RequestContext { EndpointId = endpointId, Token = token };
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
        /// <summary>
        /// The ready built URL to which the request will be executed.
        /// </summary>
        public string RequestUrl { get; internal set; } = default!;

        /// <summary>
        /// The ESI endpoint identifier.
        /// </summary>
        public string EndpointId { get; internal set; } = default!;

        /// <summary>
        /// The request body.
        /// </summary>
        public HttpContent? Body { get; internal set; }

        /// <summary>
        /// Available ready built routes for sending a request to a specific endpoint Id.
        /// </summary>
        public Dictionary<EndpointVersion, string> EndpointUrls { get; } = new();

        /// <summary>
        /// Gets a list of parameters to be replaced in the route of the request.
        /// </summary>
        public Dictionary<string, string> PathParametersMap { get; } = new();

        /// <summary>
        /// Gets a list of parameters to be replaced in the query of the request.
        /// </summary>
        public Dictionary<string, string> QueryParametersMap { get; } = new();

        /// <summary>
        /// Gets an access token which was passed as an input parameter.
        /// </summary>
        public string? Token { get; internal set; }
    }
}
