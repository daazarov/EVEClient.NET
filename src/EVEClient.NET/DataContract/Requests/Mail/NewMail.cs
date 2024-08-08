using Newtonsoft.Json;
using System.Collections.Generic;

namespace EVEClient.NET.DataContract
{
    public class NewMail
    {
        public long? ApprovedCost { get; set; }
        public required string Body { get; set; }
        public required List<Recipient> Recipients { get; set; }
        public required string Subject { get; set; }

        public class Recipient
        {
            public required int RecipientId { get; set; }
            public required RecipientType RecipientType { get; set; }
        }
    }
}
