using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Mining
    {
        /// <summary>
        /// date string
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date {  get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
