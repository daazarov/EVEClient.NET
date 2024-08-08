using System;
using System.Collections.Generic;
using System.Linq;

using EVEClient.NET.Pipline.Modifications;
using EVEClient.NET.Utilities;

namespace EVEClient.NET.Pipline
{
    internal class PiplineStore : IPiplineStore
    {
        private readonly Dictionary<string, IRequestPipline> _cache = new();
        private readonly IEnumerable<PiplineModification>? _modifications;

        private const string DefaultGetPiplineKey = "get_default";
        private const string DefaultPostPiplineKey = "post_default";
        private const string DefaultPutPiplineKey = "put_default";
        private const string DefaultDeletePiplineKey = "delete_default";

        public PiplineStore(IEnumerable<PiplineModification>? modifications = null)
        {
            _modifications = modifications;

            GenericPipline(DefaultGetPiplineKey, new RequestPiplineBuilder().UseGetPipline());
            GenericPipline(DefaultPostPiplineKey, new RequestPiplineBuilder().UsePostPipline());
            GenericPipline(DefaultPutPiplineKey, new RequestPiplineBuilder().UsePutPipline());
            GenericPipline(DefaultDeletePiplineKey, new RequestPiplineBuilder().UseDeletePipline());

            ApplyModifications();
        }

        public IRequestPipline GetPipline(EndpointMarker marker)
        {
            var endpointId = marker.ToEndpointId();
            if (string.IsNullOrEmpty(endpointId))
            {
                throw new InvalidOperationException($"Can not convert EndpointMartker to endpoint id. HttpMethodType: {marker.HttpMethodType}; CallerType: {marker.CallerType}; CallerName: {marker.CallerName}");
            }

            if (_cache.TryGetValue(endpointId, out var pipline))
            {
                return pipline;
            }

            // found no custom settings for the endpoint. We use the default
            return marker.HttpMethodType switch
            {
                "GET" => _cache[DefaultGetPiplineKey],
                "POST" => _cache[DefaultPostPiplineKey],
                "PUT" => _cache[DefaultPutPiplineKey],
                "DELETE" => _cache[DefaultDeletePiplineKey],
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
                var marker = EndpointsMapper.Instance[modification.EndpointId];
                if (marker == EndpointMarker.Null)
                {
                    throw new InvalidOperationException($"Unknown ESI entpoint identifier: { modification.EndpointId }");
                }

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
                _cache.Add(modification.EndpointId, piplineBuilder.Build());
            }
        }
    }
}
