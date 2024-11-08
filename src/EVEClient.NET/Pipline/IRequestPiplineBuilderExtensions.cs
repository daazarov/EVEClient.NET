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
        /// Prepare the default middleware for the ESI endpoints.
        /// </summary>
        /// <param name="builder">The <see cref="IRequestPiplineBuilder"/>.</param>
        public static IRequestPiplineBuilder UseDefaultPipline(this IRequestPiplineBuilder builder)
        {
            builder.ArgumentNotNull(nameof(builder));

            return builder.UseHandler<DefaultRequestProtectionHandler>()
                          .UseHandler<DefaultRequestETagHandler>()
                          .UseHandler<DefaultRequestSendingHandler>();
        }
    }
}
