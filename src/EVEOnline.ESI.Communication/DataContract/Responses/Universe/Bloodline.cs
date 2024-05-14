using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Bloodline
    {
        /// <summary>
        /// bloodline_id integer
        /// </summary>
        [JsonProperty("bloodline_id")]
        public int BloodlineId {  get; set; }

        /// <summary>
        /// charisma integer
        /// </summary>
        [JsonProperty("charisma")]
        public int Charisma {  get; set; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int CorporationId { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// intelligence integer
        /// </summary>
        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        /// <summary>
        /// memory integer
        /// </summary>
        [JsonProperty("memory")]
        public int Memory {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// perception integer
        /// </summary>
        [JsonProperty("perception")]
        public int Perception { get; set; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public int RaceId { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public int ShipTypeId { get; set; }

        /// <summary>
        /// willpower integer
        /// </summary>
        [JsonProperty("willpower")]
        public int Willpower { get; set; }
    }
}
