using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class CharacterTitle
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// title_id intege
        /// </summary>
        [JsonProperty("title_id")]
        public int? TitleId { get; set; }
    }
}
