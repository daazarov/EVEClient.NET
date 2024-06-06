using System;
using System.Collections.Generic;
using System.Linq;

using EVEClient.NET.Pipline.Modifications;
using EVEClient.NET.Utilities;

namespace EVEClient.NET.Pipline
{
    internal class PiplineStore : IPiplineStore
    {
        private readonly Dictionary<string, IRequestPipline> _cache = [];
        private readonly IEnumerable<PiplineModification> _modifications;

        public PiplineStore(IEnumerable<PiplineModification> modifications = null)
        {
            _modifications = modifications;

            GenericPipline(EndpointMarker.DefaultGet, new RequestPiplineBuilder().UseGetPipline());
            GenericPipline(EndpointMarker.DefaultPost, new RequestPiplineBuilder().UsePostPipline());
            GenericPipline(EndpointMarker.DefaultPut, new RequestPiplineBuilder().UsePutPipline());
            GenericPipline(EndpointMarker.DefaultDelete, new RequestPiplineBuilder().UseDeletePipline());

            ApplyModifications();
        }

        public IRequestPipline GetPipline(EndpointMarker marker)
        {
            if (_cache.TryGetValue(marker, out var pipline))
            {
                return pipline;
            }

            // found no custom settings for the endpoint. We use the default
            return marker.HttpMethodType switch
            {
                "GET" => _cache[EndpointMarker.DefaultGet],
                "POST" => _cache[EndpointMarker.DefaultPost],
                "PUT" => _cache[EndpointMarker.DefaultPut],
                "DELETE" => _cache[EndpointMarker.DefaultDelete],
                _ => throw new InvalidOperationException("Unsupported HTTP method.")
            };
        }

        private void GenericPipline(EndpointMarker marker, IRequestPiplineBuilder builder)
        {
            _cache.Add(marker, builder.Build());
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
                var marker = EndpointsMapper.Instance[modification.EndpointId];
                var piplineBuilder = new RequestPiplineBuilder(modification.Replacements, modification.Additions);

                // apply default pipline by http method
                switch (marker.HttpMethodType)
                { 
                    case "GET":
                        piplineBuilder.UseGetPipline();
                        break;
                    case "POST":
                        piplineBuilder.UsePostPipline();
                        break;
                    case "PUT":
                        piplineBuilder.UsePutPipline();
                        break;
                    case "DELETE":
                        piplineBuilder.UseDeletePipline();
                        break;
                }

                // the builder will modify the pipeline itself according to the modifications submitted
                _cache.Add(marker, piplineBuilder.Build());
            }
        }
    }
}
