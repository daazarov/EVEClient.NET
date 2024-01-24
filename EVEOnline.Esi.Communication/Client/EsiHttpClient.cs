using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract.Requests.Internal;
using EVEOnline.Esi.Communication.Extensions;
using EVEOnline.Esi.Communication.Utilities;
using EVEOnline.Esi.Communication.Utilities.Stores;

namespace EVEOnline.Esi.Communication
{
    internal class EsiHttpClient<T> : IEsiHttpClient<T>
    {
        private readonly IRequestPiplineBuilder _piplineBuilder;
        private readonly IEsiContextFactory _contextFactory;

        public EsiHttpClient(IEsiContextFactory contextFactory, IRequestPiplineBuilder piplineBuilder)
        {
            _piplineBuilder = piplineBuilder;
            _contextFactory = contextFactory;
        }

        public virtual async Task<EsiResponse> DeleteNoContentRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: GetKey(Esi.EsiClientMethodNames.DeleteNoContentRequest, memberName),
                getter: key => _piplineBuilder.UseDeletePipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(memberName);
                var context = _contextFactory.CreateContext(endpointId, typeof(T), memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse(handledContext.Response);
            }
            catch(Exception ex)
            {
                return new EsiResponse(ex);
            }
        }

        public virtual async Task<EsiResponsePagination<TResponse>> GetPaginationRequestAsync<TResponse>([CallerMemberName] string memberName = "")
        {
            var pipline = GetOrSet
            (
                key: GetKey(Esi.EsiClientMethodNames.GetPaginationRequestWithouRequestParameters, memberName),
                getter: key => _piplineBuilder.UseGetPiplineWithoutRequestParameters().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(memberName);
                var context = _contextFactory.CreateContext(endpointId, typeof(T), memberName);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponsePagination<TResponse>(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponsePagination<TResponse>(ex);
            };
        }

        public virtual async Task<EsiResponsePagination<TResponse>> GetPaginationRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: GetKey(Esi.EsiClientMethodNames.GetPaginationRequest, memberName),
                getter: key => _piplineBuilder.UseGetPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(memberName);
                var context = _contextFactory.CreateContext(endpointId, typeof(T), memberName, requestModel);
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
                key: GetKey(Esi.EsiClientMethodNames.GetRequestWithouRequestParameters, memberName),
                getter: key => _piplineBuilder.UseGetPiplineWithoutRequestParameters().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(memberName);
                var context = _contextFactory.CreateContext(endpointId, typeof(T), memberName);
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
                key: GetKey(Esi.EsiClientMethodNames.GetRequest, memberName),
                getter: key => _piplineBuilder.UseGetPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(memberName);
                var context = _contextFactory.CreateContext(endpointId, typeof(T), memberName, requestModel);
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
                key: GetKey(Esi.EsiClientMethodNames.PostNoContentRequest, memberName),
                getter: key => _piplineBuilder.UsePostPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(memberName);
                var context = _contextFactory.CreateContext(endpointId, typeof(T), memberName, requestModel);
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
                key: GetKey(Esi.EsiClientMethodNames.PostRequest, memberName),
                getter: key => _piplineBuilder.UsePostPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(memberName);
                var context = _contextFactory.CreateContext(endpointId, typeof(T), memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse<TResponse>(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponse<TResponse>(ex);
            }
        }

        public virtual async Task<EsiResponse> PutNoContentRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string memberName = "") where TRequest : IRequestModel
        {
            var pipline = GetOrSet
            (
                key: GetKey(Esi.EsiClientMethodNames.PutNoContentRequest, memberName),
                getter: key => _piplineBuilder.UsePostPipline().Build()
            );

            try
            {
                var endpointId = CallerMemberToEnpointIdConverter.ToEndpointId(memberName);
                var context = _contextFactory.CreateContext(endpointId, typeof(T), memberName, requestModel);
                var handledContext = await pipline.ExecuteAsync(context);

                return new EsiResponse(handledContext.Response);
            }
            catch (Exception ex)
            {
                return new EsiResponse(ex);
            }
        }

        private IRequestPipline GetOrSet(string key, Func<string, IRequestPipline> getter)
        {
            return PiplineThreadSaveStore<T>.GetPipline(key, getter);
        }

        private string GetKey(string methodName, string callingMemberName) => string.Concat(methodName, "-", callingMemberName);
    }
}
