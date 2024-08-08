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
        public required int ClientId { get; init; }

        /// <summary>
        /// Date and time of transaction
        /// </summary>
        [JsonProperty("date")]
        public required DateTime Date { get; init; }

        /// <summary>
        /// is_buy boolean
        /// </summary>
        [JsonProperty("is_buy")]
        public required bool IsBuy { get; init; }

        /// <summary>
        /// is_personal boolean
        /// </summary>
        [JsonProperty("is_personal")]
        public bool? IsPersonal { get; init; }

        /// <summary>
        /// journal_ref_id integer
        /// </summary>
        [JsonProperty("journal_ref_id")]
        public required long JournalRefId { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public required long LocationId { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public required int Quantity { get; init; }

        /// <summary>
        /// Unique transaction ID
        /// </summary>
        [JsonProperty("transaction_id")]
        public required long TransactionId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// Amount paid per unit
        /// </summary>
        [JsonProperty("unit_price")]
        public required double UnitPrice { get; init; }
    }
}
