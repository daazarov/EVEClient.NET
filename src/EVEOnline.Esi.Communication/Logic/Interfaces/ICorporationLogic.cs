using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.Attributes;
using EVEOnline.Esi.Communication.DataContract;

namespace EVEOnline.Esi.Communication
{
    public interface ICorporationLogic
    {
        /// <summary>
        /// Public information about a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [PublicEndpoint]
        [Route("/latest/corporations/{corporation_id}/", Version = EndpointVersion.Latest)]
        [Route("/v5/corporations/{corporation_id}/", Version = EndpointVersion.V5, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CorporationInfo>> GetCorporationInfoAsync(int corporationId);

        /// <summary>
        /// Get a list of all the alliances a corporation has been a member of
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [PublicEndpoint]
        [Route("/latest/corporations/{corporation_id}/alliancehistory/", Version = EndpointVersion.Latest)]
        [Route("/v3/corporations/{corporation_id}/alliancehistory/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/alliancehistory/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<AllianceHistory>>> GetCorporationAllianceHistoryAsync(int corporationId);

        /// <summary>
        /// Returns a list of blueprints the corporation owns
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_blueprints.v1")]
        [Route("/latest/corporations/{corporation_id}/blueprints/", Version = EndpointVersion.Latest)]
        [Route("/v3/corporations/{corporation_id}/blueprints/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/blueprints/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Blueprint>>> GetCorporationBlueprintsAsync(int corporationId, int page = 1);

        /// <summary>
        /// Returns logs recorded in the past seven days from all audit log secure containers (ALSC) owned by a given corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_container_logs.v1")]
        [Route("/latest/corporations/{corporation_id}/containers/logs/", Version = EndpointVersion.Latest)]
        [Route("/v3/corporations/{corporation_id}/containers/logs/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/containers/logs/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<ContainerLog>>> GetCorporationContainerLogsAsync(int corporationId, int page = 1);

        /// <summary>
        /// Return corporation hangar and wallet division names, only show if a division is not using the default name
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_divisions.v1")]
        [Route("/latest/corporations/{corporation_id}/divisions/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/divisions/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/divisions/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Divisions>> GetCorporationDivisionsAsync(int corporationId);

        /// <summary>
        /// Return a corporation’s facilities
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_facilities.v1")]
        [Route("/latest/corporations/{corporation_id}/facilities/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/facilities/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/facilities/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Facility>>> GetCorporationFacilitiesAsync(int corporationId);

        /// <summary>
        /// Get the icon urls for a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [PublicEndpoint]
        [Route("/latest/corporations/{corporation_id}/icons/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/icons/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/icons/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CorporationIcon>> GetCorporationIconAsync(int corporationId);

        /// <summary>
        /// Returns a corporation’s medals
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_medals.v1")]
        [Route("/latest/corporations/{corporation_id}/medals", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/medals/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/medals/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CorporationMedal>>> GetCorporationMedalsAsync(int corporationId, int page = 1);

        /// <summary>
        /// Returns medals issued by a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_medals.v1")]
        [Route("/latest/corporations/{corporation_id}/medals/issued/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/medals/issued/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/medals/issued/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CorporationIssuedMedal>>> GetCorporationIssuedMedalsAsync(int corporationId, int page = 1);

        /// <summary>
        /// Return the current member list of a corporation, the token’s character need to be a member of the corporation.
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_corporation_membership.v1")]
        [Route("/latest/corporations/{corporation_id}/members/", Version = EndpointVersion.Latest)]
        [Route("/v4/corporations/{corporation_id}/members/", Version = EndpointVersion.V4, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/members/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> GetCorporationMembersAsync(int corporationId);

        /// <summary>
        /// Return a corporation’s member limit, not including CEO himself
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.track_members.v1")]
        [Route("/latest/corporations/{corporation_id}/members/limit/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/members/limit/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/members/limit/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<int>> GetCorporationMemberLimitAsync(int corporationId);

        /// <summary>
        /// Returns a corporation’s member’s titles
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_titles.v1")]
        [Route("/latest/corporations/{corporation_id}/members/titles/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/members/titles/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/members/titles/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<MemberTitle>>> GetCorporationMemberTitlesAsync(int corporationId);

        /// <summary>
        /// Returns additional information about a corporation’s members which helps tracking their activities
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.track_members.v1")]
        [Route("/latest/corporations/{corporation_id}/membertracking/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/membertracking/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/membertracking/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<MemberTracking>>> GetCorporationMemberTrackingAsync(int corporationId);

        /// <summary>
        /// Return the roles of all members if the character has the personnel manager role or any grantable role.
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_corporation_membership.v1")]
        [Route("/latest/corporations/{corporation_id}/roles/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/roles/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/roles/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<MemberRole>>> GetCorporationMemberRolesAsync(int corporationId);

        /// <summary>
        /// Return how roles have changed for a coporation’s members, up to a month
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_corporation_membership.v1")]
        [Route("/latest/corporations/{corporation_id}/roles/history/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/roles/history/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/roles/history/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<MemberRoleHistory>>> GetCorporationMemberRolesHistoryAsync(int corporationId, int page = 1);

        /// <summary>
        /// Return the current shareholders of a corporation.
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-wallet.read_corporation_wallets.v1")]
        [Route("/latest/corporations/{corporation_id}/shareholders/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/shareholders/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/shareholders/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/shareholders/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Shareholder>>> GetCorporationShareholdersAsync(int corporationId, int page = 1);

        /// <summary>
        /// Return corporation standings from agents, NPC corporations, and factions
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_standings.v1")]
        [Route("/latest/corporations/{corporation_id}/standings/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/standings/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/standings/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CorporationStanding>>> GetCorporationStandingsAsync(int corporationId, int page = 1);

        /// <summary>
        /// Returns list of corporation starbases (POSes)
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_starbases.v1")]
        [Route("/latest/corporations/{corporation_id}/starbases/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/starbases/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/starbases/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Starbase>>> GetCorporationStarbasesAsync(int corporationId, int page = 1);

        /// <summary>
        /// Returns various settings and fuels of a starbase (POS)
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="starbaseId">An EVE starbase (POS) ID</param>
        /// <param name="systemId">The solar system this starbase (POS) is located in</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_starbases.v1")]
        [Route("/latest/corporations/{corporation_id}/starbases/{starbase_id}/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/starbases/{starbase_id}/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/starbases/{starbase_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<StarbaseInfo>> GetStarbaseInfoAsync(int corporationId, long starbaseId, int systemId);

        /// <summary>
        /// Get a list of corporation structures.
        /// This route’s version includes the changes to structures detailed in this blog: https://www.eveonline.com/article/upwell-2.0-structures-changes-coming-on-february-13th
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_structures.v1")]
        [Route("/latest/corporations/{corporation_id}/structures/", Version = EndpointVersion.Latest)]
        [Route("/v4/corporations/{corporation_id}/structures/", Version = EndpointVersion.V4, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/structures/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Structure>>> GetCorporationStructuresAsync(int corporationId, int page = 1);

        /// <summary>
        /// Returns a corporation’s titles
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_titles.v1")]
        [Route("/latest/corporations/{corporation_id}/titles/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/titles/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/titles/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Title>>> GetCorporationTitlesAsync(int corporationId);

        /// <summary>
        /// Get a list of npc corporations
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/corporations/npccorps/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/npccorps/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/npccorps/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> GetNpcCorporationsAsync();
    }
}
