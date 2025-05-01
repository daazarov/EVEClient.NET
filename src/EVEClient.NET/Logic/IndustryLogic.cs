using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class IndustryLogic : IIndustryLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public IndustryLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<CharacterIndustryJob>>> CharacterJobs(int characterId, bool includeCompleted = false, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.IncludeCompleted] = includeCompleted.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Industry.CharacterJobs, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<CharacterIndustryJob>>();
        }

        public async Task<EsiResponsePagination<List<Mining>>> CharacterMiningLedger(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                   parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
               },
               token: token);

            var response = await _client.Request(ESI.Endpoints.Industry.CharacterMiningLedger, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Mining>>();
        }

        public async Task<EsiResponsePagination<List<Extraction>>> ExtractionTimers(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                   parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
               },
               token: token);

            var response = await _client.Request(ESI.Endpoints.Industry.ExtractionTimers, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Extraction>>();
        }

        public async Task<EsiResponsePagination<List<CorporationIndustryJob>>> CorporationJobs(int corporationId, bool includeCompleted = false, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                   parameters.Query[ESI.Parameters.Query.IncludeCompleted] = includeCompleted.ToString();
                   parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
               },
               token: token);

            var response = await _client.Request(ESI.Endpoints.Industry.CorporationJobs, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<CorporationIndustryJob>>();
        }

        public async Task<EsiResponsePagination<List<ObserverInfo>>> ObserverInfo(int corporationId, long observerId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                   parameters.Query[ESI.Parameters.Query.ObserverId] = observerId.ToString();
                   parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
               },
               token: token);

            var response = await _client.Request(ESI.Endpoints.Industry.ObserverInfo, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<ObserverInfo>>();
        }

        public async Task<EsiResponsePagination<List<Observer>>> CorporationObservers(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                   parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
               },
               token: token);

            var response = await _client.Request(ESI.Endpoints.Industry.CorporationObservers, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Observer>>();
        }

        public async Task<EsiResponse<List<IndustryFacility>>> Facilities(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Industry.Facilities, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<IndustryFacility>>();
        }

        public async Task<EsiResponse<List<SolarSystem>>> SolarSystems(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Industry.SolarSystems, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<SolarSystem>>();
        }
    }
}
