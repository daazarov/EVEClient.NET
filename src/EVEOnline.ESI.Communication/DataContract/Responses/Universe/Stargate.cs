using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Stargate
    {
        /// <summary>
        /// destination object
        /// </summary>
        [JsonProperty("destination")]
        public Destination Destination {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// stargate_id integer
        /// </summary>
        [JsonProperty("stargate_id")]
        public int StargateId { get; set; }

        /// <summary>
        /// The solar system this stargate is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }

    public class Destination
    {
        /// <summary>
        /// The stargate this stargate connects to
        /// </summary>
        [JsonProperty("stargate_id")]
        public int StargateId { get; set; }

        /// <summary>
        /// The solar system this stargate connects to
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }
    }
}
