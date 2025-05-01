using System;
using EVEClient.NET.Handlers;

namespace EVEClient.NET.Pipline.Modifications
{
    public interface IEndpointModificationBuilder
    {
        /// <summary>
        /// Adds the custom EVE middleware component in addition to the defaults.
        /// </summary>
        /// <typeparam name="CustomHandler">The custom handler type.</typeparam>
        /// <param name="addAfter">The identifier of the component after which to place the new custom component.</param>
        /// <param name="addToEnd">Indicates that a new custom component should be added at the end of middleware.</param>
        /// <param name="addToStart">Indicates that a new custom component should be added at the start of middleware.</param>
        /// <param name="endOrder">
        /// The order in which components are placed, if more than one component has been added to the end. 
        /// The component with order number "0" will be called before the component with order number "1".
        /// </param>
        /// <param name="startOrder">
        /// The order in which components are placed, if more than one component has been added to the start. 
        /// The component with order number "0" will be called before the component with order number "1".
        /// </param>
        IEndpointModificationBuilder AdditionalHandler<CustomHandler>(string? addAfter = null, bool addToEnd = false, bool addToStart = false, int? endOrder = null, int? startOrder = null)
            where CustomHandler : IHandler;

        /// <summary>
        /// Adds the custom EVE middleware component in addition to the defaults.
        /// </summary>
        /// <param name="componentId">The uniquie identifier of new ESI middleware component.</param>
        /// <param name="middleware">The middleware delegate.</param>
        /// <param name="addToEnd">Indicates that a new custom component should be added at the end of middleware.</param>
        /// <param name="addToStart">Indicates that a new custom component should be added at the start of middleware.</param>
        /// <param name="endOrder">
        /// The order in which components are placed, if more than one component has been added to the end. 
        /// The component with order number "0" will be called before the component with order number "1".
        /// </param>
        /// <param name="startOrder">
        /// The order in which components are placed, if more than one component has been added to the start. 
        /// The component with order number "0" will be called before the component with order number "1".
        /// </param>
        IEndpointModificationBuilder AdditionalMiddleware(string componentId, Func<RequestDelegate, RequestDelegate> middleware, string? addAfter = null, bool addToEnd = false, bool addToStart = false, int? endOrder = null, int? startOrder = null);

    }
}
