using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;
using EVEOnline.ESI.Communication.Models;

using static EVEOnline.ESI.Communication.Models.MailRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class MailLogic : IMailLogic
    {
        private readonly IEsiHttpClient<IMailLogic> _esiClient;

        public MailLogic(IEsiHttpClient<IMailLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Header>>> GetCharacterMailHeaders(int characterId, int[] labels = null, int? lastMailId = null) =>
            _esiClient.GetRequestAsync<GetMailHeaderseRequest, List<Header>>(GetMailHeaderseRequest.Create(characterId, labels, lastMailId));

        public Task<EsiResponse<int>> SendMail(int characterId, NewMail mail) =>
            _esiClient.PostRequestAsync<NewMailRequest, int>(NewMailRequest.Create(characterId, NewMailBodyModel.FromDataContractModel(mail)));

        public Task<EsiResponse> DeleteMail(int characterId, int mailId) =>
            _esiClient.DeleteRequestAsync<GetDeleteMailRequest>(GetDeleteMailRequest.Create(characterId, mailId));

        public Task<EsiResponse<Message>> GetMail(int characterId, int mailId) =>
            _esiClient.GetRequestAsync<GetDeleteMailRequest, Message>(GetDeleteMailRequest.Create(characterId, mailId));

        public Task<EsiResponse> UpdateMail(int characterId, int mailId, int[] labels, bool? read) =>
            _esiClient.PutRequestAsync<UpdateMailRequest>(UpdateMailRequest.Create(characterId, mailId, labels, read));

        public Task<EsiResponse<LabelCounts>> GetCharacterMailLabels(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, LabelCounts>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<int>> NewMailLabel(int characterId, string name, LabelColor color = LabelColor.White) =>
            _esiClient.PostRequestAsync<NewLabelRequest, int>(NewLabelRequest.Create(characterId, color.ToEsiString(), name));

        public Task<EsiResponse> DeleteLabel(int characterId, int labelId) =>
            _esiClient.DeleteRequestAsync<DeleteLabelRequest>(DeleteLabelRequest.Create(characterId, labelId));

        public Task<EsiResponse<List<MailingList>>> GetCharacterMailingList(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<MailingList>>(CharacterIdRouteRequest.Create(characterId));
    }
}
