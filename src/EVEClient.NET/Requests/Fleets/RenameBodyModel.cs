using Newtonsoft.Json;

namespace EVEClient.NET.Models
{
    internal class RenameBodyModel
    {
        public RenameBodyModel(string name)
        { 
            Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
