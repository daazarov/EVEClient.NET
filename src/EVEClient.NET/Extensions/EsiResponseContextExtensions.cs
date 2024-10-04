using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace EVEClient.NET.Extensions
{
    public static class EsiResponseContextExtensions
    {
        public static Task<EsiResponse> ReadEsiResponse(this EsiResponseContext responseContext)
        {
            return GetResponseReaderProvider(responseContext).GetDefaultReader().ReadResponse<EsiResponse>(responseContext);
        }

        public static Task<EsiResponse<TResponse>> ReadEsiResponse<TResponse>(this EsiResponseContext responseContext)
        {
            return GetResponseReaderProvider(responseContext).GetGenericReader().ReadResponse<TResponse>(responseContext);
        }

        [Obsolete("EsiResponsePagination is obsolete and will be removed.")]
        public static Task<EsiResponsePagination<TResponse>> ReadPaginatedEsiResponse<TResponse>(this EsiResponseContext responseContext)
        {
            return Task.FromResult(new EsiResponsePagination<TResponse>(responseContext.Response));
        }

        private static IResponseReaderProvider GetResponseReaderProvider(EsiResponseContext context)
        {
            return context.EsiContext.ScopedServices.GetRequiredService<IResponseReaderProvider>();
        }
    }
}
