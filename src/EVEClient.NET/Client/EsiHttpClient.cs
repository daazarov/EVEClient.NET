using System;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.Models;
using EVEClient.NET.Pipline;

namespace EVEClient.NET
{
    internal class EsiHttpClient : IEsiHttpClient
    {
        private readonly IPiplineStore _piplineStore;
        private readonly IServiceProvider _serviceProvider;
        private readonly IEndpointConfigurationProvider _configurations;

        public EsiHttpClient(IPiplineStore piplineStore, IServiceProvider serviceProvider, IEndpointConfigurationProvider configurations)
        {
            _piplineStore = piplineStore;
            _configurations = configurations;

            // 
            _serviceProvider = serviceProvider;
        }

        public async Task<EsiResponseContext> Request(string endpointId, EsiRequest request, ExecutionOptions options = ExecutionOptions.None, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(request);
            ArgumentNullException.ThrowIfNullOrEmpty(endpointId);

            var config = _configurations.GetEndpointConfiguration(endpointId);
            if (config is null)
            {
                throw new InvalidOperationException("Failed to retrieve configuration for the ESI endpoint identifier: " + endpointId);
            }

            var context = new EsiContext(endpointId, request)
            {
                CancellationToken = cancellationToken,
                ExecutionOptions = options,
                ScopedServices = _serviceProvider
            };

            var pipline = await _piplineStore.GetPiplineAsync(endpointId, config.MethodType);
            
            return (await pipline.ExecuteAsync(context)).ResponseContext;
        }
    }
}
