using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IAssetsLogic
    {
        /// <summary>
        /// Return a list of the characters assets
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-assets.read_assets.v1")]
        [Route("/latest/characters/{character_id}/assets/", Version = EndpointVersion.Latest)]
        [Route("/v5/characters/{character_id}/assets/", Version = EndpointVersion.V5, Preferred = true)]
        [Route("/dev/characters/{character_id}/assets/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Item>>> GetCharacterAssets(int characterId, int page = 1);

        /// <summary>
        /// Return locations for a set of item ids, which you can get from character assets endpoint.
        /// Coordinates for items in hangars or stations are set to (0,0,0)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="itemIds">A list of item ids</param>
        [ProtectedEndpoint(RequiredScope = "esi-assets.read_assets.v1")]
        [Route("/latest/characters/{character_id}/assets/locations/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/assets/locations/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/assets/locations/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ItemLocation>>> PostCharacterLocationAssets(int characterId, long[] itemIds);

        /// <summary>
        /// Return names for a set of item ids, which you can get from character assets endpoint.
        /// Typically used for items that can customize names, like containers or ships.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="itemIds">A list of item ids</param>
        [ProtectedEndpoint(RequiredScope = "esi-assets.read_assets.v1")]
        [Route("/latest/characters/{character_id}/assets/names/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/assets/names/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/assets/names/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/assets/names/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ItemName>>> PostCharacterNameAssets(int characterId, long[] itemIds);


        /// <summary>
        /// Return a list of the corporation assets
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        /// <returns></returns>
        [ProtectedEndpoint(RequiredScope = "esi-assets.read_corporation_assets.v1")]
        [Route("/latest/corporations/{corporation_id}/assets/", Version = EndpointVersion.Latest)]
        [Route("/v5/corporations/{corporation_id}/assets/", Version = EndpointVersion.V5, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/assets/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Item>>> GetCorporationAssets(int corporationId, int page = 1);

        /// <summary>
        /// Return locations for a set of item ids, which you can get from corporation assets endpoint.
        /// Coordinates for items in hangars or stations are set to (0,0,0)
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="itemIds">A list of item ids</param>
        [ProtectedEndpoint(RequiredScope = "esi-assets.read_corporation_assets.v1")]
        [Route("/latest/corporations/{corporation_id}/assets/locations/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/assets/locations/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/assets/locations/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ItemLocation>>> PostCorporationLocationAssets(int corporationId, long[] itemIds);

        /// <summary>
        /// Return names for a set of item ids, which you can get from corporation assets endpoint.
        /// Only valid for items that can customize names, like containers or ships
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="itemIds">A list of item ids</param>
        [ProtectedEndpoint(RequiredScope = "esi-assets.read_corporation_assets.v1")]
        [Route("/latest/corporations/{corporation_id}/assets/names/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/assets/names/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/assets/names/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/assets/names/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ItemName>>> PostCorporationNameAssets(int corporationId, long[] itemIds);
    }
}
