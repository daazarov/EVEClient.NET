using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class KillmailInfoUriModel
    {
        public KillmailInfoUriModel(int killmailId, string killmailHash)
        {
            KillmailId = killmailId;
            KillmailHash = killmailHash;
        }

        [PathParameter("killmail_id")]
        public int KillmailId { get; set; }

        [PathParameter("killmail_hash")]
        public string KillmailHash { get; set; }
    }
}
