using System.Net;
using System.Text;

using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.IntegrationTests.Fakes
{
    internal class AccessTokenProviderFake : IAccessTokenProvider
    {
        private readonly HttpClient _client;
        
        private string initialRefreshToken;
        private string clientId;

        private static SsoToken token;

        private const string SsoUrl = "login.eveonline.com";
        

        public AccessTokenProviderFake(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient();

            initialRefreshToken = Environment.GetEnvironmentVariable("ESI_REFRESH_TOKEN")!;
            clientId = Environment.GetEnvironmentVariable("ESI_CLIENT_ID")!;
        }

        public async Task<string> GetAccessToken()
        {
            if (token != null)
            {
                var expired = (token.IssuedAt + token.ExpiresInTimeSpan) >= (DateTime.UtcNow - TimeSpan.FromMinutes(5));

                if (expired)
                {
                    token = await RefreshAccessToken(token.RefreshToken);
                }
            }
            else
            {
                token = await RefreshAccessToken(initialRefreshToken);
            }

            return token.AccessToken;
        }

        private async Task<SsoToken> RefreshAccessToken(string refreshToken)
        {
            var body = $"grant_type=refresh_token&refresh_token={Uri.EscapeDataString(refreshToken)}&client_id={clientId}";

            var request = new HttpRequestMessage(HttpMethod.Post, $"https://{SsoUrl}/v2/oauth/token")
            {
                Content = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded"),
            };

            request.Headers.Host = SsoUrl;

            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            try
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ArgumentException(content);
                }

                token = JsonConvert.DeserializeObject<SsoToken>(content)!;

                return token;
            }
            catch
            {
                throw;
            }
        }
    }
}
