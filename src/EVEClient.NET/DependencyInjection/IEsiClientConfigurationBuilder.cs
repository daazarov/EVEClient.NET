using EVEClient.NET.Configuration;
using EVEClient.NET.Pipline.Modifications;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IEsiClientConfigurationBuilder
    {
        /// <summary>
        /// Gets the services being configured.
        /// </summary>
        IServiceCollection Services { get; }

        /// <summary>
        /// Gets the <see cref="IPiplineModificationsBuilder"/>.
        /// </summary>
        IPiplineModificationsBuilder PiplineModificationBuilder { get; }

        /// <summary>
        /// Gets the EVE client configuration.
        /// </summary>
        EsiClientConfiguration Configuration { get; }
    }
}
