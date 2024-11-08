using System.Text.Json.Serialization;

namespace EVEClient.NET.Requests
{
    internal class MoveFleetMemberBodyModel
    {

        [JsonPropertyName("role")]
        public required string Role {  get; set; }

        [JsonPropertyName("squad_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? SquadId { get; set; }

        [JsonPropertyName("wing_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? WingId { get; set; }
    }
}
