using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;

using static EVEOnline.ESI.Communication.Models.FleetsRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class FleetsLogic : IFleetsLogic
    {
        private readonly IEsiHttpClient<IFleetsLogic> _esiClient;

        public FleetsLogic(IEsiHttpClient<IFleetsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<FleetInfo>> GetCharacterFleetAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, FleetInfo>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<FleetSettings>> GetFleetSettingsAsync(long fleetId) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, FleetSettings>(FleetIdRouteRequest.Create(fleetId));

        public Task<EsiResponse> UpdateFleetSettingsAsync(long fleetId, bool? isFreeMove, string motd) =>
            _esiClient.PutRequestAsync<UpdateFleetSettingsRequest>(UpdateFleetSettingsRequest.Create(fleetId, isFreeMove, motd));

        public Task<EsiResponse<List<FleetMember>>> GetFleetMembersAsync(long fleetId) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, List<FleetMember>>(FleetIdRouteRequest.Create(fleetId));

        public Task<EsiResponse> InviteMemberAsync(long fleetId, int characterId, FleetRole role, long? squadId = null, long? wingId = null) =>
            _esiClient.PostNoContentRequestAsync<InviteFleetMemberRequest>(InviteFleetMemberRequest.Create(fleetId, characterId, role.GetEnumMemberAttributeValue(), squadId, wingId));

        public Task<EsiResponse> KickMemberAsync(long fleetId, int memberId) =>
            _esiClient.DeleteRequestAsync<FleetMemberRouteRequest>(FleetMemberRouteRequest.Create(fleetId, memberId));

        public Task<EsiResponse> MoveMemberAsync(long fleetId, int memberId, FleetRole role, long? squadId = null, long? wingId = null) =>
            _esiClient.PutRequestAsync<MoveFleetMemberRequest>(MoveFleetMemberRequest.Create(fleetId, memberId, role.GetEnumMemberAttributeValue(), squadId, wingId));

        public Task<EsiResponse> DeleteSquadAsync(long fleetId, long squadId) =>
            _esiClient.DeleteRequestAsync<FleetSquadRouteRequest>(FleetSquadRouteRequest.Create(fleetId, squadId));

        public Task<EsiResponse> RenameSquadAsync(long fleetId, long squadId, string name) =>
            _esiClient.PutRequestAsync<RenameSquadRequest>(RenameSquadRequest.Create(fleetId, squadId, name));

        public Task<EsiResponse<List<Wing>>> GetFleetWingsAsync(long fleetId) =>
            _esiClient.GetRequestAsync<FleetIdRouteRequest, List<Wing>>(FleetIdRouteRequest.Create(fleetId));

        public Task<EsiResponse<NewWing>> CreateFleetWingAsync(long fleetId) =>
            _esiClient.PostRequestAsync<FleetIdRouteRequest, NewWing>(FleetIdRouteRequest.Create(fleetId));

        public Task<EsiResponse> DeleteFleetWingAsync(long fleetId, long wingId) =>
            _esiClient.DeleteRequestAsync<FleetWingRouteRequest>(FleetWingRouteRequest.Create(fleetId, wingId));

        public Task<EsiResponse> RenameFleetWingAsync(long fleetId, long wingId, string name) =>
            _esiClient.PutRequestAsync<RenameWingRequest>(RenameWingRequest.Create(fleetId, wingId, name));

        public Task<EsiResponse<NewSquad>> CreateSquadAsync(long fleetId, long wingId) =>
            _esiClient.PostRequestAsync<FleetWingRouteRequest, NewSquad>(FleetWingRouteRequest.Create(fleetId, wingId));
    }
}
