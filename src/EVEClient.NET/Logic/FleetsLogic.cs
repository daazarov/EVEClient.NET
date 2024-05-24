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

        public Task<EsiResponse<FleetInfo>> FleetInfo(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, FleetInfo>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<FleetSettings>> FleetSettings(long fleetId) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, FleetSettings>(FleetIdRouteRequest.Create(fleetId));

        public Task<EsiResponse> UpdateFleetSettings(long fleetId, bool? isFreeMove, string motd) =>
            _esiClient.PutRequestAsync<UpdateFleetSettingsRequest>(UpdateFleetSettingsRequest.Create(fleetId, isFreeMove, motd));

        public Task<EsiResponse<List<FleetMember>>> FleetMembers(long fleetId) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, List<FleetMember>>(FleetIdRouteRequest.Create(fleetId));

        public Task<EsiResponse> InviteMember(long fleetId, int characterId, FleetRole role, long? squadId = null, long? wingId = null) =>
            _esiClient.PostNoContentRequestAsync(InviteFleetMemberRequest.Create(fleetId, characterId, role.ToEsiString(), squadId, wingId));

        public Task<EsiResponse> KickMember(long fleetId, int memberId) =>
            _esiClient.DeleteRequestAsync<FleetMemberRouteRequest>(FleetMemberRouteRequest.Create(fleetId, memberId));

        public Task<EsiResponse> MoveMember(long fleetId, int memberId, FleetRole role, long? squadId = null, long? wingId = null) =>
            _esiClient.PutRequestAsync<MoveFleetMemberRequest>(MoveFleetMemberRequest.Create(fleetId, memberId, role.ToEsiString(), squadId, wingId));

        public Task<EsiResponse> DeleteSquad(long fleetId, long squadId) =>
            _esiClient.DeleteRequestAsync<FleetSquadRouteRequest>(FleetSquadRouteRequest.Create(fleetId, squadId));

        public Task<EsiResponse> RenameSquad(long fleetId, long squadId, string name) =>
            _esiClient.PutRequestAsync<RenameSquadRequest>(RenameSquadRequest.Create(fleetId, squadId, name));

        public Task<EsiResponse<List<Wing>>> FleetWings(long fleetId) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, List<Wing>>(FleetIdRouteRequest.Create(fleetId));

        public Task<EsiResponse<NewWing>> NewWing(long fleetId) =>
            _esiClient.PostRequestAsync<FleetIdRouteRequest, NewWing>(FleetIdRouteRequest.Create(fleetId));

        public Task<EsiResponse> DeleteWing(long fleetId, long wingId) =>
            _esiClient.DeleteRequestAsync<FleetWingRouteRequest>(FleetWingRouteRequest.Create(fleetId, wingId));

        public Task<EsiResponse> RenameWing(long fleetId, long wingId, string name) =>
            _esiClient.PutRequestAsync<RenameWingRequest>(RenameWingRequest.Create(fleetId, wingId, name));

        public Task<EsiResponse<NewSquad>> NewSquad(long fleetId, long wingId) =>
            _esiClient.PostRequestAsync<FleetWingRouteRequest, NewSquad>(FleetWingRouteRequest.Create(fleetId, wingId));
    }
}
