using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class FleetsLogic : IFleetsLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public FleetsLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<FleetInfo>> FleetInfo(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.FleetInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<FleetInfo>();
        }

        public async Task<EsiResponse<FleetSettings>> FleetSettings(long fleetId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.FleetSettings, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<FleetSettings>();
        }

        public async Task<EsiResponse> UpdateFleetSettings(long fleetId, bool? isFreeMove, string? motd, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Body = new FleetSettingsBodyModel { IsFreeMove = isFreeMove, Motd = motd };
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.UpdateFleetSettings, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse<List<FleetMember>>> FleetMembers(long fleetId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.FleetMembers, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<FleetMember>>();
        }

        public async Task<EsiResponse> InviteMember(long fleetId, int characterId, FleetRole role, long? squadId = null, long? wingId = null, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Body = new InviteFleetMemberBodyModel
                    {
                        CharacterId = characterId,
                        Role = role.ToEsiString(),
                        SquadId = squadId,
                        WingId = wingId
                    };
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.InviteMember, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> KickMember(long fleetId, int memberId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Route[ESI.Parameters.Route.MemberId] = memberId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.KickMember, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> MoveMember(long fleetId, int memberId, FleetRole role, long? squadId = null, long? wingId = null, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Route[ESI.Parameters.Route.MemberId] = memberId.ToString();
                    parameters.Body = new MoveFleetMemberBodyModel
                    {
                        Role = role.ToEsiString(),
                        SquadId = squadId,
                        WingId = wingId
                    };
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.MoveMember, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> DeleteSquad(long fleetId, long squadId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Route[ESI.Parameters.Route.SquadId] = squadId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.DeleteSquad, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> RenameSquad(long fleetId, long squadId, string name, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Route[ESI.Parameters.Route.SquadId] = squadId.ToString();
                    parameters.Body = new { name };
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.RenameSquad, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse<List<Wing>>> FleetWings(long fleetId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.FleetWings, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Wing>>();
        }

        public async Task<EsiResponse<NewWing>> NewWing(long fleetId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.NewWing, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<NewWing>();
        }

        public async Task<EsiResponse> DeleteWing(long fleetId, long wingId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Route[ESI.Parameters.Route.WingId] = wingId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.DeleteWing, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> RenameWing(long fleetId, long wingId, string name, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Route[ESI.Parameters.Route.WingId] = wingId.ToString();
                    parameters.Body = new { name };
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.RenameWing, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse<NewSquad>> NewSquad(long fleetId, long wingId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.FleetId] = fleetId.ToString();
                    parameters.Route[ESI.Parameters.Route.WingId] = wingId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fleets.NewSquad, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<NewSquad>();
        }

        private class FleetSettingsBodyModel
        {
            [JsonPropertyName("is_free_move")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? IsFreeMove { get; set; }

            [JsonPropertyName("motd")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Motd { get; set; }
        }

        private class InviteFleetMemberBodyModel
        {
            [JsonPropertyName("character_id")]
            public required int CharacterId { get; init; }

            [JsonPropertyName("role")]
            public required string Role { get; init; }

            [JsonPropertyName("squad_id")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public long? SquadId { get; init; }

            [JsonPropertyName("wing_id")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public long? WingId { get; init; }
        }

        private class MoveFleetMemberBodyModel
        {

            [JsonPropertyName("role")]
            public required string Role { get; set; }

            [JsonPropertyName("squad_id")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public long? SquadId { get; set; }

            [JsonPropertyName("wing_id")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public long? WingId { get; set; }
        }
    }
}
