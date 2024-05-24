using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
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
        [PublicEndpoint]
        [Route("/latest/characters/{character_id}/", Version = EndpointVersion.Latest)]
        [Route("/v5/characters/{character_id}/", Version = EndpointVersion.V5, Preferred = true)]
        [Route("/legacy/characters/{character_id}/", Version = EndpointVersion.Legacy)]
        [Route("/dev/characters/{character_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CharacterPublicInformation>> PublicInformation(int characterId);

        /// <summary>
        /// Return character standings from agents, NPC corporations, and factions
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_standings.v1")]
        [Route("/latest/characters/{character_id}/standings/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/standings/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/standings/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterStanding>>> Standings(int characterId);

        /// <summary>
        /// Return a list of agents research information for a character.
        /// The formula for finding the current research points with an agent is: currentPoints = remainderPoints + pointsPerDay * days(currentTime - researchStartDate)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_agents_research.v1")]
        [Route("/latest/characters/{character_id}/agents_research/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/agents_research/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/agents_research/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterAgentsResearch>>> AgentsResearch(int characterId);

        /// <summary>
        /// A list of blueprints
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_blueprints.v1")]
        [Route("/latest/characters/{character_id}/blueprints/", Version = EndpointVersion.Latest)]
        [Route("/v3/characters/{character_id}/blueprints/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/characters/{character_id}/blueprints/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CharacterBlueprint>>> Blueprints(int characterId, int page = 1);

        /// <summary>
        /// Get a list of all the corporations a character has been a member of
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [PublicEndpoint]
        [Route("/latest/characters/{character_id}/corporationhistory/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/corporationhistory/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/corporationhistory/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterCorporationHistory>>> CorporationHistory(int characterId);

        /// <summary>
        /// Takes a source character ID in the url and a set of target character ID’s in the body, returns a CSPA charge cost
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="characterIds">The target characters to calculate the charge for</param>
        /// <returns></returns>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_contacts.v1")]
        [Route("/latest/characters/{character_id}/cspa/", Version = EndpointVersion.Latest)]
        [Route("/v5/characters/{character_id}/cspa/", Version = EndpointVersion.V5, Preferred = true)]
        [Route("/dev/characters/{character_id}/cspa/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<long>> CSPA(int characterId, int[] characterIds);

        /// <summary>
        /// Return a character’s jump activation and fatigue information
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_fatigue.v1")]
        [Route("/latest/characters/{character_id}/fatigue/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/fatigue/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/fatigue/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CharacterFatigue>> Fatigue(int characterId);

        /// <summary>
        /// Return a list of medals the character has
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_medals.v1")]
        [Route("/latest/characters/{character_id}/medals/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/medals/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/medals/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterMedal>>> Medals(int characterId);

        /// <summary>
        /// Return character notifications
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_notifications.v1")]
        [Route("/latest/characters/{character_id}/notifications/", Version = EndpointVersion.Latest)]
        [Route("/v5/characters/{character_id}/notifications/", Version = EndpointVersion.V5, Preferred = true)]
        [Route("/v6/characters/{character_id}/notifications/", Version = EndpointVersion.V6, Preferred = true)]
        [Route("/dev/characters/{character_id}/notifications/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterNotification>>> Notifications(int characterId);

        /// <summary>
        /// Return notifications about having been added to someone’s contact list
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_notifications.v1")]
        [Route("/latest/characters/{character_id}/notifications/contacts/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/notifications/contacts/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/notifications/contacts/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterContactNotification>>> ContactNotifications(int characterId);

        /// <summary>
        /// Get portrait urls for a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [PublicEndpoint]
        [Route("/latest/characters/{character_id}/portrait/", Version = EndpointVersion.Latest)]
        [Route("/v3/characters/{character_id}/portrait/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/v2/characters/{character_id}/portrait/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/portrait/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CharacterPortrait>> Portrait(int characterId);

        /// <summary>
        /// Returns a character’s corporation roles
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_corporation_roles.v1")]
        [Route("/latest/characters/{character_id}/roles/", Version = EndpointVersion.Latest)]
        [Route("/v3/characters/{character_id}/roles/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/characters/{character_id}/roles/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CharacterRoles>> Roles(int characterId);

        /// <summary>
        /// Returns a character’s titles
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_titles.v1")]
        [Route("/latest/characters/{character_id}/titles/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/titles/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/titles/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterTitle>>> Titles(int characterId);

        /// <summary>
        /// Bulk lookup of character IDs to corporation, alliance and faction
        /// </summary>
        /// <param name="characterIds">The character IDs to fetch affiliations for. All characters must exist, or none will be returned</param>
        [PublicEndpoint]
        [Route("/latest/characters/affiliation/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/affiliation/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/affiliation/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterAffilation>>> Affilation(int[] characterIds);
    }
}
