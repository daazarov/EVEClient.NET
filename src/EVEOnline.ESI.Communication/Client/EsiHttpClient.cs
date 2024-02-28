using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Models;
using EVEOnline.ESI.Communication.Utilities;
using EVEOnline.ESI.Communication.Utilities.Stores;
using EVEOnline.ESI.Communication.Pipline;

namespace EVEOnline.ESI.Communication
{
    internal class EsiHttpClient<T> : IEsiHttpClient<T>
    {
        private readonly IRequestPiplineBuilder _piplineBuilder;
        private readonly IEsiContextFactory _contextFactory;
        private readonly Type _callingMemberType = typeof(T);

        public EsiHttpClient(IEsiContextFactory contextFactory, IRequestPiplineBuilder piplineBuilder)
        {
            _piplineBuilder = piplineBuilder;
            _contextFactory = contextFactory;
        }

        public virtual async Task<EsiResponse> DeleteRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Delete.Method, memberName),
                getter: key => _piplineBuilder.UseDeletePipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(_callingMemberType, memberName);
                var context = _contextFactory.CreateContext(endpointId, _callingMemberType, memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse(handledContext.Response);
            }
            catch(Exception ex)
            {
                return new EsiResponse(ex);
            }
        }

        public virtual async Task<EsiResponsePagination<TResponse>> GetPaginationRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Get.Method, memberName),
                getter: key => _piplineBuilder.UseGetPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(_callingMemberType, memberName);
                var context = _contextFactory.CreateContext(endpointId, _callingMemberType, memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponsePagination<TResponse>(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponsePagination<TResponse>(ex);
            }
        }

        public virtual async Task<EsiResponse<TResponse>> GetRequestAsync<TResponse>([CallerMemberName] string memberName = "")
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Get.Method, memberName),
                getter: key => _piplineBuilder.UseGetPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(_callingMemberType, memberName);
                var context = _contextFactory.CreateContext(endpointId, _callingMemberType, memberName);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse<TResponse>(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponse<TResponse>(ex);
            }
        }

        public virtual async Task<EsiResponse<TResponse>> GetRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Get.Method, memberName),
                getter: key => _piplineBuilder.UseGetPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(_callingMemberType, memberName);
                var context = _contextFactory.CreateContext(endpointId, _callingMemberType, memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse<TResponse>(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponse<TResponse>(ex);
            }
        }

        public virtual async Task<EsiResponse> PostNoContentRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Post.Method, memberName),
                getter: key => _piplineBuilder.UsePostPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(_callingMemberType, memberName);
                var context = _contextFactory.CreateContext(endpointId, _callingMemberType, memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponse(ex);
            }
        }

        public virtual async Task<EsiResponse<TResponse>> PostRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Post.Method, memberName),
                getter: key => _piplineBuilder.UsePostPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(_callingMemberType, memberName);
                var context = _contextFactory.CreateContext(endpointId, _callingMemberType, memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse<TResponse>(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponse<TResponse>(ex);
            }
        }

        public virtual async Task<EsiResponse> PutRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: Key(HttpMethod.Put.Method, memberName),
                getter: key => _piplineBuilder.UsePutPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(_callingMemberType, memberName);
                var context = _contextFactory.CreateContext(endpointId, _callingMemberType, memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponse(ex);
            }
        }

        private IRequestPipline GetOrSet(string key, Func<string, IRequestPipline> getter) => PiplineThreadSaveStore.GetPipline(key, getter);
        private string Key(string methodName, string callingMemberName) => string.Concat(_callingMemberType.Name, "-", callingMemberName, "-", methodName);
    }
}
