using Microsoft.Extensions.DependencyInjection;

using EVEOnline.ESI.Communication.Extensions;
using EVEOnline.ESI.Communication.Handlers;

namespace EVEOnline.ESI.Communication.Pipline
{
    internal static class IRequestPiplineBuilderExtensions
    {
        public static IRequestPiplineBuilder UseHandler<THandler>(this IRequestPiplineBuilder builder) where THandler : IHandler
        {
            builder.ArgumentNotNull(nameof(builder));

            var instance = builder.ServiceProvider.GetService<THandler>();

            return builder.Use(next =>
            {
                return context =>
                {
                    return instance.HandleAsync(context, next);
                };
            });
        }

        public static IRequestPiplineBuilder UseDeletePipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            builder.Clear();

            return builder.UseHandler<ProtectionHandler>()
                          .UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestDeleteHandler>();
        }

        public static IRequestPiplineBuilder UseGetPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            builder.Clear();

            return builder.UseHandler<ProtectionHandler>()
                          .UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<ETagHandler>()
                          .UseHandler<RequestGetHandler>();
        }

        public static IRequestPiplineBuilder UsePostPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            builder.Clear();

            return builder.UseHandler<ProtectionHandler>()
                          .UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<BodyRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestPostHandler>();
        }

        public static IRequestPiplineBuilder UsePutPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            builder.Clear();

            return builder.UseHandler<ProtectionHandler>()
                          .UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<BodyRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestPutHandler>();
        }
    }
}
