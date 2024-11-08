using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EVEClient.NET.Pipline.Modifications;

namespace EVEClient.NET.Pipline
{
    internal class DefaultPiplineStore : IPiplineStore
    {
        private readonly Dictionary<string, IRequestPipline> _cache = new();
        private readonly IEnumerable<PiplineModification>? _modifications;

        internal const string DefaultPiplineKey = "pipline_default";

        public DefaultPiplineStore(IEnumerable<PiplineModification>? modifications = null)
        {
            _modifications = modifications;

            DefaultPipline(DefaultPiplineKey, new RequestPiplineBuilder().UseDefaultPipline());

            ApplyModifications();
        }

        public Task<IRequestPipline> GetPiplineAsync(string endpointId)
        {
            if (_cache.TryGetValue(endpointId, out var pipline))
            {
                return Task.FromResult(pipline);
            }

            // no found custom pipline for the endpoint, use the default
            return Task.FromResult(_cache[DefaultPiplineKey]);
        }

        private void DefaultPipline(string key, IRequestPiplineBuilder builder)
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
                }

                normalizedModifications.Add(completedModification);
            }

            // Apply modificators
            foreach (var modification in normalizedModifications)
            {
                var piplineBuilder = new RequestPiplineBuilder(modification.Additions).UseDefaultPipline();

                // the builder will modify the pipeline itself according to the modifications submitted
                _cache.Add(modification.EndpointId, piplineBuilder.Build());
            }
        }
    }
}
