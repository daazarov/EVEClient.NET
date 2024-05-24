using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IContactsLogic
    {
        /// <summary>
        /// Return contacts of an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-alliances.read_contacts.v1")]
        [Route("/latest/alliances/{alliance_id}/contacts/", Version = EndpointVersion.Latest)]
        [Route("/v2/alliances/{alliance_id}/contacts/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/alliances/{alliance_id}/contacts/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<AlianceContact>>> AllianceContacts(int allianceId, int page = 1);

        /// <summary>
        /// Return custom labels for an alliance’s contacts
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-alliances.read_contacts.v1")]
        [Route("/latest/alliances/{alliance_id}/contacts/", Version = EndpointVersion.Latest)]
        [Route("/legacy/alliances/{alliance_id}/contacts/labels/", Version = EndpointVersion.Legacy)]
        [Route("/v1/alliances/{alliance_id}/contacts/labels/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/alliances/{alliance_id}/contacts/labels/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ContactLabel>>> AllianceContactLabels(int allianceId);

        /// <summary>
        /// Bulk delete contacts
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">A list of contacts to delete</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.write_contacts.v1")]
        [Route("/latest/characters/{character_id}/contacts/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/contacts/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/contacts/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> DeleteCharacterContacts(int characterId, int[] contactIds);


        /// <summary>
        /// Return contacts of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        /// <returns></returns>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_contacts.v1")]
        [Route("/latest/characters/{character_id}/contacts/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/contacts/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/contacts/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CharacterContact>>> CharacterContacts(int characterId, int page = 1);

        /// <summary>
        /// Bulk add contacts with same settings
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">IDs of the contacts to add</param>
        /// <param name="standing">Standing for the contact</param>
        /// <param name="labelIds">Add custom labels to the new contact</param>
        /// <param name="watched">Whether the contact should be watched, note this is only effective on characters. Default value : false</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.write_contacts.v1")]
        [Route("/latest/characters/{character_id}/contacts/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/contacts/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/contacts/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> AddCharacterContacts(int characterId, int[] contactIds, float standing, int[] labelIds = null, bool watched = false);

        /// <summary>
        /// Bulk edit contacts with same settings
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">IDs of the contacts to edit</param>
        /// <param name="standing">Standing for the contact</param>
        /// <param name="labelIds">Add custom labels to the new contact</param>
        /// <param name="watched">Whether the contact should be watched, note this is only effective on characters. Default value : false</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.write_contacts.v1")]
        [Route("/latest/characters/{character_id}/contacts/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/contacts/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/contacts/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> UpdateCharacterContacts(int characterId, int[] contactIds, float standing, int[] labelIds = null, bool watched = false);

        /// <summary>
        /// Return custom labels for a character’s contacts
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_contacts.v1")]
        [Route("/latest/alliances/{alliance_id}/contacts/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/contacts/labels/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/contacts/labels/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/contacts/labels/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ContactLabel>>> CharacterContactLabels(int characterId);

        /// <summary>
        /// Return contacts of a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_contacts.v1")]
        [Route("/latest/corporations/{corporation_id}/contacts/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/contacts/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/contacts/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CorporationContact>>> CorporationContacts(int corporationId, int page = 1);

        /// <summary>
        /// Return custom labels for a corporation’s contacts
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-corporations.read_contacts.v1")]
        [Route("/latest/corporations/{corporation_id}/contacts/labels/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/contacts/labels/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/contacts/labels/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/contacts/labels/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ContactLabel>>> CorporationContactLabels(int corporationId);
    }
}
