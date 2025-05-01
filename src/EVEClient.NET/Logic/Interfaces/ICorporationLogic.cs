using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface ICorporationLogic
    {
        /// <summary>
        /// Public information about a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<CorporationInfo>> Information(int corporationId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of all the alliances a corporation has been a member of
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<AllianceHistory>>> AllianceHistory(int corporationId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a list of blueprints the corporation owns
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Blueprint>>> Blueprints(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns logs recorded in the past seven days from all audit log secure containers (ALSC) owned by a given corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<ContainerLog>>> ContainersLogs(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return corporation hangar and wallet division names, only show if a division is not using the default name
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<Divisions>> Divisions(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a corporation’s facilities
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<Facility>>> Facilities(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the icon urls for a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<CorporationIcon>> Icons(int corporationId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a corporation’s medals
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<CorporationMedal>>> Medals(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns medals issued by a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<CorporationIssuedMedal>>> IssuedMedals(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return the current member list of a corporation, the token’s character need to be a member of the corporation.
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<int>>> Members(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a corporation’s member limit, not including CEO himself
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<int>> MembersLimit(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a corporation’s member’s titles
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<MemberTitle>>> MembersTitles(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns additional information about a corporation’s members which helps tracking their activities
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<MemberTracking>>> MemberTracking(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return the roles of all members if the character has the personnel manager role or any grantable role.
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<MemberRole>>> Roles(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return how roles have changed for a coporation’s members, up to a month
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<MemberRoleHistory>>> RolesHistory(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return the current shareholders of a corporation.
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Shareholder>>> Shareholders(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return corporation standings from agents, NPC corporations, and factions
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<CorporationStanding>>> Standings(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns list of corporation starbases (POSes)
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        /// <remarks>Requires one of the following EVE corporation role(s): Director</remarks>
        Task<EsiResponsePagination<List<Starbase>>> Starbases(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns various settings and fuels of a starbase (POS)
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="starbaseId">An EVE starbase (POS) ID</param>
        /// <param name="systemId">The solar system this starbase (POS) is located in</param>
        Task<EsiResponse<StarbaseInfo>> StarbaseInfo(int corporationId, long starbaseId, int systemId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of corporation structures.
        /// This route’s version includes the changes to structures detailed in this blog: https://www.eveonline.com/article/upwell-2.0-structures-changes-coming-on-february-13th
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Structure>>> Structures(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a corporation’s titles
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<Title>>> Titles(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of npc corporations
        /// </summary>
        Task<EsiResponse<List<int>>> NpcCorporations(CancellationToken cancellationToken = default);
    }
}
