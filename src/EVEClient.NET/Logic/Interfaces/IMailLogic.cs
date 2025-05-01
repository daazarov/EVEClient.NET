using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
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
        Task<EsiResponse<List<Header>>> MailHeaders(int characterId, int[]? labels = null, int? lastMailId = null, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create and send a new mail
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mail">The mail to send</param>
        /// <returns>New mail ID</returns>
        Task<EsiResponse<int>> SendMail(int characterId, NewMail mail, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a mail
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        Task<EsiResponse> DeleteMail(int characterId, int mailId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return the contents of an EVE mail
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        Task<EsiResponse<Message>> GetMail(int characterId, int mailId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update metadata about a mail
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        /// <param name="labels">Labels to assign to the mail. Pre-existing labels are unassigned. Optional.</param>
        /// <param name="reed">Whether the mail is flagged as read. Optional.</param>
        Task<EsiResponse> UpdateMail(int characterId, int mailId, int[]? labels, bool? read, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of the users mail labels, unread counts for each label and a total unread count.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<LabelCounts>> GetLabels(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a mail label
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="name">Label name</param>
        /// <param name="color">Hexadecimal string representing label color, in RGB format</param>
        /// <returns>New lable ID</returns>
        Task<EsiResponse<int>> NewMailLabel(int characterId, string name, LabelColor color = LabelColor.White, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a mail label
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>>
        /// <param name="labelId">An EVE label id</param>
        Task<EsiResponse> DeleteLabel(int characterId, int labelId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return all mailing lists that the character is subscribed to
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>>
        Task<EsiResponse<List<MailingList>>> MailingList(int characterId, string? token = null, CancellationToken cancellationToken = default);
    }
}
