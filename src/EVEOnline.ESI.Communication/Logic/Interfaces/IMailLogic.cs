using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IMailLogic
    {
        /// <summary>
        /// Return the 50 most recent mail headers belonging to the character that match the query criteria.
        /// Queries can be filtered by label, and last_mail_id can be used to paginate backwards
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="labels">Fetch only mails that match one or more of the given labels</param>
        /// <param name="lastMailId">List only mail with an ID lower than the given ID, if present</param>
        [ProtectedEndpoint(RequiredScope = "esi-mail.read_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mail/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/mail/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Header>>> GetCharacterMailHeaders(int characterId, int[] labels = null, int? lastMailId = null);

        /// <summary>
        /// Create and send a new mail
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mail">The mail to send</param>
        /// <returns>New mail ID</returns>
        [ProtectedEndpoint(RequiredScope = "esi-mail.send_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mail/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/mail/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<int>> SendMail(int characterId, NewMail mail);

        /// <summary>
        /// Delete a mail
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-mail.organize_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> DeleteMail(int characterId, int mailId);

        /// <summary>
        /// Return the contents of an EVE mail
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-mail.read_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Message>> GetMail(int characterId, int mailId);

        /// <summary>
        /// Update metadata about a mail
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        /// <param name="labels">Labels to assign to the mail. Pre-existing labels are unassigned. Optional.</param>
        /// <param name="reed">Whether the mail is flagged as read. Optional.</param>
        [ProtectedEndpoint(RequiredScope = "esi-mail.organize_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/{mail_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> UpdateMail(int characterId, int mailId, int[] labels, bool? read);

        /// <summary>
        /// Return a list of the users mail labels, unread counts for each label and a total unread count.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-mail.read_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/labels/", Version = EndpointVersion.Latest)]
        [Route("/v3/characters/{character_id}/mail/labels/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/labels/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<LabelCounts>> GetCharacterMailLabels(int characterId);

        /// <summary>
        /// Create a mail label
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="name">Label name</param>
        /// <param name="color">Hexadecimal string representing label color, in RGB format</param>
        /// <returns>New lable ID</returns>
        [ProtectedEndpoint(RequiredScope = "esi-mail.organize_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/labels/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mail/labels/", Version = EndpointVersion.Legacy)]
        [Route("/v2/characters/{character_id}/mail/labels/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/labels/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<int>> NewMailLabel(int characterId, string name, LabelColor color = LabelColor.White);

        /// <summary>
        /// Delete a mail label
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>>
        /// <param name="labelId">An EVE label id</param>
        [ProtectedEndpoint(RequiredScope = "esi-mail.organize_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/labels/{label_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mail/labels/{label_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/mail/labels/{label_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/labels/{label_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> DeleteLabel(int characterId, int labelId);

        /// <summary>
        /// Return all mailing lists that the character is subscribed to
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>>
        [ProtectedEndpoint(RequiredScope = "esi-mail.read_mail.v1")]
        [Route("/latest/characters/{character_id}/mail/lists/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/mail/lists/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/mail/lists/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/mail/lists/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<MailingList>>> GetCharacterMailingList(int characterId);
    }
}
