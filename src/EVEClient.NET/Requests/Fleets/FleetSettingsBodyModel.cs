using System.Text.Json.Serialization;

namespace EVEClient.NET.Requests
{
    internal class FleetSettingsBodyModel
    {
        [JsonPropertyName("is_free_move")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsFreeMove {  get; set; }

        [JsonPropertyName("motd")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Motd {  get; set; }
    }
}
