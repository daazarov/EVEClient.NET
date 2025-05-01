using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class NewSquad
    {
        /// <summary>
        /// The squad_id of the newly created squad
        /// </summary>
        [JsonPropertyName("squad_id")]
        public required long SquadId { get; init; }
    }
}
