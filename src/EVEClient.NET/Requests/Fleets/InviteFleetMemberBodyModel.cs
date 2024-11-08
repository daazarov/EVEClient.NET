using System.Text.Json.Serialization;

namespace EVEClient.NET.Requests
{
    internal class InviteFleetMemberBodyModel
    {
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        [JsonPropertyName("role")]
        public required string Role { get; init; }

        [JsonPropertyName("squad_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? SquadId { get; init; }

        [JsonPropertyName("wing_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? WingId { get; init; }
    }
}
