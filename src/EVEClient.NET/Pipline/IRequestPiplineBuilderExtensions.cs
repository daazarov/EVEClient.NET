using Microsoft.Extensions.DependencyInjection;

using EVEClient.NET.Extensions;
using EVEClient.NET.Handlers;

namespace EVEClient.NET.Pipline
{
    internal static class IRequestPiplineBuilderExtensions
    {
        /// <summary>
        /// Adds a handler type to the ESI endpoint request pipeline.
        /// </summary>
        /// <typeparam name="THandler">The handler type.</typeparam>
        /// <param name="builder">The <see cref="IRequestPiplineBuilder"/>.</param>
        public static IRequestPiplineBuilder UseHandler<THandler>(this IRequestPiplineBuilder builder) where THandler : IHandler
        {
            builder.ArgumentNotNull(nameof(builder));

            var componentId = typeof(THandler).Name;

            return builder.Use(new PiplineComponent(componentId, next =>
            {
                return context =>
                {
                    var handler = context.ScopedServices.GetRequiredService<THandler>();
                    
                    return handler.HandleAsync(context, next);
                };
            }));
        }

        /// <summary>
        /// Prepare the default middleware for the Delete ESI endpoints.
        /// </summary>
        /// <param name="builder">The <see cref="IRequestPiplineBuilder"/>.</param>
        public static IRequestPiplineBuilder UseDeletePipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<ProtectionHandler>()
                          .UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestDeleteHandler>();
        }

        /// <summary>
        /// Prepare the default middleware for the Get ESI endpoints.
        /// </summary>
        /// <param name="builder">The <see cref="IRequestPiplineBuilder"/>.</param>
        public static IRequestPiplineBuilder UseGetPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<ProtectionHandler>()
                          .UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<ETagHandler>()
                          .UseHandler<RequestGetHandler>();
        }

        /// <summary>
        /// Prepare the default middleware for the Post ESI endpoints.
        /// </summary>
        /// <param name="builder">The <see cref="IRequestPiplineBuilder"/>.</param>
        public static IRequestPiplineBuilder UsePostPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<ProtectionHandler>()
                          .UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<BodyRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestPostHandler>();
        }

        /// <summary>
        /// Prepare the default middleware for the Put ESI endpoints.
        /// </summary>
        /// <param name="builder">The <see cref="IRequestPiplineBuilder"/>.</param>
        public static IRequestPiplineBuilder UsePutPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<ProtectionHandler>()
                          .UseHandler<RequestHeadersHandler>()
                          .UseHandler<UrlRequestParametersHandler>()
                          .UseHandler<BodyRequestParametersHandler>()
                          .UseHandler<EndpointHandler>()
                          .UseHandler<RequestPutHandler>();
        }
    }
}
