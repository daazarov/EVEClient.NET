using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class War
    {
        /// <summary>
        /// The faction ID of the enemy faction.
        /// </summary>
        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("against_id")]
        public int AgainstId { get; set; }
    }
}
