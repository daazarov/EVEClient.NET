using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;

namespace EVEOnline.ESI.Communication.Models
{
    internal class NewMailBodyModel
    {
        [JsonProperty("approved_cost")]
        public long? ApprovedCost { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("recipients")]
        public List<RecipientBodyModel> Recipients { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        public bool ShouldSerializeApprovedCost()
        {
            return ApprovedCost.HasValue;
        }

        public static NewMailBodyModel FromDataContractModel(NewMail mail)
        {
            return new NewMailBodyModel
            {
                ApprovedCost = mail.ApprovedCost,
                Body = mail.Body,
                Subject = mail.Subject,
                Recipients = mail.Recipients.Select(x => RecipientBodyModel.FromDataContractModel(x)).ToList()
            };
        }
    }

    internal class RecipientBodyModel
    {
        /// <summary>
        /// recipient_id integer
        /// </summary>
        [JsonProperty("recipient_id")]
        public int RecipientId { get; set; }

        /// <summary>
        /// recipient_type string
        /// </summary>
        [JsonProperty("recipient_type")]
        public string RecipientType { get; set; }

        public static RecipientBodyModel FromDataContractModel(Recipient recipient)
        {
            return new RecipientBodyModel
            {
                RecipientId = recipient.RecipientId,
                RecipientType = recipient.RecipientType.ToEsiString()
            };
        }
    }
}
