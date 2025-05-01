using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Divisions
    {
        /// <summary>
        /// hangar array
        /// </summary>
        [JsonPropertyName("hangar")]
        public List<Division>? Hangar { get; init; }

        /// <summary>
        /// wallet array
        /// </summary>
        [JsonPropertyName("wallet")]
        public List<Division>? Wallet { get; init; }
    }

    public class Division
    {
        /// <summary>
        /// division integer
        /// </summary>
        [JsonPropertyName("division")]
        public int? DivisionId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }
    }
}
