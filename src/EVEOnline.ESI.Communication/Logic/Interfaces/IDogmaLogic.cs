using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IDogmaLogic
    {
        /// <summary>
        /// Get a list of dogma attribute ids
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/dogma/attributes/", Version = EndpointVersion.Latest)]
        [Route("/legacy/dogma/attributes/", Version = EndpointVersion.Legacy)]
        [Route("/v1/dogma/attributes/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/dogma/attributes/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> Attributes();

        /// <summary>
        /// Get information on a dogma attribute
        /// </summary>
        /// <param name="attributeId">A dogma attribute ID</param>
        [PublicEndpoint]
        [Route("/latest/dogma/attributes/{attribute_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/dogma/attributes/{attribute_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/dogma/attributes/{attribute_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/dogma/attributes/{attribute_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<AttributeInfo>> AttributeInfo(int attributeId);

        /// <summary>
        /// Returns info about a dynamic item resulting from mutation with a mutaplasmid.
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/dogma/dynamic/items/{type_id}/{item_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/dogma/dynamic/items/{type_id}/{item_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/dogma/dynamic/items/{type_id}/{item_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/dogma/dynamic/items/{type_id}/{item_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<DynamicItemInfo>> DynamicItemInfo(long itemId, int typeId);

        /// <summary>
        /// Get a list of dogma effect ids
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/dogma/effects/", Version = EndpointVersion.Latest)]
        [Route("/legacy/dogma/effects/", Version = EndpointVersion.Legacy)]
        [Route("/v1/dogma/effects/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/dogma/effects/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> Effects();

        /// <summary>
        /// Get information on a dogma effect
        /// </summary>
        /// <param name="effectID">A dogma effect ID</param>
        [PublicEndpoint]
        [Route("/latest/dogma/effects/{effect_id}/", Version = EndpointVersion.Latest)]
        [Route("/v2/dogma/effects/{effect_id}/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/dogma/effects/{effect_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<EffectInfo>> EffectInfo(int effectId);
    }
}
