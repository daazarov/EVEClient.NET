using System;
using System.Threading.Tasks;

using EVEClient.NET.Extensions;

namespace EVEClient.NET.Pipline
{
    public class PiplineComponent
    {
        /// <summary>
        /// The middleware delegate.
        /// </summary>
        public Func<RequestDelegate, RequestDelegate> Behavior { get; }

        /// <summary>
        /// The middleware component identifier.
        /// </summary>
        public string ComponentId { get; }

        public PiplineComponent(string componentId, Func<RequestDelegate, RequestDelegate> behavior)
        {
            componentId.ArgumentStringNotNullOrEmpty(nameof(componentId));
            behavior.ArgumentNotNull(nameof(behavior));
            
            ComponentId = componentId;
            Behavior = behavior;
        }
    }

    /// <summary>
    /// A function that can process an ESI HTTP request.
    /// </summary>
    /// <param name="context">The ESI context <see cref="EsiContext"/> for the request.</param>
    /// <returns>A task that represents the completion of request processing.</returns>
    public delegate Task RequestDelegate(EsiContext context);
}
