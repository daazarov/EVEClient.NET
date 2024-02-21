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

        [PathParameter("character_id")]
        public int CharacterId { get; private set; }

        [PathParameter("mail_id")]
        public int MailId { get; private set; }
    }
}
