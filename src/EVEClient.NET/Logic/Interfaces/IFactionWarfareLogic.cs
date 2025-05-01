using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IFactionWarfareLogic
    {
        /// <summary>
        /// Statistical overview of a character involved in faction warfare
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<CharacterStats>> CharacterStats(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Statistics about a corporation involved in faction warfare
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<CorporationStats>> CorporationStats(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday
        /// </summary>
        Task<EsiResponse<Leaderboards<FactionTotal>>> FactionsLeaderboard(CancellationToken cancellationToken = default);

        /// <summary>
        /// Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday
        /// </summary>
        Task<EsiResponse<Leaderboards<CharacterTotal>>> CaractersLeaderboard(CancellationToken cancellationToken = default);

        /// <summary>
        /// Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday
        /// </summary>
        Task<EsiResponse<Leaderboards<CorporationTotal>>> CorporationsLeaderboard(CancellationToken cancellationToken = default);

        /// <summary>
        /// Statistical overviews of factions involved in faction warfare
        /// </summary>
        Task<EsiResponse<FactionStats>> FactionsStats(CancellationToken cancellationToken = default);

        /// <summary>
        /// An overview of the current ownership of faction warfare solar systems
        /// </summary>
        Task<EsiResponse<List<FactionWarfareSystem>>> OwnershipSystemOverview(CancellationToken cancellationToken = default);

        /// <summary>
        /// Data about which NPC factions are at war
        /// </summary>
        Task<EsiResponse<List<FactionWar>>> Wars(CancellationToken cancellationToken = default);
    }
}
