using Microsoft.Extensions.DependencyInjection;

using EVEClient.NET.Extensions;
using EVEClient.NET.Handlers;

namespace EVEClient.NET.Pipline
{
    internal static class IRequestPiplineBuilderExtensions
    {
        public static IRequestPiplineBuilder UseHandler<THandler>(this IRequestPiplineBuilder builder) where THandler : IHandler
        {
            builder.ArgumentNotNull(nameof(builder));

            // to do
            // Now we have an artificial singleton when injecting services into our handler.
            // Since the pipline is created once and cached for each of the request types.
            // Perhaps we should detach from the IHandler interface and create a "HandleAsync" method call dynamically with passing the necessary services as an input parameter.
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
