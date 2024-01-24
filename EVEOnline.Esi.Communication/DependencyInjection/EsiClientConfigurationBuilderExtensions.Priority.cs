using System;

using EVEOnline.Esi.Communication.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class EsiClientConfigurationBuilderExtensions
    {
        public static IEsiClientConfigurationBuilder UseOnlyLatestEndpoints(this IEsiClientConfigurationBuilder builder)
        {
            builder.Configuration.RoutePriority.UseOnlyLatestRoutes = true;
            builder.Configuration.RoutePriority.UseDevelopmentRoutes = false;

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseDevEndpoints(this IEsiClientConfigurationBuilder builder)
        {
            builder.Configuration.RoutePriority.UseDevelopmentRoutes = true;
            builder.Configuration.RoutePriority.UseOnlyLatestRoutes = false;

            return builder;
        }
    }
}
