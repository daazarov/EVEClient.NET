using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Transaction
    {
        /// <summary>
        /// client_id integer
        /// </summary>
        [JsonPropertyName("client_id")]
        public required int ClientId { get; init; }

        /// <summary>
        /// Date and time of transaction
        /// </summary>
        [JsonPropertyName("date")]
        public required DateTime Date { get; init; }

        /// <summary>
        /// is_buy boolean
        /// </summary>
        [JsonPropertyName("is_buy")]
        public required bool IsBuy { get; init; }

        /// <summary>
        /// is_personal boolean
        /// </summary>
        [JsonPropertyName("is_personal")]
        public bool? IsPersonal { get; init; }

        /// <summary>
        /// journal_ref_id integer
        /// </summary>
        [JsonPropertyName("journal_ref_id")]
        public required long JournalRefId { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonPropertyName("location_id")]
        public required long LocationId { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonPropertyName("quantity")]
        public required int Quantity { get; init; }

        /// <summary>
        /// Unique transaction ID
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public required long TransactionId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// Amount paid per unit
        /// </summary>
        [JsonPropertyName("unit_price")]
        public required double UnitPrice { get; init; }
    }
}
