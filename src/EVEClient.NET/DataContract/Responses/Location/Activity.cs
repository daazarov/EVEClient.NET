using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Activity
    {
        /// <summary>
        /// Timestamp of the last login
        /// </summary>
        [JsonProperty("last_login")]
        public DateTime? LastLogin { get; init; }

        /// <summary>
        /// Timestamp of the last logout
        /// </summary>
        [JsonProperty("last_logout")]
        public DateTime? LastLogout { get; init; }

        /// <summary>
        /// Total number of times the character has logged in
        /// </summary>
        [JsonProperty("logins")]
        public int? Logins { get; init; }

        /// <summary>
        /// If the character is online
        /// </summary>
        [JsonProperty("online")]
        public bool Online { get; init; }
    }
}
