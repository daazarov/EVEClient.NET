using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class AllianceIcon
    {
        /// <summary>
        /// px128x128 string
        /// </summary>
        [JsonProperty("creator_corporation_id")]
        public string px128x128 { get; set; }

        /// <summary>
        /// px64x64 string
        /// </summary>
        [JsonProperty("creator_corporation_id")]
        public string px64x64 { get; set; }
    }
}
