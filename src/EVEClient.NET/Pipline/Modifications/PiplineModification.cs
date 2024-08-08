using System.Collections.Generic;

namespace EVEClient.NET.Pipline.Modifications
{
    internal class PiplineModification
    {
        public PiplineModification(string endpointid)
        {
            EndpointId = endpointid;
        }

        public string EndpointId { get; }
        public List<ReplaceComponent> Replacements { get; } = new();
        public List<AdditionalComponent> Additions { get; } = new();
    }
}
