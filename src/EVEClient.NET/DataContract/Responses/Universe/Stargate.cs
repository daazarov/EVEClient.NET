using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Stargate
    {
        /// <summary>
        /// destination object
        /// </summary>
        [JsonProperty("destination")]
        public Destination Destination { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; init; }

        /// <summary>
        /// stargate_id integer
        /// </summary>
        [JsonProperty("stargate_id")]
        public int StargateId { get; init; }

        /// <summary>
        /// The solar system this stargate is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }

    public class Destination
    {
        /// <summary>
        /// The stargate this stargate connects to
        /// </summary>
        [JsonProperty("stargate_id")]
        public int StargateId { get; init; }

        /// <summary>
        /// The solar system this stargate connects to
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; init; }
    }
}
