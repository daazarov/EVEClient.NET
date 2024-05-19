using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class JournalItem
    {
        /// <summary>
        /// The amount of ISK given or taken from the wallet as a result of the given transaction.
        /// Positive when ISK is deposited into the wallet and negative when ISK is withdrawn
        /// </summary>
        [JsonProperty("amount")]
        public double? Amount {  get; set; }

        /// <summary>
        /// Wallet balance after transaction occurred
        /// </summary>
        [JsonProperty("balance")]
        public double? Balance { get; set; }

        /// <summary>
        /// An ID that gives extra context to the particular transaction. Because of legacy reasons the context is completely different per ref_type and means different things.
        /// It is also possible to not have a context_id
        /// </summary>
        [JsonProperty("context_id")]
        public long? ContextId { get; set; }

        /// <summary>
        /// The type of the given context_id if present
        /// </summary>
        [JsonProperty("context_id_type")]
        public ContextIdType? ContextIdType { get; set; }

        /// <summary>
        /// Date and time of transaction
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The reason for the transaction, mirrors what is seen in the client
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The id of the first party involved in the transaction. This attribute has no consistency and is different or non existant for particular ref_types.
        /// The description attribute will help make sense of what this attribute means.
        /// For more info about the given ID it can be dropped into the /universe/names/ ESI route to determine its type and name
        /// </summary>
        [JsonProperty("first_party_id")]
        public int? FirstPartyId { get; set; }

        /// <summary>
        /// Unique journal reference ID
        /// </summary>
        [JsonProperty("id")]
        public long ID { get; set; }

        /// <summary>
        /// The user stated reason for the transaction. Only applies to some ref_types
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The transaction type for the given. transaction. Different transaction types will populate different attributes.
        /// </summary>
        [JsonProperty("ref_type")]
        public TransactionType RefType { get; set; }

        /// <summary>
        /// The id of the second party involved in the transaction. This attribute has no consistency and is different or non existant for particular ref_types.
        /// The description attribute will help make sense of what this attribute means.
        /// For more info about the given ID it can be dropped into the /universe/names/ ESI route to determine its type and name
        /// </summary>
        [JsonProperty("second_party_id")]
        public int? SecondPartyId { get; set; }

        /// <summary>
        /// Tax amount received. Only applies to tax related transactions
        /// </summary>
        [JsonProperty("tax")]
        public double? Tax { get; set; }

        /// <summary>
        /// The corporation ID receiving any tax paid. Only applies to tax related transactions
        /// </summary>
        [JsonProperty("tax_receiver_id")]
        public int? TaxReceiverId { get; set; }
    }
}
