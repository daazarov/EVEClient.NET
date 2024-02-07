using EVEOnline.ESI.Communication.Extensions;
using EVEOnline.ESI.Communication.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace EVEOnline.ESI.Communication.DependencyInjection
{
    internal static class IRequestPiplineBuilderExtensions
    {
        public static IRequestPiplineBuilder UseHandler<THandler>(this IRequestPiplineBuilder builder, params object[] args) where THandler : IHandler
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.Use(next =>
            {
                return context =>
                {
                    var instance = ActivatorUtilities.CreateInstance<THandler>(builder.ServiceProvider, args);

                    return instance.HandleAsync(context, next);
                };
            });
        }

        public static IRequestPiplineBuilder UseDeletePipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestDeleteHandler>();
        }

        public static IRequestPiplineBuilder UseGetPiplineWithoutRequestParameters(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<RequestHeadersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<ETagHandler>()
                          .UseHandler<RequestGetHandler>();
        }

        public static IRequestPiplineBuilder UseGetPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<ETagHandler>()
                          .UseHandler<RequestGetHandler>();
        }

        public static IRequestPiplineBuilder UsePostPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<BodyRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestPostHandler>();
        }

        public static IRequestPiplineBuilder UsePutPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<BodyRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestPutHandler>();
        }
    }
}
