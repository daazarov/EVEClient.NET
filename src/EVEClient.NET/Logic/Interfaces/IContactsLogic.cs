using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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
        Task<EsiResponsePagination<List<AlianceContact>>> AllianceContacts(int allianceId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return custom labels for an alliance’s contacts
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        Task<EsiResponse<List<ContactLabel>>> AllianceContactLabels(int allianceId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk delete contacts
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">A list of contacts to delete</param>
        Task<EsiResponse> DeleteCharacterContacts(int characterId, int[] contactIds, string? token = null, CancellationToken cancellationToken = default);


        /// <summary>
        /// Return contacts of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        /// <returns></returns>
        Task<EsiResponsePagination<List<CharacterContact>>> CharacterContacts(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk add contacts with same settings
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">IDs of the contacts to add</param>
        /// <param name="standing">Standing for the contact</param>
        /// <param name="labelIds">Add custom labels to the new contact</param>
        /// <param name="watched">Whether the contact should be watched, note this is only effective on characters. Default value : false</param>
        Task<EsiResponse<List<int>>> AddCharacterContacts(int characterId, int[] contactIds, float standing, int[]? labelIds = null, bool watched = false, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk edit contacts with same settings
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">IDs of the contacts to edit</param>
        /// <param name="standing">Standing for the contact</param>
        /// <param name="labelIds">Add custom labels to the new contact</param>
        /// <param name="watched">Whether the contact should be watched, note this is only effective on characters. Default value : false</param>
        Task<EsiResponse> UpdateCharacterContacts(int characterId, int[] contactIds, float standing, int[]? labelIds = null, bool watched = false, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return custom labels for a character’s contacts
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<ContactLabel>>> CharacterContactLabels(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return contacts of a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<CorporationContact>>> CorporationContacts(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return custom labels for a corporation’s contacts
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<ContactLabel>>> CorporationContactLabels(int corporationId, string? token = null, CancellationToken cancellationToken = default);
    }
}
