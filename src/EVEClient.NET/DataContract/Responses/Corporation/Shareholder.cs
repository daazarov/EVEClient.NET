using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEClient.NET.DataContract
{
    public class Shareholder
    {
        /// <summary>
        /// share_count integer
        /// </summary>
        [JsonProperty("share_count")]
        public long ShareCount {  get; set; }

        /// <summary>
        /// shareholder_id integer
        /// </summary>
        [JsonProperty("shareholder_id")]
        public int ShareholderId { get; set; }

        /// <summary>
        /// shareholder_type string
        /// </summary>
        [JsonProperty("shareholder_type")]
        public ShareholderType ShareholderType { get; set; }
    }
}
