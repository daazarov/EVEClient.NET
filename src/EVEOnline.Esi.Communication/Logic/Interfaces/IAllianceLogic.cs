﻿using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.Attributes;
using EVEOnline.Esi.Communication.DataContract;

namespace EVEOnline.Esi.Communication.Logic.Interfaces
{
    public interface IAllianceLogic
    {
        /// <summary>
        /// List all active player alliances
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/alliances/", Version = EndpointVersion.Latest)]
        [Route("/v1/alliances/", Version = EndpointVersion.V1)]
        [Route("/v2/alliances/", Version = EndpointVersion.V2)]
        [Route("/legacy/alliances/", Version = EndpointVersion.Legacy)]
        [Route("/dev/alliances/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<IEnumerable<int>>> GetAlliancesAsync();

        /// <summary>
        /// Public information about an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        [PublicEndpoint]
        [Route("/latest/alliances/{alliance_id}/", Version = EndpointVersion.Latest)]
        [Route("/v3/alliances/{alliance_id}/", Version = EndpointVersion.V3)]
        [Route("/v4/alliances/{alliance_id}/", Version = EndpointVersion.V4)]
        [Route("/legacy/alliances/{alliance_id}/", Version = EndpointVersion.Legacy)]
        [Route("/dev/alliances/{alliance_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Alliance>> GetAlliancePublicInformationAsync(int allianceId);

        /// <summary>
        /// List all current member corporations of an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        [PublicEndpoint]
        [Route("/latest/alliances/{alliance_id}/corporations/", Version = EndpointVersion.Latest)]
        [Route("/v1/alliances/{alliance_id}/corporations/", Version = EndpointVersion.V1)]
        [Route("/v2/alliances/{alliance_id}/corporations/", Version = EndpointVersion.V2)]
        [Route("/legacy/alliances/{alliance_id}/corporations/", Version = EndpointVersion.Legacy)]
        [Route("/dev/alliances/{alliance_id}/corporations/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<IEnumerable<int>>> GetAllianceCorporationsAsync(int allianceId);

        /// <summary>
        /// Get the icon urls for a alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <returns></returns>
        [PublicEndpoint]
        [Route("/latest/alliances/{alliance_id}/icons/", Version = EndpointVersion.Latest, Default = true)]
        [Route("/v1/alliances/{alliance_id}/icons/", Version = EndpointVersion.V1)]
        [Route("/legacy/alliances/{alliance_id}/icons/", Version = EndpointVersion.Legacy)]
        [Route("/dev/alliances/{alliance_id}/icons/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<AllianceIcon>> GetAllianceIconAsync(int allianceId);
    }
}