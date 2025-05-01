using System.Collections.Generic;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class MailLogic : IMailLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public MailLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<Header>>> MailHeaders(int characterId, int[]? labels = null, int? lastMailId = null, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Query.LastMailId] = lastMailId.ToString();
                    parameters.Route[ESI.Parameters.Query.Labels] = labels.ToQueryArrayParameterValue();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.MailHeaders, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Header>>();
        }

        public async Task<EsiResponse<int>> SendMail(int characterId, NewMail mail, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Body = mail;
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.SendMail, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<int>();
        }

        public async Task<EsiResponse> DeleteMail(int characterId, int mailId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.MailId] = mailId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.DeleteMail, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse<Message>> GetMail(int characterId, int mailId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.MailId] = mailId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.GetMail, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Message>();
        }

        public async Task<EsiResponse> UpdateMail(int characterId, int mailId, int[]? labels, bool? read, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.MailId] = mailId.ToString();
                    parameters.Body = GenerateBody(labels, read);
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.UpdateMail, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();

            static object GenerateBody(int[]? labels, bool? read)
            {
                dynamic obj = new ExpandoObject();
                var dict = (IDictionary<string, object?>)obj;

                if (labels != null)
                    dict["labels"] = labels;

                if (read != null)
                    dict["read"] = read;

                return obj;
            }
        }

        public async Task<EsiResponse<LabelCounts>> GetLabels(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.GetLabels, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<LabelCounts>();
        }

        public async Task<EsiResponse<int>> NewMailLabel(int characterId, string name, LabelColor color = LabelColor.White, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Body = new
                    {
                        color = color.ToEsiString(),
                        name
                    };
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.CreateLabel, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<int>();
        }

        public async Task<EsiResponse> DeleteLabel(int characterId, int labelId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.LabelId] = labelId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.DeleteLabel, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<LabelCounts>();
        }

        public async Task<EsiResponse<List<MailingList>>> MailingList(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Mail.MailingList, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<MailingList>>();
        }
    }
}
