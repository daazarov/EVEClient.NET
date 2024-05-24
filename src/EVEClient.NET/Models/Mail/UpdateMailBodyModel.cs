using Newtonsoft.Json;
using System.Linq;

namespace EVEClient.NET.Models
{
    internal class UpdateMailBodyModel
    {
        public UpdateMailBodyModel(int[] labels, bool? read)
        {
            Labels = labels;
            Read = read;
        }

        [JsonProperty("labels")]
        public int[] Labels { get; private set; }

        [JsonProperty("read")]
        public bool? Read {  get; private set; }

        public bool ShouldSerializeLabels()
        {
            return Labels?.Count() > 0;
        }

        public bool ShouldSerializeRead()
        {
            return Read.HasValue;
        }
    }
}
