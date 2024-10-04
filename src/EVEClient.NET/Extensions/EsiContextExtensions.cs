using System;
using System.Linq;

using Microsoft.Extensions.DependencyInjection;

using EVEClient.NET.Configuration;
using System.Collections.Generic;

namespace EVEClient.NET.Extensions
{
    public static class EsiContextExtensions
    {
        /// <summary>
        /// Indicates whether the ESI endpoint is public for the created context.
        /// </summary>
        /// <param name="context">The <see cref="EsiContext"/>.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool IsProtectedEndpoint(this EsiContext context)
        {
            return GetEndpointConfiguration(context).ProtectedEndpoint;
        }

        public static List<Route> GetEndpointRoutes(this EsiContext context)
        {
            return GetEndpointConfiguration(context).Routes.ToList();
        }

        public static string? GetEndpointRequiredScope(this EsiContext context)
        {
            return GetEndpointConfiguration(context).Scope;
        }

        private static EndpointConfiguration GetEndpointConfiguration(EsiContext context)
        {
            var configurations = context.ScopedServices.GetRequiredService<IEndpointConfigurationProvider>();
            return configurations.GetEndpointConfiguration(context.EndpointId);
        }
    }
}
