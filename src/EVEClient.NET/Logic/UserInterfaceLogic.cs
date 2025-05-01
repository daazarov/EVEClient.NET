using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class UserInterfaceLogic : IUserInterfaceLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public UserInterfaceLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse> OpenContractWindow(int contractId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Query[ESI.Parameters.Query.ContractId] = contractId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.UserInterface.OpenContractWindow, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> OpenInformationWindow(int targetId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Query[ESI.Parameters.Query.TargetId] = targetId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.UserInterface.OpenInformationWindow, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> OpenMarketDetails(int typeId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Query[ESI.Parameters.Query.ItemTypeId] = typeId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.UserInterface.OpenMarketDetails, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> OpenNewMailWindow(string subject, string body, int[] recipients, int? toCorpOrAllianceId = null, int? toMailingListId = null, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Body = new OpenNewMailWindowBodyModel
                    {
                        Subject = subject,
                        Body = body,
                        Recipients = recipients,
                        ToCorpOrAllianceId = toCorpOrAllianceId,
                        ToMailingListId = toMailingListId
                    };
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.UserInterface.OpenNewMailWindow, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> SetAutopilotWaypoint(long destinationId, bool addToBeginning = false, bool clearOtherWaypoints = false, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Query[ESI.Parameters.Query.WaypointDestinationId] = destinationId.ToString();
                    parameters.Query[ESI.Parameters.Query.WaypointAddToBeginning] = addToBeginning.ToString();
                    parameters.Query[ESI.Parameters.Query.WaypointClearOtherWaypoints] = clearOtherWaypoints.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.UserInterface.SetAutopilotWaypoint, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        private class OpenNewMailWindowBodyModel
        {
            [JsonPropertyName("body")]
            public required string Body { get; set; }

            [JsonPropertyName("subject")]
            public required string Subject { get; set; }

            [JsonPropertyName("recipients")]
            public required int[] Recipients { get; set; }

            [JsonPropertyName("to_corp_or_alliance_id")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public int? ToCorpOrAllianceId { get; set; }

            [JsonPropertyName("to_mailing_list_id")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public int? ToMailingListId { get; set; }
        }
    }
}
