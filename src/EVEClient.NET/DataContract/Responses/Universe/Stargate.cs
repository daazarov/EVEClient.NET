using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Stargate
    {
        /// <summary>
        /// destination object
        /// </summary>
        [JsonPropertyName("destination")]
        public required Destination Destination { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonPropertyName("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// stargate_id integer
        /// </summary>
        [JsonPropertyName("stargate_id")]
        public required int StargateId { get; init; }

        /// <summary>
        /// The solar system this stargate is in
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }

    public class Destination
    {
        /// <summary>
        /// The stargate this stargate connects to
        /// </summary>
        [JsonPropertyName("stargate_id")]
        public required int StargateId { get; init; }

        /// <summary>
        /// The solar system this stargate connects to
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }
    }
}
