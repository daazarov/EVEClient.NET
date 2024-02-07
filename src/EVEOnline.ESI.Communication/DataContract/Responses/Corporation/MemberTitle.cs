using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class MemberTitle
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId {  get; set; }

        /// <summary>
        /// A list of title_id
        /// </summary>
        [JsonProperty("titles")]
        public int[] Titles { get; set; }
    }
}
