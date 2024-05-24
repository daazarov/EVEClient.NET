using Newtonsoft.Json;

namespace EVEClient.NET.Models
{
    internal class NewLabelBodyModel
    {
        public NewLabelBodyModel(string name, string color)
        {
            Color = color;
            Name = name;
        }

        [JsonProperty("color")]
        public string Color { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }
    }
}
