using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class NewSquad
    {
        /// <summary>
        /// The squad_id of the newly created squad
        /// </summary>
        [JsonProperty("squad_id")]
        public required long SquadId { get; init; }
    }
}
