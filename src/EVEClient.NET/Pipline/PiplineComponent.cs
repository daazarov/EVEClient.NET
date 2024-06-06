using System;
using System.Threading.Tasks;

using EVEClient.NET.Extensions;

namespace EVEClient.NET.Pipline
{
    public class PiplineComponent
    {
        public Func<RequestDelegate, RequestDelegate> Behavior { get; }
        public string ComponentId { get; }

        public PiplineComponent(string componentId, Func<RequestDelegate, RequestDelegate> behavior)
        {
            componentId.ArgumentStringNotNullOrEmpty(nameof(componentId));
            behavior.ArgumentNotNull(nameof(behavior));
            
            ComponentId = componentId;
            Behavior = behavior;
        }
    }

    public delegate Task RequestDelegate(EsiContext context);
}
