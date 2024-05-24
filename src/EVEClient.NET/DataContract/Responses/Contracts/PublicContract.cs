using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class PublicContract
    {
        /// <summary>
        /// Buyout price (for Auctions only)
        /// </summary>
        [JsonProperty("buyout")]
        public double? Buyout { get; set; }

        /// <summary>
        /// Collateral price (for Couriers only)
        /// </summary>
        [JsonProperty("collateral")]
        public double? Collateral { get; set; }

        /// <summary>
        /// contract_id integer
        /// </summary>
        [JsonProperty("contract_id")]
        public int ContractId { get; set; }

        /// <summary>
        /// Expiration date of the contract
        /// </summary>
        [JsonProperty("date_expired")]
        public DateTime DateExpired { get; set; }

        /// <summary>
        /// Сreation date of the contract
        /// </summary>
        [JsonProperty("date_issued")]
        public DateTime DateIssued { get; set; }

        /// <summary>
        /// Number of days to perform the contract
        /// </summary>
        [JsonProperty("days_to_complete")]
        public int? DaysToComplete { get; set; }

        /// <summary>
        /// End location ID (for Couriers contract)
        /// </summary>
        [JsonProperty("end_location_id")]
        public long? EndLocationId { get; set; }

        /// <summary>
        /// true if the contract was issued on behalf of the issuer’s corporation
        /// </summary>
        [JsonProperty("for_corporation")]
        public bool? ForCorporation { get; set; }

        /// <summary>
        /// Character’s corporation ID for the issuer
        /// </summary>
        [JsonProperty("issuer_corporation_id")]
        public int IssuerCorporationId { get; set; }

        /// <summary>
        /// Character ID for the issuer
        /// </summary>
        [JsonProperty("issuer_id")]
        public int IssuerId { get; set; }

        /// <summary>
        /// Price of contract (for ItemsExchange and Auctions)
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Remuneration for contract (for Couriers only)
        /// </summary>
        [JsonProperty("reward")]
        public double? Reward { get; set; }

        /// <summary>
        /// Start location ID (for Couriers contract)
        /// </summary>
        [JsonProperty("start_location_id")]
        public long? StartLocationId { get; set; }

        /// <summary>
        /// Title of the contract
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Type of the contract
        /// </summary>
        [JsonProperty("type")]
        public ContractType Type { get; set; }

        /// <summary>
        /// Volume of items in the contract
        /// </summary>
        [JsonProperty("volume")]
        public double? Volume { get; set; }
    }
}
