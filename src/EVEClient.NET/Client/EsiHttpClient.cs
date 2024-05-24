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
        private readonly IRequestPiplineBuilder _piplineBuilder;
        private readonly IEsiContextFactory _contextFactory;
        private readonly IPiplineStore _piplineStore;

        private Type callerMemberType = typeof(T);

        public EsiHttpClient(IEsiContextFactory contextFactory, IRequestPiplineBuilder piplineBuilder, IPiplineStore piplineStore)
        {
            _piplineBuilder = piplineBuilder;
            _contextFactory = contextFactory;
            _piplineStore = piplineStore;
        }

        public virtual async Task<EsiResponse> DeleteRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Delete.Method, callerMemberName),
                getter: key => _piplineBuilder.UseDeletePipline().Build()
            );

            var context = _contextFactory.CreateContext(callerMemberType, callerMemberName, requestModel);
            var handledContext = await pipline.ExecuteAsync(context);

            return new EsiResponse(handledContext.Response);
        }

        public virtual async Task<EsiResponsePagination<TResponse>> GetPaginationRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Get.Method, callerMemberName),
                getter: key => _piplineBuilder.UseGetPipline().Build()
            );

            var context = _contextFactory.CreateContext(callerMemberType, callerMemberName, requestModel);
            var handledContext = await pipline.ExecuteAsync(context);

            return new EsiResponsePagination<TResponse>(handledContext.Response);
        }

        public virtual async Task<EsiResponse<TResponse>> GetRequestAsync<TResponse>([CallerMemberName] string callerMemberName = "")
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Get.Method, callerMemberName),
                getter: key => _piplineBuilder.UseGetPipline().Build()
            );

            var context = _contextFactory.CreateContext(callerMemberType, callerMemberName);
            var handledContext = await pipline.ExecuteAsync(context);

            return new EsiResponse<TResponse>(handledContext.Response);
        }

        public virtual async Task<EsiResponse<TResponse>> GetRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Get.Method, callerMemberName),
                getter: key => _piplineBuilder.UseGetPipline().Build()
            );

            var context = _contextFactory.CreateContext(callerMemberType, callerMemberName, requestModel);
            var handledContext = await pipline.ExecuteAsync(context);

            return new EsiResponse<TResponse>(handledContext.Response);
        }

        public virtual async Task<EsiResponse> PostNoContentRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Post.Method, callerMemberName),
                getter: key => _piplineBuilder.UsePostPipline().Build()
            );

            var context = _contextFactory.CreateContext(callerMemberType, callerMemberName, requestModel);
            var handledContext = await pipline.ExecuteAsync(context);

            return new EsiResponse(handledContext.Response);
        }

        public virtual async Task<EsiResponse<TResponse>> PostRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Post.Method, callerMemberName),
                getter: key => _piplineBuilder.UsePostPipline().Build()
            );

            var context = _contextFactory.CreateContext(callerMemberType, callerMemberName, requestModel);
            var handledContext = await pipline.ExecuteAsync(context);

            return new EsiResponse<TResponse>(handledContext.Response);
        }

        public virtual async Task<EsiResponse> PutRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string callerMemberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Put.Method, callerMemberName),
                getter: key => _piplineBuilder.UsePutPipline().Build()
            );

            var context = _contextFactory.CreateContext(callerMemberType, callerMemberName, requestModel);
            var handledContext = await pipline.ExecuteAsync(_contextFactory.CreateContext(callerMemberType, callerMemberName, requestModel));

            return new EsiResponse(handledContext.Response);
        }

        private IRequestPipline GetOrSet(string key, Func<string, IRequestPipline> getter) => _piplineStore.GetPipline(key, getter);
        private string Key(string httpMethod, string callerMemberName) => $"{callerMemberType.Name}-{callerMemberName}-{httpMethod}";
    }
}
