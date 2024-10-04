using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EVEClient.NET.Pipline.Modifications;

namespace EVEClient.NET.Pipline
{
    internal class PiplineStore : IPiplineStore
    {
        private readonly Dictionary<string, IRequestPipline> _cache = new();
        private readonly IEnumerable<PiplineModification>? _modifications;
        private readonly IEndpointConfigurationProvider _configurations;

        internal const string DefaultGetPiplineKey = "get_default";
        internal const string DefaultPostPiplineKey = "post_default";
        internal const string DefaultPutPiplineKey = "put_default";
        internal const string DefaultDeletePiplineKey = "delete_default";

        public PiplineStore(IEndpointConfigurationProvider configurations, IEnumerable<PiplineModification>? modifications = null)
        {
            _modifications = modifications;
            _configurations = configurations;

            GenericPipline(DefaultGetPiplineKey, new RequestPiplineBuilder().UseGetPipline());
            GenericPipline(DefaultPostPiplineKey, new RequestPiplineBuilder().UsePostPipline());
            GenericPipline(DefaultPutPiplineKey, new RequestPiplineBuilder().UsePutPipline());
            GenericPipline(DefaultDeletePiplineKey, new RequestPiplineBuilder().UseDeletePipline());

            ApplyModifications();
        }

        public Task<IRequestPipline> GetPiplineAsync(string endpointId, HttpMethodType methodType)
        {
            if (_cache.TryGetValue(endpointId, out var pipline))
            {
                return Task.FromResult(pipline);
            }

            // no found custom pipline for the endpoint, use the default
            return methodType switch
            {
                HttpMethodType.Get => Task.FromResult(_cache[DefaultGetPiplineKey]),
                HttpMethodType.Post => Task.FromResult(_cache[DefaultPostPiplineKey]),
                HttpMethodType.Put => Task.FromResult(_cache[DefaultPutPiplineKey]),
                HttpMethodType.Delete => Task.FromResult(_cache[DefaultDeletePiplineKey]),
                _ => throw new InvalidOperationException("Unsupported HTTP method.")
            };
        }

        private void GenericPipline(string key, IRequestPiplineBuilder builder)
        {
            _cache.Add(key, builder.Build());
        }

        private void ApplyModifications()
        {
            if (_modifications is null)
            {
                return;
            }

            // We can have single endpoint settings in different modifiers. Let's combine them into one
            var normalizedModifications = new List<PiplineModification>();
            var groupedModifications = _modifications.GroupBy(x => x.EndpointId).ToList();

            foreach (var group in groupedModifications)
            {
                var completedModification = new PiplineModification(group.Key);

                foreach (var modificator in group)
                {
                    completedModification.Additions.AddRange(modificator.Additions);
                    completedModification.Replacements.AddRange(modificator.Replacements);
                }

                normalizedModifications.Add(completedModification);
            }

            // Apply modificators
            foreach (var modification in normalizedModifications)
            {
                var configuration = _configurations.GetEndpointConfiguration(modification.EndpointId);
                var piplineBuilder = new RequestPiplineBuilder(modification.Replacements, modification.Additions);

                // apply default pipline by http method
                switch (configuration.MethodType)
                { 
                    case HttpMethodType.Get:
                        piplineBuilder.UseGetPipline();
                        break;
                    case HttpMethodType.Post:
                        piplineBuilder.UsePostPipline();
                        break;
                    case HttpMethodType.Put:
                        piplineBuilder.UsePutPipline();
                        break;
                    case HttpMethodType.Delete:
                        piplineBuilder.UseDeletePipline();
                        break;
                }

                // the builder will modify the pipeline itself according to the modifications submitted
                _cache.Add(modification.EndpointId, piplineBuilder.Build());
            }
        }
    }
}
