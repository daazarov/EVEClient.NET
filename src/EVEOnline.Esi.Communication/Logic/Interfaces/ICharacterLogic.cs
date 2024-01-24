using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.Attributes;
using EVEOnline.Esi.Communication.DataContract;

namespace EVEOnline.Esi.Communication
{
    public interface ICharacterLogic
    {
        /// <summary>
        /// Public information about a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Public data for the given character</returns>
        [PublicEndpoint]
        [Route("/latest/characters/{character_id}/", Type = EndpointType.Latest)]
        [Route("/v5/characters/{character_id}/", Type = EndpointType.V5)]
        [Route("/legacy/characters/{character_id}/", Type = EndpointType.Legacy)]
        [Route("/dev/characters/{character_id}/", Type = EndpointType.Dev)]
        Task<EsiResponse<CharacterPublicInformation>> GetCharacterPulicInformationAsync(int characterId);

        /// <summary>
        /// Return character standings from agents, NPC corporations, and factions
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_standings.v1")]
        [Route("/latest/characters/{character_id}/standings/", Type = EndpointType.Latest)]
        [Route("/v2/characters/{character_id}/standings/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/standings/", Type = EndpointType.Dev)]
        Task<EsiResponse<IEnumerable<CharacterStanding>>> GetCharacterStandingsAsync(int characterId);

        /// <summary>
        /// Return a list of agents research information for a character.
        /// The formula for finding the current research points with an agent is: currentPoints = remainderPoints + pointsPerDay * days(currentTime - researchStartDate)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_agents_research.v1")]
        [Route("/latest/characters/{character_id}/agents_research/", Type = EndpointType.Latest)]
        [Route("/v2/characters/{character_id}/agents_research/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/agents_research/", Type = EndpointType.Dev)]
        Task<EsiResponse<IEnumerable<CharacterAgentsResearch>>> GetCharacterAgentsResearchAsync(int characterId);

        /// <summary>
        /// A list of blueprints
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_blueprints.v1")]
        [Route("/latest/characters/{character_id}/blueprints/", Type = EndpointType.Latest)]
        [Route("/v3/characters/{character_id}/blueprints/", Type = EndpointType.V3)]
        [Route("/dev/characters/{character_id}/blueprints/", Type = EndpointType.Dev)]
        Task<EsiResponsePagination<IEnumerable<CharacterBlueprint>>> GetCharacterBlueprintsAsync(int characterId, int page = 1);

        /// <summary>
        /// Get a list of all the corporations a character has been a member of
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [PublicEndpoint]
        [Route("/latest/characters/{character_id}/corporationhistory/", Type = EndpointType.Latest)]
        [Route("/v2/characters/{character_id}/corporationhistory/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/corporationhistory/", Type = EndpointType.Dev)]
        Task<EsiResponse<IEnumerable<CharacterCorporationHistory>>> GetCharacterCorporationHistoryAsync(int characterId);

        /// <summary>
        /// Takes a source character ID in the url and a set of target character ID’s in the body, returns a CSPA charge cost
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="characterIds">The target characters to calculate the charge for</param>
        /// <returns></returns>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_contacts.v1")]
        [Route("/latest/characters/{character_id}/cspa/", Type = EndpointType.Latest)]
        [Route("/v5/characters/{character_id}/cspa/", Type = EndpointType.V5)]
        [Route("/dev/characters/{character_id}/cspa/", Type = EndpointType.Dev)]
        Task<EsiResponse<long>> PostCharacterCspaAsync(int characterId, int[] characterIds);

        /// <summary>
        /// Return a character’s jump activation and fatigue information
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_fatigue.v1")]
        [Route("/latest/characters/{character_id}/fatigue/", Type = EndpointType.Latest)]
        [Route("/v2/characters/{character_id}/fatigue/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/fatigue/", Type = EndpointType.Dev)]
        Task<EsiResponse<CharacterFatigue>> GetCharacterFatigueAsync(int characterId);

        /// <summary>
        /// Return a list of medals the character has
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_medals.v1")]
        [Route("/latest/characters/{character_id}/medals/", Type = EndpointType.Latest)]
        [Route("/v2/characters/{character_id}/medals/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/medals/", Type = EndpointType.Dev)]
        Task<EsiResponse<IEnumerable<CharacterMedal>>> GetCharacterMedalsAsync(int characterId);

        /// <summary>
        /// Return character notifications
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_notifications.v1")]
        [Route("/latest/characters/{character_id}/notifications/", Type = EndpointType.Latest)]
        [Route("/v5/characters/{character_id}/notifications/", Type = EndpointType.V5)]
        [Route("/v6/characters/{character_id}/notifications/", Type = EndpointType.V6)]
        [Route("/dev/characters/{character_id}/notifications/", Type = EndpointType.Dev)]
        Task<EsiResponse<IEnumerable<CharacterNotification>>> GetCharacterNotificationsAsync(int characterId);

        /// <summary>
        /// Return notifications about having been added to someone’s contact list
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_notifications.v1")]
        [Route("/latest/characters/{character_id}/notifications/contacts/", Type = EndpointType.Latest)]
        [Route("/v2/characters/{character_id}/notifications/contacts/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/notifications/contacts/", Type = EndpointType.Dev)]
        Task<EsiResponse<IEnumerable<CharacterContactNotification>>> GetCharacterContactNotificationsAsync(int characterId);

        /// <summary>
        /// Get portrait urls for a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [PublicEndpoint]
        [Route("/latest/characters/{character_id}/portrait/", Type = EndpointType.Latest)]
        [Route("/v3/characters/{character_id}/portrait/", Type = EndpointType.V3)]
        [Route("/v2/characters/{character_id}/portrait/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/portrait/", Type = EndpointType.Dev)]
        Task<EsiResponse<CharacterPortrait>> GetCharacterPortraitAsync(int characterId);

        /// <summary>
        /// Returns a character’s corporation roles
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_corporation_roles.v1")]
        [Route("/latest/characters/{character_id}/roles/", Type = EndpointType.Latest)]
        [Route("/v3/characters/{character_id}/roles/", Type = EndpointType.V3)]
        [Route("/dev/characters/{character_id}/roles/", Type = EndpointType.Dev)]
        Task<EsiResponse<CharacterRoles>> GetCharacterRolesAsync(int characterId);

        /// <summary>
        /// Returns a character’s titles
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_titles.v1")]
        [Route("/latest/characters/{character_id}/titles/", Type = EndpointType.Latest)]
        [Route("/v2/characters/{character_id}/titles/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/titles/", Type = EndpointType.Dev)]
        Task<EsiResponse<IEnumerable<CharacterTitle>>> GetCharacterTitlesAsync(int characterId);

        /// <summary>
        /// Bulk lookup of character IDs to corporation, alliance and faction
        /// </summary>
        /// <param name="characterIds">The character IDs to fetch affiliations for. All characters must exist, or none will be returned</param>
        [PublicEndpoint]
        [Route("/latest/characters/affiliation/", Type = EndpointType.Latest)]
        [Route("/v2/characters/affiliation/", Type = EndpointType.V2)]
        [Route("/dev/characters/affiliation/", Type = EndpointType.Dev)]
        Task<EsiResponse<IEnumerable<CharacterAffilation>>> PostCharacterAffilationAsync(int[] characterIds);
    }
}
