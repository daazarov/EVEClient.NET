using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    public class GetDeleteUpdateMailUriModel
    {
        public GetDeleteUpdateMailUriModel(int characterId, int mailId)
        {
            CharacterId = characterId;
            MailId = mailId;
        }

        [RouteParameter("character_id")]
        public int CharacterId { get; private set; }

        [RouteParameter("mail_id")]
        public int MailId { get; private set; }
    }
}
