using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET
{
    internal class CorporationLogic : ICorporationLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public CorporationLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<CorporationInfo>> Information(int corporationId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Corporation.Information, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<CorporationInfo>();
        }

        public async Task<EsiResponse<List<AllianceHistory>>> AllianceHistory(int corporationId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Corporation.AllianceHistory, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<AllianceHistory>>();
        }

        public async Task<EsiResponsePagination<List<Blueprint>>> Blueprints(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Blueprints, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Blueprint>>();
        }

        public async Task<EsiResponsePagination<List<ContainerLog>>> ContainersLogs(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.ContainersLogs, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<ContainerLog>>();
        }

        public async Task<EsiResponse<Divisions>> Divisions(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Divisions, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Divisions>();
        }

        public async Task<EsiResponse<List<Facility>>> Facilities(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Facilities, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Facility>>();
        }

        public async Task<EsiResponse<CorporationIcon>> Icons(int corporationId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Corporation.Icons, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<CorporationIcon>();
        }

        public async Task<EsiResponsePagination<List<CorporationMedal>>> Medals(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Medals, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<CorporationMedal>>();
        }

        public async Task<EsiResponsePagination<List<CorporationIssuedMedal>>> IssuedMedals(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.IssuedMedals, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<CorporationIssuedMedal>>();
        }

        public async Task<EsiResponse<List<int>>> Members(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Members, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<int>> MembersLimit(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.MembersLimit, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<int>();
        }

        public async Task<EsiResponse<List<MemberTitle>>> MembersTitles(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.MembersTitles, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<MemberTitle>>();
        }

        public async Task<EsiResponse<List<MemberTracking>>> MemberTracking(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.MemberTracking, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<MemberTracking>>();
        }

        public async Task<EsiResponse<List<MemberRole>>> Roles(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Roles, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<MemberRole>>();
        }

        public async Task<EsiResponsePagination<List<MemberRoleHistory>>> RolesHistory(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.RolesHistory, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<MemberRoleHistory>>();
        }

        public async Task<EsiResponsePagination<List<Shareholder>>> Shareholders(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Shareholders, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Shareholder>>();
        }

        public async Task<EsiResponsePagination<List<CorporationStanding>>> Standings(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Standings, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<CorporationStanding>>();
        }

        public async Task<EsiResponsePagination<List<Starbase>>> Starbases(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Starbases, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Starbase>>();
        }

        public async Task<EsiResponse<StarbaseInfo>> StarbaseInfo(int corporationId, long starbaseId, int systemId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Route[ESI.Parameters.Route.StarbaseId] = starbaseId.ToString();
                    parameters.Query[ESI.Parameters.Query.SystemId] = systemId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.StarbaseInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<StarbaseInfo>();
        }

        public async Task<EsiResponsePagination<List<Structure>>> Structures(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Structures, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Structure>>();
        }

        public async Task<EsiResponse<List<Title>>> Titles(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Corporation.Titles, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Title>>();
        }

        public async Task<EsiResponse<List<int>>> NpcCorporations(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Corporation.NpcCorporations, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }
    }
}
