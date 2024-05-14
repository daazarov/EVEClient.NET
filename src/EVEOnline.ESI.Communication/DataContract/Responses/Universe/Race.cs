using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Race
    {
        /// <summary>
        /// The alliance generally associated with this race
        /// </summary>
        [JsonProperty("alliance_id")]
        public int AllianceId {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public int RaceId { get; set; }
    }
}
