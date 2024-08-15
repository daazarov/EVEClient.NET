using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Contract
    {
        /// <summary>
        /// Who will accept the contract
        /// </summary>
        [JsonProperty("acceptor_id")]
        public required int AcceptorId { get; init; }

        /// <summary>
        /// ID to whom the contract is assigned, can be alliance, corporation or character ID
        /// </summary>
        [JsonProperty("assignee_id")]
        public required int AssigneeId { get; init; }

        /// <summary>
        /// To whom the contract is available
        /// </summary>
        [JsonProperty("availability")]
        public required ContractAvailability Availability { get; init; }

        /// <summary>
        /// Buyout price (for Auctions only)
        /// </summary>
        [JsonProperty("buyout")]
        public double? Buyout { get; init; }

        /// <summary>
        /// Collateral price (for Couriers only)
        /// </summary>
        [JsonProperty("collateral")]
        public double? Collateral { get; init; }

        /// <summary>
        /// contract_id integer
        /// </summary>
        [JsonProperty("contract_id")]
        public required int ContractId { get; init; }

        /// <summary>
        /// Date of confirmation of contract
        /// </summary>
        [JsonProperty("date_accepted")]
        public DateTime? DateAccepted { get; init; }

        /// <summary>
        /// Date of completed of contract
        /// </summary>
        [JsonProperty("date_completed")]
        public DateTime? DateCompleted { get; init; }

        /// <summary>
        /// Expiration date of the contract
        /// </summary>
        [JsonProperty("date_expired")]
        public required DateTime DateExpired { get; init; }

        /// <summary>
        /// Сreation date of the contract
        /// </summary>
        [JsonProperty("date_issued")]
        public required DateTime DateIssued { get; init; }

        /// <summary>
        /// Number of days to perform the contract
        /// </summary>
        [JsonProperty("days_to_complete")]
        public int? DaysToComplete { get; init; }

        /// <summary>
        /// End location ID (for Couriers contract)
        /// </summary>
        [JsonProperty("end_location_id")]
        public long? EndLocationId { get; init; }

        /// <summary>
        /// true if the contract was issued on behalf of the issuer’s corporation
        /// </summary>
        [JsonProperty("for_corporation")]
        public required bool ForCorporation { get; init; }

        /// <summary>
        /// Character’s corporation ID for the issuer
        /// </summary>
        [JsonProperty("issuer_corporation_id")]
        public required int IssuerCorporationId { get; init; }

        /// <summary>
        /// Character ID for the issuer
        /// </summary>
        [JsonProperty("issuer_id")]
        public required int IssuerId { get; init; }

        /// <summary>
        /// Price of contract (for ItemsExchange and Auctions)
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; init; }

        /// <summary>
        /// Remuneration for contract (for Couriers only)
        /// </summary>
        [JsonProperty("reward")]
        public double? Reward { get; init; }

        /// <summary>
        /// Start location ID (for Couriers contract)
        /// </summary>
        [JsonProperty("start_location_id")]
        public long? StartLocationId { get; init; }

        /// <summary>
        /// Status of the the contract
        /// </summary>
        [JsonProperty("status")]
        public required ContactStatus Status { get; init; }

        /// <summary>
        /// Title of the contract
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; init; }

        /// <summary>
        /// Type of the contract
        /// </summary>
        [JsonProperty("type")]
        public required ContractType Type { get; init; }

        /// <summary>
        /// Volume of items in the contract
        /// </summary>
        [JsonProperty("volume")]
        public double? Volume { get; init; }
    }
}
