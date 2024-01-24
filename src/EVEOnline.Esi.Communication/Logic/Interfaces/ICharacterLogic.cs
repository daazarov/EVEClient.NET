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
        public Task<EsiResponse<CharacterPublicInformation>> GetCharacterPulicInformationAsync(int characterId);

        /// <summary>
        /// Return character standings from agents, NPC corporations, and factions
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_standings.v1")]
        [Route("/latest/characters/{character_id}/standings/", Type = EndpointType.Latest)]
        [Route("/v2/characters/{character_id}/standings/", Type = EndpointType.V2)]
        [Route("/dev/characters/{character_id}/standings/", Type = EndpointType.Dev)]
        public Task<EsiResponse<IEnumerable<CharacterStanding>>> GetCharacterStandingsAsync(int characterId);
    }
}
