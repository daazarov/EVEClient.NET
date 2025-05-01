using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class PublicContract
    {
        /// <summary>
        /// Buyout price (for Auctions only)
        /// </summary>
        [JsonPropertyName("buyout")]
        public double? Buyout { get; init; }

        /// <summary>
        /// Collateral price (for Couriers only)
        /// </summary>
        [JsonPropertyName("collateral")]
        public double? Collateral { get; init; }

        /// <summary>
        /// contract_id integer
        /// </summary>
        [JsonPropertyName("contract_id")]
        public required int ContractId { get; init; }

        /// <summary>
        /// Expiration date of the contract
        /// </summary>
        [JsonPropertyName("date_expired")]
        public required DateTime DateExpired { get; init; }

        /// <summary>
        /// Сreation date of the contract
        /// </summary>
        [JsonPropertyName("date_issued")]
        public required DateTime DateIssued { get; init; }

        /// <summary>
        /// Number of days to perform the contract
        /// </summary>
        [JsonPropertyName("days_to_complete")]
        public int? DaysToComplete { get; init; }

        /// <summary>
        /// End location ID (for Couriers contract)
        /// </summary>
        [JsonPropertyName("end_location_id")]
        public long? EndLocationId { get; init; }

        /// <summary>
        /// true if the contract was issued on behalf of the issuer’s corporation
        /// </summary>
        [JsonPropertyName("for_corporation")]
        public bool? ForCorporation { get; init; }

        /// <summary>
        /// Character’s corporation ID for the issuer
        /// </summary>
        [JsonPropertyName("issuer_corporation_id")]
        public required int IssuerCorporationId { get; init; }

        /// <summary>
        /// Character ID for the issuer
        /// </summary>
        [JsonPropertyName("issuer_id")]
        public required int IssuerId { get; init; }

        /// <summary>
        /// Price of contract (for ItemsExchange and Auctions)
        /// </summary>
        [JsonPropertyName("price")]
        public double? Price { get; init; }

        /// <summary>
        /// Remuneration for contract (for Couriers only)
        /// </summary>
        [JsonPropertyName("reward")]
        public double? Reward { get; init; }

        /// <summary>
        /// Start location ID (for Couriers contract)
        /// </summary>
        [JsonPropertyName("start_location_id")]
        public long? StartLocationId { get; init; }

        /// <summary>
        /// Title of the contract
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; init; }

        /// <summary>
        /// Type of the contract
        /// </summary>
        [JsonPropertyName("type")]
        public required ContractType Type { get; init; }

        /// <summary>
        /// Volume of items in the contract
        /// </summary>
        [JsonPropertyName("volume")]
        public double? Volume { get; init; }
    }
}
