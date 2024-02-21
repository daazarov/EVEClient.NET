﻿using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
