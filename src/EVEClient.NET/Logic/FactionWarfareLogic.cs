using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class FactionWarfareLogic : IFactionWarfareLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public FactionWarfareLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<Leaderboards<CharacterTotal>>> CaractersLeaderboard(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.FactionWarfare.CaractersLeaderboard, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Leaderboards<CharacterTotal>>();
        }

        public async Task<EsiResponse<CharacterStats>> CharacterStats(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Dogma.AttributeInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<CharacterStats>();
        }

        public async Task<EsiResponse<Leaderboards<CorporationTotal>>> CorporationsLeaderboard(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.FactionWarfare.CorporationsLeaderboard, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Leaderboards<CorporationTotal>>();
        }

        public async Task<EsiResponse<CorporationStats>> CorporationStats(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Dogma.AttributeInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<CorporationStats>();
        }

        public async Task<EsiResponse<Leaderboards<FactionTotal>>> FactionsLeaderboard(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.FactionWarfare.FactionsLeaderboard, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Leaderboards<FactionTotal>>();
        }

        public async Task<EsiResponse<FactionStats>> FactionsStats(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.FactionWarfare.FactionsStats, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<FactionStats>();
        }

        public async Task<EsiResponse<List<FactionWar>>> Wars(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.FactionWarfare.Wars, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<FactionWar>>();
        }

        public async Task<EsiResponse<List<FactionWarfareSystem>>> OwnershipSystemOverview(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.FactionWarfare.OwnershipSystemOverview, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<FactionWarfareSystem>>();
        }
    }
}
