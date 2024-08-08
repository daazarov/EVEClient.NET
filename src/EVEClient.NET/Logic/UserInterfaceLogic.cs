using System.Threading.Tasks;

using static EVEClient.NET.Models.UserInterfaceRequests;

namespace EVEClient.NET.Logic
{
    internal class UserInterfaceLogic : IUserInterfaceLogic
    {
        private readonly IEsiHttpClient<IUserInterfaceLogic> _esiClient;

        public UserInterfaceLogic(IEsiHttpClient<IUserInterfaceLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse> OpenContractWindow(int contractId, string? token = null) =>
            _esiClient.PostNoContentRequestAsync(OpenContractWindowRequest.Create(contractId), token);

        public Task<EsiResponse> OpenInformationWindow(int targetId, string? token = null) =>
            _esiClient.PostNoContentRequestAsync(OpenInformationWindowRequest.Create(targetId), token);

        public Task<EsiResponse> OpenMarketDetails(int typeId, string? token = null) =>
            _esiClient.PostNoContentRequestAsync(OpenMarketDetailsRequest.Create(typeId), token);

        public Task<EsiResponse> OpenNewMailWindow(string subject, string body, int[] recipients, int? toCorpOrAllianceId = null, int? toMailingListId = null, string? token = null) =>
            _esiClient.PostNoContentRequestAsync(OpenNewMailWindowBodyRequest.Create(body, subject, recipients, toCorpOrAllianceId, toMailingListId), token);

        public Task<EsiResponse> SetAutopilotWaypoint(long destinationId, bool addToBeginning = false, bool clearOtherWaypoints = false, string? token = null) =>
            _esiClient.PostNoContentRequestAsync(SetAutopilotWaypointRequest.Create(destinationId, addToBeginning, clearOtherWaypoints), token);
    }
}
