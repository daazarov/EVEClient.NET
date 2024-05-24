using System.Collections.Generic;

namespace EVEClient.NET.DataContract
{
    public class NewMail
    {
        public long? ApprovedCost { get; set; }
        public string Body { get; set; }
        public List<Recipient> Recipients { get; set; }
        public string Subject { get; set; }
    }
}
