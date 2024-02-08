using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IIndustryLogic
    {
        /// <summary>
        /// List industry jobs placed by a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="includeCompleted">Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days</param>
        [ProtectedEndpoint(RequiredScope = "esi-industry.read_character_jobs.v1")]
        [Route("/latest/characters/{character_id}/industry/jobs/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/industry/jobs/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/industry/jobs/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/industry/jobs/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterIndustryJob>>> GetCharacterInductryJobsAsync(int characterId, bool includeCompleted = false);

        /// <summary>
        /// Paginated record of all mining done by a character for the past 30 days
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-industry.read_character_mining.v1")]
        [Route("/latest/characters/{character_id}/mining/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mining/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/mining/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/mining/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Mining>>> GetCharacterMiningLedgerAsync(int characterId, int page = 1);

        /// <summary>
        /// Extraction timers for all moon chunks being extracted by refineries belonging to a corporation.
        /// <para>Requires one of the following EVE corporation role(s): Station_Manager</para>
        /// </summary>
        /// <param name="corporation">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-industry.read_corporation_mining.v1")]
        [Route("/latest/corporation/{corporation_id}/mining/extractions/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporation/{corporation_id}/mining/extractions/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporation/{corporation_id}/mining/extractions/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporation/{corporation_id}/mining/extractions/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Extraction>>> GetCorporationExtractionTimersAsync(int corporation, int page = 1);

        /// <summary>
        /// Paginated list of all entities capable of observing and recording mining for a corporation
        /// </summary>
        /// <param name="corporation">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-industry.read_corporation_mining.v1")]
        [Route("/latest/corporation/{corporation_id}/mining/observers/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporation/{corporation_id}/mining/observers/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporation/{corporation_id}/mining/observers/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporation/{corporation_id}/mining/observers/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Observer>>> GetCorporationObserversAsync(int corporation, int page = 1);

        /// <summary>
        /// Paginated record of all mining seen by an observer
        /// </summary>
        /// <param name="corporation">An EVE corporation ID</param>
        /// <param name="observerId">A mining observer id</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-industry.read_corporation_mining.v1")]
        [Route("/latest/corporation/{corporation_id}/mining/observers/{observer_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporation/{corporation_id}/mining/observers/{observer_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporation/{corporation_id}/mining/observers/{observer_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporation/{corporation_id}/mining/observers/{observer_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<ObserverInfo>>> GetCorporationObserverInfoAsync(int corporation, long observerId, int page = 1);

        /// <summary>
        /// List industry jobs run by a corporation
        /// <para>Requires one of the following EVE corporation role(s): Factory_Manager</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="includeCompleted">Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-industry.read_corporation_jobs.v1")]
        [Route("/latest/corporations/{corporation_id}/industry/jobs/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/industry/jobs/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/industry/jobs/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/industry/jobs/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CorporationIndustryJob>>> GetCorporationInductryJobsAsync(int corporationId, bool includeCompleted = false, int page = 1);

        /// <summary>
        /// Return a list of industry facilities
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/industry/facilities/", Version = EndpointVersion.Latest)]
        [Route("/legacy/industry/facilities/", Version = EndpointVersion.Legacy)]
        [Route("/v1/industry/facilities/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/industry/facilities/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<IndustryFacility>>> GetIndustryFacilitiesAsync();

        /// <summary>
        /// Return cost indices for solar systems
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/industry/systems/", Version = EndpointVersion.Latest)]
        [Route("/legacy/industry/systems/", Version = EndpointVersion.Legacy)]
        [Route("/v1/industry/systems/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/industry/systems/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<SolarSystem>>> GetSolarSystemCostIndicesAsync();
    }
}
