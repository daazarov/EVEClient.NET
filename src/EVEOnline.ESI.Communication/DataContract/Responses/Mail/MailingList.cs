using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class MailingList
    {
        /// <summary>
        /// Mailing list ID
        /// </summary>
        [JsonProperty("mailing_list_id")]
        public int MailingListId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
