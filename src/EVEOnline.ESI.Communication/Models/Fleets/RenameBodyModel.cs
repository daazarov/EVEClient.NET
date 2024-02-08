using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.Models
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
