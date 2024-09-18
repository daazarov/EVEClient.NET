using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using EVEClient.NET.Models;
using EVEClient.NET.Pipline;

namespace EVEClient.NET
{
    internal class EsiHttpClient<T> : IEsiHttpClient<T>
    {
        private readonly IEsiContextFactory _contextFactory;
        private readonly IPiplineStore _piplineStore;

        private Type callerMemberType = typeof(T);

        public EsiHttpClient(IEsiContextFactory contextFactory, IPiplineStore piplineStore)
        {
            _contextFactory = contextFactory;
            _piplineStore = piplineStore;
        }

        public virtual async Task<EsiResponse> DeleteRequestAsync<TRequest>(TRequest requestModel, string? token = null, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var marker = new EndpointMarker(HttpMethod.Delete.Method, callerMemberType, callerMemberName);
            var context = _contextFactory.CreateContext(marker, requestModel, token);
            var handledContext = await _piplineStore.GetPipline(marker).ExecuteAsync(context);

            return new EsiResponseDefault(handledContext.Response);
        }

        public virtual async Task<EsiResponsePagination<TResponse>> GetPaginationRequestAsync<TRequest, TResponse>(TRequest requestModel, string? token = null, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var marker = new EndpointMarker(HttpMethod.Get.Method, callerMemberType, callerMemberName);
            var context = _contextFactory.CreateContext(marker, requestModel, token);
            var handledContext = await _piplineStore.GetPipline(marker).ExecuteAsync(context);

            return new EsiResponsePagination<TResponse>(handledContext.Response);
        }

        public virtual async Task<EsiResponse<TResponse>> GetRequestAsync<TResponse>(string? token = null, [CallerMemberName] string callerMemberName = "")
        {
            var marker = new EndpointMarker(HttpMethod.Delete.Method, callerMemberType, callerMemberName);
            var context = _contextFactory.CreateContext(marker, token);
            var handledContext = await _piplineStore.GetPipline(marker).ExecuteAsync(context);

            return new EsiResponseDefaultGeneric<TResponse>(handledContext.Response);
        }

        public virtual async Task<EsiResponse<TResponse>> GetRequestAsync<TRequest, TResponse>(TRequest requestModel, string? token = null, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var marker = new EndpointMarker(HttpMethod.Get.Method, callerMemberType, callerMemberName);
            var context = _contextFactory.CreateContext(marker, requestModel, token);
            var handledContext = await _piplineStore.GetPipline(marker).ExecuteAsync(context);

            return new EsiResponseDefaultGeneric<TResponse>(handledContext.Response);
        }

        public virtual async Task<EsiResponse> PostNoContentRequestAsync<TRequest>(TRequest requestModel, string? token = null, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var marker = new EndpointMarker(HttpMethod.Post.Method, callerMemberType, callerMemberName);
            var context = _contextFactory.CreateContext(marker, requestModel, token);
            var handledContext = await _piplineStore.GetPipline(marker).ExecuteAsync(context);

            return new EsiResponseDefault(handledContext.Response);
        }

        public virtual async Task<EsiResponse<TResponse>> PostRequestAsync<TRequest, TResponse>(TRequest requestModel, string? token = null, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var marker = new EndpointMarker(HttpMethod.Post.Method, callerMemberType, callerMemberName);
            var context = _contextFactory.CreateContext(marker, requestModel, token);
            var handledContext = await _piplineStore.GetPipline(marker).ExecuteAsync(context);

            return new EsiResponseDefaultGeneric<TResponse>(handledContext.Response);
        }

        public virtual async Task<EsiResponse> PutRequestAsync<TRequest>(TRequest requestModel, string? token = null, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var marker = new EndpointMarker(HttpMethod.Put.Method, callerMemberType, callerMemberName);
            var context = _contextFactory.CreateContext(marker, requestModel, token);
            var handledContext = await _piplineStore.GetPipline(marker).ExecuteAsync(context);

            return new EsiResponseDefault(handledContext.Response);
        }
    }
}
