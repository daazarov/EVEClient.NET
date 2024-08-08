using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class MailingList
    {
        /// <summary>
        /// Mailing list ID
        /// </summary>
        [JsonProperty("mailing_list_id")]
        public required int MailingListId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }
    }
}
