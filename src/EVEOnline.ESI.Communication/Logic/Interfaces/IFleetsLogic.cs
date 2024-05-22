using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IFleetsLogic
    {
        /// <summary>
        /// Return the fleet ID the character is in, if any.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.read_fleet.v1")]
        [Route("/latest/characters/{character_id}/fleet/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/fleet/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/fleet/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<FleetInfo>> FleetInfo(int characterId);

        /// <summary>
        /// Return details about a fleet
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.read_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<FleetSettings>> FleetSettings(long fleetId);

        /// <summary>
        /// Update settings about a fleet
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="isFreeMove">Should free-move be enabled in the fleet</param>
        /// <param name="motd">New fleet MOTD in CCP flavoured HTML</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> UpdateFleetSettings(long fleetId, bool? isFreeMove, string motd);

        /// <summary>
        /// Return information about fleet members
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.read_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/members/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/members/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/members/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/members/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<FleetMember>>> FleetMembers(long fleetId);

        /// <summary>
        /// Invite a character into the fleet. If a character has a CSPA charge set it is not possible to invite them to the fleet using ESI
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="characterId">The character you want to invite</param>
        /// <param name="role">
        /// <para>If a character is invited with the <see cref="FleetRole.FleetCommander"/> role, neither wingId or squad_id should be specified.</para>
        /// <para>If a character is invited with the <see cref="FleetRole.WingCommander"/> role, only wingId should be specified.</para>
        /// <para>If a character is invited with the <see cref="FleetRole.SquadCommander"/> role, both wingId and squadId should be specified.</para>
        /// <para>If a character is invited with the <see cref="FleetRole.SquadMember"/> role, wingId and squadId should either both be specified or not specified at all.
        /// If they aren’t specified, the invited character will join any squad with available positions.</para>
        /// </param>
        /// <param name="squadId">squad_id integer</param>
        /// <param name="wingId">wing_id integer</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/members/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/members/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/members/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/members/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> InviteMember(long fleetId, int characterId, FleetRole role, long? squadId = null, long? wingId = null);

        /// <summary>
        /// Kick a fleet member
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="memberId">The character ID of a member in this fleet</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/members/{member_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/members/{member_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/members/{member_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/members/{member_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> KickMember(long fleetId, int memberId);

        /// <summary>
        /// Move a fleet member around
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="memberId">The character ID of a member in this fleet</param>
        /// <param name="role">
        /// <para>If a character is moved to the <see cref="FleetRole.FleetCommander"/> role, neither wing_id or squad_id should be specified.</para>
        /// <para>If a character is moved to the <see cref="FleetRole.WingCommander"/> role, only wing_id should be specified.</para>
        /// <para>If a character is moved to the <see cref="FleetRole.SquadCommander"/> role, both wing_id and squad_id should be specified.</para>
        /// <para>If a character is moved to the <see cref="FleetRole.SquadMember"/> role, both wing_id and squad_id should be specified.</para>
        /// </param>
        /// <param name="squadId">squad_id integer</param>
        /// <param name="wingId">wing_id integer</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/members/{member_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/members/{member_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/members/{member_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/members/{member_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> MoveMember(long fleetId, int memberId, FleetRole role, long? squadId = null, long? wingId = null);

        /// <summary>
        /// Delete a fleet squad, only empty squads can be deleted
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="squadId">The squad to delete</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/squads/{squad_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/squads/{squad_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/squads/{squad_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/squads/{squad_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> DeleteSquad(long fleetId, long squadId);

        /// <summary>
        /// Rename a fleet squad
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="squadId">The squad to rename</param>
        /// <param name="name">New name of the squad (maxLength: 10)</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/squads/{squad_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/squads/{squad_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/squads/{squad_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/squads/{squad_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> RenameSquad(long fleetId, long squadId, string name);

        /// <summary>
        /// Return information about wings in a fleet
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.read_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/wings/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/wings/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/wings/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/wings/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Wing>>> FleetWings(long fleetId);

        /// <summary>
        /// Create a new wing in a fleet
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/wings/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/wings/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/wings/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/wings/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<NewWing>> NewWing(long fleetId);

        /// <summary>
        /// Delete a fleet wing, only empty wings can be deleted. The wing may contain squads, but the squads must be empty
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="wingId">The wing to delete</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/wings/{wing_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/wings/{wing_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/wings/{wing_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/wings/{wing_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> DeleteWing(long fleetId, long wingId);

        /// <summary>
        /// Rename a fleet wing
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="wingId">The wing to rename</param>
        /// <param name="name">New name of the wing</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/wings/{wing_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/wings/{wing_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/wings/{wing_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/wings/{wing_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> RenameWing(long fleetId, long wingId, string name);

        /// <summary>
        /// Create a new squad in a fleet
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="wingId">The wing_id to create squad in</param>
        [ProtectedEndpoint(RequiredScope = "esi-fleets.write_fleet.v1")]
        [Route("/latest/fleets/{fleet_id}/wings/{wing_id}/squads/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fleets/{fleet_id}/wings/{wing_id}/squads/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fleets/{fleet_id}/wings/{wing_id}/squads/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/fleets/{fleet_id}/wings/{wing_id}/squads/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<NewSquad>> NewSquad(long fleetId, long wingId);
    }
}
