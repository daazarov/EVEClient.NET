using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Models;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.MailRequests;

namespace EVEClient.NET.Logic
{
    internal class MailLogic : IMailLogic
    {
        private readonly IEsiHttpClient<IMailLogic> _esiClient;

        public MailLogic(IEsiHttpClient<IMailLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Header>>> MailHeaders(int characterId, int[]? labels = null, int? lastMailId = null, string? token = null) =>
            _esiClient.GetRequestAsync<GetMailHeaderseRequest, List<Header>>(GetMailHeaderseRequest.Create(characterId, labels, lastMailId), token);

        public Task<EsiResponse<int>> SendMail(int characterId, NewMail mail, string? token = null) =>
            _esiClient.PostRequestAsync<NewMailRequest, int>(NewMailRequest.Create(characterId, NewMailBodyModel.FromDataContractModel(mail)), token);

        public Task<EsiResponse> DeleteMail(int characterId, int mailId, string? token = null) =>
            _esiClient.DeleteRequestAsync<GetDeleteMailRequest>(GetDeleteMailRequest.Create(characterId, mailId), token);

        public Task<EsiResponse<Message>> GetMail(int characterId, int mailId, string? token = null) =>
            _esiClient.GetRequestAsync<GetDeleteMailRequest, Message>(GetDeleteMailRequest.Create(characterId, mailId), token);

        public Task<EsiResponse> UpdateMail(int characterId, int mailId, int[]? labels, bool? read, string? token = null) =>
            _esiClient.PutRequestAsync<UpdateMailRequest>(UpdateMailRequest.Create(characterId, mailId, labels, read), token);

        public Task<EsiResponse<LabelCounts>> GetLabels(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, LabelCounts>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<int>> NewMailLabel(int characterId, string name, LabelColor color = LabelColor.White, string? token = null) =>
            _esiClient.PostRequestAsync<NewLabelRequest, int>(NewLabelRequest.Create(characterId, color.ToEsiString(), name), token);

        public Task<EsiResponse> DeleteLabel(int characterId, int labelId, string? token = null) =>
            _esiClient.DeleteRequestAsync<DeleteLabelRequest>(DeleteLabelRequest.Create(characterId, labelId), token);

        public Task<EsiResponse<List<MailingList>>> MailingList(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<MailingList>>(CharacterIdRouteRequest.Create(characterId), token);
    }
}
