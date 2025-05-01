using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IIndustryLogic
    {
        /// <summary>
        /// List industry jobs placed by a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="includeCompleted">Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days</param>
        Task<EsiResponse<List<CharacterIndustryJob>>> CharacterJobs(int characterId, bool includeCompleted = false, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Paginated record of all mining done by a character for the past 30 days
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Mining>>> CharacterMiningLedger(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Extraction timers for all moon chunks being extracted by refineries belonging to a corporation.
        /// <para>Requires one of the following EVE corporation role(s): Station_Manager</para>
        /// </summary>
        /// <param name="corporation">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Extraction>>> ExtractionTimers(int corporation, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Paginated list of all entities capable of observing and recording mining for a corporation
        /// </summary>
        /// <param name="corporation">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Observer>>> CorporationObservers(int corporation, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Paginated record of all mining seen by an observer
        /// </summary>
        /// <param name="corporation">An EVE corporation ID</param>
        /// <param name="observerId">A mining observer id</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<ObserverInfo>>> ObserverInfo(int corporation, long observerId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List industry jobs run by a corporation
        /// <para>Requires one of the following EVE corporation role(s): Factory_Manager</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="includeCompleted">Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<CorporationIndustryJob>>> CorporationJobs(int corporationId, bool includeCompleted = false, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of industry facilities
        /// </summary>
        Task<EsiResponse<List<IndustryFacility>>> Facilities(CancellationToken cancellationToken = default);

        /// <summary>
        /// Return cost indices for solar systems
        /// </summary>
        Task<EsiResponse<List<SolarSystem>>> SolarSystems(CancellationToken cancellationToken = default);
    }
}
