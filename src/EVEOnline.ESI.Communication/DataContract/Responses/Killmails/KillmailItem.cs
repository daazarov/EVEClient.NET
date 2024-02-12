using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class KillmailItem
    {
        /// <summary>
        /// Flag for the location of the item
        /// </summary>
        [JsonProperty("flag")]
        public int Flag {  get; set; }

        /// <summary>
        /// item_type_id integer
        /// </summary>
        [JsonProperty("item_type_id")]
        public int ItemTypeId { get; set; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items")]
        public List<KillmailItem> Items { get; set; }

        /// <summary>
        /// How many of the item were destroyed if any
        /// </summary>
        [JsonProperty("quantity_destroyed")]
        public long? QuantityDestroyed { get; set; }

        /// <summary>
        /// How many of the item were dropped if any
        /// </summary>
        [JsonProperty("quantity_dropped")]
        public long? QuantityDropped { get; set; }

        /// <summary>
        /// singleton integer
        /// </summary>
        [JsonProperty("singleton")]
        public int Singleton {  get; set; }
    }
}
