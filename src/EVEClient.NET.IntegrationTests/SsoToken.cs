using Newtonsoft.Json;

namespace EVEClient.NET.IntegrationTests
{
    internal class SsoToken
    {
        public SsoToken()
        {
            IssuedAt = DateTime.UtcNow;
        }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        public DateTime IssuedAt { get; set; }

        public TimeSpan ExpiresInTimeSpan => TimeSpan.FromSeconds(ExpiresIn);
    }
}
