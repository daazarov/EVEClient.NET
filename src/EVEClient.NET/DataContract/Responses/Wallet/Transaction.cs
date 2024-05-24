using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Transaction
    {
        /// <summary>
        /// client_id integer
        /// </summary>
        [JsonProperty("client_id")]
        public int ClientId { get; set; }

        /// <summary>
        /// Date and time of transaction
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// is_buy boolean
        /// </summary>
        [JsonProperty("is_buy")]
        public bool IsBuy { get; set; }

        /// <summary>
        /// is_personal boolean
        /// </summary>
        [JsonProperty("is_personal")]
        public bool? IsPersonal { get; set; }

        /// <summary>
        /// journal_ref_id integer
        /// </summary>
        [JsonProperty("journal_ref_id")]
        public long JournalRefId { get; set; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Unique transaction ID
        /// </summary>
        [JsonProperty("transaction_id")]
        public long TransactionId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// Amount paid per unit
        /// </summary>
        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }
}
