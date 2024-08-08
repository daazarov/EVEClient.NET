using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class MemberTitle
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public required int CharacterId {  get; set; }

        /// <summary>
        /// A list of title_id
        /// </summary>
        [JsonProperty("titles")]
        public required int[] Titles { get; init; }
    }
}
