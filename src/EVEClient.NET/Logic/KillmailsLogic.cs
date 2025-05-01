using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class KillmailsLogic : IKillmailsLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public KillmailsLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponsePagination<List<Killmail>>> CharacterKillmails(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                   parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
               },
            token: token);

            var response = await _client.Request(ESI.Endpoints.Killmails.CharacterKillmails, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Killmail>>();
        }

        public async Task<EsiResponsePagination<List<Killmail>>> CorporationKillmails(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                   parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
               },
            token: token);

            var response = await _client.Request(ESI.Endpoints.Killmails.CorporationKillmails, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Killmail>>();
        }

        public async Task<EsiResponse<KillmailInfo>> KillmailInfo(int killmailId, string killmainHash, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.KillmailId] = killmailId.ToString();
                    parameters.Query[ESI.Parameters.Route.KillmainHash] = killmainHash;
                });

            var response = await _client.Request(ESI.Endpoints.Killmails.KillmailInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<KillmailInfo>();
        }
    }
}
