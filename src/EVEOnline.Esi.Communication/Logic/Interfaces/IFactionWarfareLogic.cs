using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IFactionWarfareLogic
    {
        /// <summary>
        /// Statistical overview of a character involved in faction warfare
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_fw_stats.v1")]
        [Route("/latest/characters/{character_id}/fw/stats/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/fw/stats/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/fw/stats/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/characters/{character_id}/fw/stats/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/fw/stats/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CharacterStats>> GetCharacterStatsAsync(int characterId);

        /// <summary>
        /// Statistics about a corporation involved in faction warfare
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_fw_stats.v1")]
        [Route("/latest/corporations/{corporation_id}/fw/stats/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/fw/stats/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/fw/stats/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/corporations/{corporation_id}/fw/stats/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/fw/stats/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CorporationStats>> GetCorporationStatsAsync(int corporationId);

        /// <summary>
        /// Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/fw/leaderboards/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fw/leaderboards/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fw/leaderboards/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/fw/leaderboards/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/fw/leaderboards/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Leaderboards<FactionTotal>>> GetFactionsLeaderboardAsync();

        /// <summary>
        /// Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/fw/leaderboards/characters/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fw/leaderboards/characters/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fw/leaderboards/characters/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/fw/leaderboards/characters/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/fw/leaderboards/characters/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Leaderboards<CharacterTotal>>> GetCaractersLeaderboardAsync();

        /// <summary>
        /// Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/fw/leaderboards/corporations/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fw/leaderboards/corporations/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fw/leaderboards/corporations/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/fw/leaderboards/corporations/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/fw/leaderboards/corporations/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Leaderboards<CorporationTotal>>> GetCorporationsLeaderboardAsync();

        /// <summary>
        /// Statistical overviews of factions involved in faction warfare
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/fw/stats/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fw/stats/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fw/stats/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/fw/stats/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/fw/stats/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<FactionStats>> GetFactionsStatsAsync();

        /// <summary>
        /// An overview of the current ownership of faction warfare solar systems
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/fw/systems/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fw/systems/", Version = EndpointVersion.Legacy)]
        [Route("/v2/fw/systems/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/v3/fw/systems/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/fw/systems/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<FactionWarfareSystem>>> OwnershipSystemOverviewAsync();

        /// <summary>
        /// Data about which NPC factions are at war
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/fw/wars/", Version = EndpointVersion.Latest)]
        [Route("/legacy/fw/wars/", Version = EndpointVersion.Legacy)]
        [Route("/v1/fw/wars/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/fw/wars/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/fw/wars/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<War>>> GetWarsAsync();
    }
}
