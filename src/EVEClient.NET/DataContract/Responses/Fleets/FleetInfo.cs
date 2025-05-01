using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class FleetInfo
    {
        /// <summary>
        /// The character’s current fleet ID
        /// </summary>
        [JsonPropertyName("fleet_id")]
        public required long FleetId { get; init; }

        /// <summary>
        /// Member’s role in fleet
        /// </summary>
        [JsonPropertyName("role")]
        public required FleetRole Role { get; init; }

        /// <summary>
        /// ID of the squad the member is in. If not applicable, will be set to -
        /// </summary>
        [JsonPropertyName("squad_id")]
        public required long SquadId { get; init; }

        /// <summary>
        /// ID of the wing the member is in. If not applicable, will be set to -1
        /// </summary>
        [JsonPropertyName("wing_id")]
        public required long WingId { get; init; }
    }
}
