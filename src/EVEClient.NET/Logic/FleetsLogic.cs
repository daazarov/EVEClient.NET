using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.FleetsRequests;

namespace EVEClient.NET.Logic
{
    internal class FleetsLogic : IFleetsLogic
    {
        private readonly IEsiHttpClient<IFleetsLogic> _esiClient;

        public FleetsLogic(IEsiHttpClient<IFleetsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<FleetInfo>> FleetInfo(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, FleetInfo>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<FleetSettings>> FleetSettings(long fleetId, string? token = null) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, FleetSettings>(FleetIdRouteRequest.Create(fleetId), token);

        public Task<EsiResponse> UpdateFleetSettings(long fleetId, bool? isFreeMove, string? motd, string? token = null) =>
            _esiClient.PutRequestAsync(UpdateFleetSettingsRequest.Create(fleetId, isFreeMove, motd), token);

        public Task<EsiResponse<List<FleetMember>>> FleetMembers(long fleetId, string? token = null) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, List<FleetMember>>(FleetIdRouteRequest.Create(fleetId), token);

        public Task<EsiResponse> InviteMember(long fleetId, int characterId, FleetRole role, long? squadId = null, long? wingId = null, string? token = null) =>
            _esiClient.PostNoContentRequestAsync(InviteFleetMemberRequest.Create(fleetId, characterId, role.ToEsiString(), squadId, wingId), token);

        public Task<EsiResponse> KickMember(long fleetId, int memberId, string? token = null) =>
            _esiClient.DeleteRequestAsync(FleetMemberRouteRequest.Create(fleetId, memberId), token);

        public Task<EsiResponse> MoveMember(long fleetId, int memberId, FleetRole role, long? squadId = null, long? wingId = null, string? token = null) =>
            _esiClient.PutRequestAsync(MoveFleetMemberRequest.Create(fleetId, memberId, role.ToEsiString(), squadId, wingId), token);

        public Task<EsiResponse> DeleteSquad(long fleetId, long squadId, string? token = null) =>
            _esiClient.DeleteRequestAsync(FleetSquadRouteRequest.Create(fleetId, squadId), token);

        public Task<EsiResponse> RenameSquad(long fleetId, long squadId, string name, string? token = null) =>
            _esiClient.PutRequestAsync(RenameSquadRequest.Create(fleetId, squadId, name), token);

        public Task<EsiResponse<List<Wing>>> FleetWings(long fleetId, string? token = null) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, List<Wing>>(FleetIdRouteRequest.Create(fleetId), token);

        public Task<EsiResponse<NewWing>> NewWing(long fleetId, string? token = null) =>
            _esiClient.PostRequestAsync<FleetIdRouteRequest, NewWing>(FleetIdRouteRequest.Create(fleetId), token);

        public Task<EsiResponse> DeleteWing(long fleetId, long wingId, string? token = null) =>
            _esiClient.DeleteRequestAsync(FleetWingRouteRequest.Create(fleetId, wingId), token);

        public Task<EsiResponse> RenameWing(long fleetId, long wingId, string name, string? token = null) =>
            _esiClient.PutRequestAsync(RenameWingRequest.Create(fleetId, wingId, name), token);

        public Task<EsiResponse<NewSquad>> NewSquad(long fleetId, long wingId, string? token = null) =>
            _esiClient.PostRequestAsync<FleetWingRouteRequest, NewSquad>(FleetWingRouteRequest.Create(fleetId, wingId), token);
    }
}
