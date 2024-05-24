using Newtonsoft.Json;

namespace EVEClient.NET.Models
{
    internal class OpenNewMailWindowBodyModel
    {
        public OpenNewMailWindowBodyModel(string body, string subject, int[] recipients, int? toCorpOrAllianceId, int? toMailingListId)
        {
            Body = body;
            Subject = subject;
            Recipients = recipients;
            ToCorpOrAllianceId = toCorpOrAllianceId;
            ToMailingListId = toMailingListId;
        }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("recipients")]
        public int[] Recipients { get; set; }

        [JsonProperty("to_corp_or_alliance_id")]
        public int? ToCorpOrAllianceId { get; set; }

        [JsonProperty("to_mailing_list_id")]
        public int? ToMailingListId { get; set; }

        public bool ShouldSerializeToCorpOrAllianceId()
        {
            return ToCorpOrAllianceId.HasValue;
        }

        public bool ShouldSerializeToMailingListId()
        {
            return ToMailingListId.HasValue;
        }
    }
}
