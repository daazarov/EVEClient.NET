using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface ICharacterLogic
    {
        /// <summary>
        /// Public information about a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Public data for the given character</returns>
        Task<EsiResponse<CharacterPublicInformation>> PublicInformation(int characterId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return character standings from agents, NPC corporations, and factions
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<CharacterStanding>>> Standings(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of agents research information for a character.
        /// The formula for finding the current research points with an agent is: currentPoints = remainderPoints + pointsPerDay * days(currentTime - researchStartDate)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<CharacterAgentsResearch>>> AgentsResearch(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// A list of blueprints
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<CharacterBlueprint>>> Blueprints(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// A list of blueprints
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="pageLimit">How many pages to load. No limit by default.</param>
        /// <param name="pageOffset">How many pages to skip. No skip by default.</param>
        /// <param name="token">The EVE access token. If not specified, the <see cref="IAccessTokenProvider"/> is used.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        //Task<EsiStreamResponse<CharacterBlueprint>> Blueprints(int characterId, int pageLimit = 0, int pageOffset = 0, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of all the corporations a character has been a member of
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<CharacterCorporationHistory>>> CorporationHistory(int characterId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Takes a source character ID in the url and a set of target character ID’s in the body, returns a CSPA charge cost
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="characterIds">The target characters to calculate the charge for</param>
        /// <returns></returns>
        Task<EsiResponse<long>> CSPA(int characterId, int[] characterIds, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a character’s jump activation and fatigue information
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<CharacterFatigue>> Fatigue(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of medals the character has
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<CharacterMedal>>> Medals(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return character notifications
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<CharacterNotification>>> Notifications(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return notifications about having been added to someone’s contact list
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<CharacterContactNotification>>> ContactNotifications(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get portrait urls for a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<CharacterPortrait>> Portrait(int characterId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a character’s corporation roles
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<CharacterRoles>> Roles(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a character’s titles
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<CharacterTitle>>> Titles(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk lookup of character IDs to corporation, alliance and faction
        /// </summary>
        /// <param name="characterIds">The character IDs to fetch affiliations for. All characters must exist, or none will be returned</param>
        Task<EsiResponse<List<CharacterAffilation>>> Affilation(int[] characterIds, CancellationToken cancellationToken = default);
    }
}
