using System.Linq;
using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class MailHeadersUriModel
    {
        public MailHeadersUriModel(int characterId, int[] labels, int? lastMailId)
        { 
            CharacterId = characterId;
            LastMailId = lastMailId;

            if (labels?.Count() > 0)
            {
                Labels = string.Join(",", labels);
            }
        }

        [PathParameter("character_id")]
        public int CharacterId { get; private set; }

        [QueryParameter("labels")]
        public string Labels { get; private set; }

        [QueryParameter("last_mail_id")]
        public int? LastMailId { get; private set; }
    }
}
