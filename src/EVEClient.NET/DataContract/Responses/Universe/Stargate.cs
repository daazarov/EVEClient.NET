using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Stargate
    {
        /// <summary>
        /// destination object
        /// </summary>
        [JsonProperty("destination")]
        public required Destination Destination {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// stargate_id integer
        /// </summary>
        [JsonProperty("stargate_id")]
        public required int StargateId { get; init; }

        /// <summary>
        /// The solar system this stargate is in
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }
    }

    public class Destination
    {
        /// <summary>
        /// The stargate this stargate connects to
        /// </summary>
        [JsonProperty("stargate_id")]
        public required int StargateId { get; init; }

        /// <summary>
        /// The solar system this stargate connects to
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }
    }
}
