using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EVEClient.NET.Pipline.Modifications;

namespace EVEClient.NET.Pipline
{
    internal class RequestPiplineBuilder : IRequestPiplineBuilder
    {
        private readonly List<PiplineComponent> _components = [];
        private readonly List<ReplaceComponent> _replacements;
        private readonly List<AdditionalComponent> _additions;

        public RequestPiplineBuilder(List<ReplaceComponent> replacements = null, List<AdditionalComponent> additions = null)
        {
            _additions = additions ?? new();
            _replacements = replacements ?? new();
        }

        public IRequestPipline Build()
        {
            // Now all validation for modifiers happens when configuring the pipelines in DI.
            // So far the library has no alternative ways of configuring the pipeline other than DI.
            // But everything may change, it may be worth performing validation of correctness of modifier settings here as well

            foreach (var replacement in _replacements)
            {
                var index = _components.FindIndex(c => c.ComponentId == replacement.ReplaceId);
                if (index >= 0)
                {
                    _components[index] = replacement.PiplineComponent;
                }
            }

            var additionsToEnd = _additions.Where(a => a.AddToEnd).OrderBy(a => a.EndOrder).ToList();
            var additionsToStart = _additions.Where(a => a.AddToStart).OrderByDescending(a => a.StartOrder).ToList();
            var additionsInBetween = _additions.Where(a => !a.AddToEnd && !a.AddToStart).ToList();
            var nonLocatedComponents = new List<(string AddAfter, PiplineComponent Component)>();

            additionsToStart.ForEach(x => _components.Insert(0, x.PiplineComponent));
            additionsToEnd.ForEach(x => _components.Add(x.PiplineComponent));

            foreach (var addition in additionsInBetween)
            {
                var index = _components.FindIndex(c => c.ComponentId == addition.AddAfter);
                if (index >= 0)
                {
                    _components.Insert(index + 1, addition.PiplineComponent);
                }
                else
                {
                    nonLocatedComponents.Add((addition.AddAfter, addition.PiplineComponent));
                }
            }

            if (nonLocatedComponents.Count > 0)
            {
                var locatedPerIteration = 0;
                do
                {
                    locatedPerIteration = 0;

                    foreach (var component in nonLocatedComponents)
                    {
                        var index = _components.FindIndex(c => c.ComponentId == component.AddAfter);
                        if (index >= 0)
                        {
                            _components.Insert(index + 1, component.Component);
                            nonLocatedComponents.Remove(component);
                            locatedPerIteration++;
                        }
                    }
                }
                while (nonLocatedComponents.Count > 0 && locatedPerIteration != 0);
            }
            
            // build pipline
            RequestDelegate middleware = context => Task.CompletedTask;

            for (var i = _components.Count - 1; i >= 0; i--)
            {
                middleware = _components[i].Behavior(middleware);
            }

#if DEBUG
            var components = _components;
            
            return new RequestPipline(middleware, components);
#else
            return new RequestPipline(middleware);
#endif
        }

        public IRequestPiplineBuilder Use(PiplineComponent component)
        {
            _components.Add(component);

            return this;
        }
    }
}
