using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Activity
    {
        /// <summary>
        /// Timestamp of the last login
        /// </summary>
        [JsonPropertyName("last_login")]
        public DateTime? LastLogin { get; init; }

        /// <summary>
        /// Timestamp of the last logout
        /// </summary>
        [JsonPropertyName("last_logout")]
        public DateTime? LastLogout { get; init; }

        /// <summary>
        /// Total number of times the character has logged in
        /// </summary>
        [JsonPropertyName("logins")]
        public int? Logins { get; init; }

        /// <summary>
        /// If the character is online
        /// </summary>
        [JsonPropertyName("online")]
        public required bool Online { get; init; }
    }
}
