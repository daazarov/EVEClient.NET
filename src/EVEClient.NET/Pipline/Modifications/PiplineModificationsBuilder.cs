using System;
using System.Collections.Generic;
using System.Linq;

using EVEClient.NET.Extensions;

namespace EVEClient.NET.Pipline.Modifications
{
    internal class PiplineModificationsBuilder : IPiplineModificationsBuilder
    {
        internal readonly List<PiplineModification> Modifications = new();
        internal readonly Dictionary<string, List<string>> AddedComponentIds = new();
        internal readonly string[] DefaultsComponentIds =
        {
            "RequestHeadersHandler",
            "UrlRequestParametersHandler",
            "RequestGetHandler",
            "RequestPostHandler",
            "RequestDeleteHandler",
            "RequestPutHandler",
            "ETagHandler",
            "EndpointHandler",
            "ProtectionHandler",
            "BodyRequestParametersHandler"
        };

        public IEndpointModificationBuilder ModificationFor(string endpointId)
        {
            endpointId.ArgumentStringNotNullOrEmpty(nameof(endpointId));

            var modification = new PiplineModification(endpointId);
            Modifications.Add(modification);
            return new SingleEndpointModificationBuilder(modification, this);
        }

        public IEndpointModificationBuilder ModificationFor(string[] endpointIds)
        {
            if (endpointIds is null || endpointIds.Length == 0 || endpointIds.Any(string.IsNullOrEmpty))
            {
                throw new ArgumentException("Endpoint IDs can not be null or empty.");
            }

            return new CompositeEndpointModificationBuilder(endpointIds.Select(ModificationFor));
        }

        public IEndpointModificationBuilder ModificationFor(EndpointsSelector selector)
        {
            if (selector.HasFlag(EndpointsSelector.AllRequests))
            {
                return ModificationFor(EndpointsMapper.Instance.Select(x => x.Value).ToArray());
            }

            var endpoindIds = new List<string>();

            if (selector.HasFlag(EndpointsSelector.GetRequests))
            {
                endpoindIds.AddRange(EndpointsMapper.Instance.Where(x => x.Key.HttpMethodType == "GET").Select(x => x.Value));
            }
            if (selector.HasFlag(EndpointsSelector.PutRequests))
            {
                endpoindIds.AddRange(EndpointsMapper.Instance.Where(x => x.Key.HttpMethodType == "PUT").Select(x => x.Value));
            }
            if (selector.HasFlag(EndpointsSelector.PostRequests))
            {
                endpoindIds.AddRange(EndpointsMapper.Instance.Where(x => x.Key.HttpMethodType == "POST").Select(x => x.Value));
            }
            if (selector.HasFlag(EndpointsSelector.DeleteRequests))
            {
                endpoindIds.AddRange(EndpointsMapper.Instance.Where(x => x.Key.HttpMethodType == "DELETE").Select(x => x.Value));
            }

            return ModificationFor(endpoindIds.ToArray());
        }

        public void Validate()
        {
            foreach (var group in Modifications.GroupBy(m => m.EndpointId))
            {
                // 1. Validate modifiers for the existence of a endpoint
                var unknownModifications = group.Where(x => EndpointsMapper.Instance[x.EndpointId] == EndpointMarker.Null).ToList();
                if (unknownModifications.Any())
                    throw new InvalidOperationException($"Unknown endpoint identifiers: {string.Join(", ", unknownModifications.Select(x => x.EndpointId).Distinct())}.");

                foreach (var modification in group)
                {
                    // 2. One PiplineModification did not have multiple AdditionalComponents with the same componentId
                    var duplicateAdditionalComponentIds = modification.Additions
                        .GroupBy(a => a.PiplineComponent.ComponentId)
                        .Where(g => g.Count() > 1)
                        .Select(g => g.Key)
                        .ToList();
                    if (duplicateAdditionalComponentIds.Any())
                        throw new InvalidOperationException($"Duplicate AdditionalComponent ids found: {string.Join(", ", duplicateAdditionalComponentIds)}");

                    // 3. One PiplineModification does not have multiple ReplaceComponents that replace the same ReplaceId
                    var duplicateReplaceIds = modification.Replacements
                        .GroupBy(r => r.ReplaceId)
                        .Where(g => g.Count() > 1)
                        .Select(g => g.Key)
                        .ToList();
                    if (duplicateReplaceIds.Any())
                        throw new InvalidOperationException($"Duplicate ReplaceIds found: {string.Join(", ", duplicateReplaceIds)}");

                    // 4. ReplaceId of the ReplaceComponent is contained in the list of valid values
                    var invalidReplaceIds = modification.Replacements
                        .Where(r => !DefaultsComponentIds.Contains(r.ReplaceId))
                        .Select(r => r.ReplaceId)
                        .ToList();
                    if (invalidReplaceIds.Any())
                        throw new InvalidOperationException($"{string.Join(", ", invalidReplaceIds)} component ids to be replaced is not found among the list of standard components. See the list of components available for replacement: {string.Join(", ", DefaultsComponentIds)}");

                    // 5. There is no AdditionalComponent where all properties except PiplineComponent have a default value
                    var unconfiguredAdditionalComponents = modification.Additions
                        .Where(a => string.IsNullOrEmpty(a.AddAfter) && !a.AddToEnd && !a.AddToStart && !a.EndOrder.HasValue && !a.StartOrder.HasValue)
                        .ToList();
                    if (unconfiguredAdditionalComponents.Any())
                        throw new InvalidOperationException($"AdditionalComponent without location customization found: {string.Join(", ", unconfiguredAdditionalComponents)}");

                    // 6. There is no AdditionalComponent where AddToEnd and AddToStart = true together
                    var invalidAdditionalComponents = modification.Additions
                        .Where(a => a.AddToEnd && a.AddToStart)
                        .ToList();
                    if (invalidAdditionalComponents.Any())
                        throw new InvalidOperationException($"AdditionalComponent with conflict customization found: {string.Join(", ", invalidAdditionalComponents)}");

                    // 7. If the AdditionalComponent has AddToEnd or AddToStart = true, AddAfter must not be populated 
                    var invalidAddAfterWhenAddToEndOrStart = modification.Additions
                        .Where(a => (a.AddToEnd || a.AddToStart) && !string.IsNullOrEmpty(a.AddAfter))
                        .ToList();
                    if (invalidAddAfterWhenAddToEndOrStart.Any())
                        throw new InvalidOperationException($"AdditionalComponent with AddToEnd or AddToStart true should not have AddAfter set. {string.Join(", ", invalidAddAfterWhenAddToEndOrStart)}");

                    // 8. If there is more than one AdditionalComponent where AddToEnd = true, then they must have EndOrder populated
                    var addToEndComponents = modification.Additions.Where(a => a.AddToEnd).ToList();
                    if (addToEndComponents.Count > 1 && addToEndComponents.Any(a => !a.EndOrder.HasValue))
                        throw new InvalidOperationException($"AddToEnd components without EndOrder found. {string.Join(", ", addToEndComponents)}");

                    // 9. If there are multiple AdditionalComponents where AddToStart = true, they must have StartOrder populated
                    var addToStartComponents = modification.Additions.Where(a => a.AddToStart).ToList();
                    if (addToStartComponents.Count > 1 && addToStartComponents.Any(a => !a.StartOrder.HasValue))
                        throw new InvalidOperationException($"AddToStart components without StartOrder found. {string.Join(", ", addToStartComponents)}");

                    // 10. There are not multiple AdditionalComponents where AddToEnd = true and the same EndOrder
                    var duplicateEndOrders = addToEndComponents
                        .GroupBy(a => a.EndOrder)
                        .Where(g => g.Count() > 1)
                        .SelectMany(g => g)
                        .ToList();
                    if (duplicateEndOrders.Any())
                        throw new InvalidOperationException($"Duplicate EndOrders found in: {string.Join(", ", duplicateEndOrders.Select(x => x.PiplineComponent.ComponentId))}");

                    // 11. There are not multiple AdditionalComponents where AddToStart = true and the same StartOrder
                    var duplicateStartOrders = addToStartComponents
                        .GroupBy(a => a.StartOrder)
                        .Where(g => g.Count() > 1)
                        .SelectMany(g => g)
                        .ToList();
                    if (duplicateStartOrders.Any())
                        throw new InvalidOperationException($"Duplicate StartOrders found in: {string.Join(", ", duplicateStartOrders.Select(x => x.PiplineComponent.ComponentId))}");

                    // 12. To have the AddAfter of an AdditionalComponent contained in the list of allowed values, or equal to one of the ComponentId in the PiplineComponent
                    var validComponentIds = new HashSet<string>(modification.Additions.Select(a => a.PiplineComponent.ComponentId));
                    var invalidAddAfterIds = modification.Additions
                        .Where(a => !string.IsNullOrEmpty(a.AddAfter) && !DefaultsComponentIds.Contains(a.AddAfter) && !validComponentIds.Contains(a.AddAfter))
                        .Select(a => a.AddAfter)
                        .ToList();
                    if (invalidAddAfterIds.Any())
                        throw new InvalidOperationException($"Invalid AddAfter ids found: {string.Join(", ", invalidAddAfterIds)}");

                    // 13. AddAfter does not refer to the component to be replaced
                    var componentsToBeReplace = new HashSet<string>(modification.Replacements.Select(a => a.ReplaceId));
                    var componentIdsWithIncorrectAddAfter = modification.Additions
                        .Where(a => !string.IsNullOrEmpty(a.AddAfter) && componentsToBeReplace.Contains(a.AddAfter))
                        .Select(a => a.PiplineComponent.ComponentId)
                        .ToList();
                    if(componentIdsWithIncorrectAddAfter.Any())
                        throw new InvalidOperationException($"AddAfter refer to the component to be replaced: {string.Join(", ", componentIdsWithIncorrectAddAfter)}");
                }
            }
        }
    }
}
