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

        public Task<EsiResponse> OpenContractWindow(int contractId) =>
            _esiClient.PostNoContentRequestAsync(OpenContractWindowRequest.Create(contractId));

        public Task<EsiResponse> OpenInformationWindow(int targetId) =>
            _esiClient.PostNoContentRequestAsync(OpenInformationWindowRequest.Create(targetId));

        public Task<EsiResponse> OpenMarketDetails(int typeId) =>
            _esiClient.PostNoContentRequestAsync(OpenMarketDetailsRequest.Create(typeId));

        public Task<EsiResponse> OpenNewMailWindow(string subject, string body, int[] recipients, int? toCorpOrAllianceId = null, int? toMailingListId = null) =>
            _esiClient.PostNoContentRequestAsync(OpenNewMailWindowBodyRequest.Create(body, subject, recipients, toCorpOrAllianceId, toMailingListId));

        public Task<EsiResponse> SetAutopilotWaypoint(long destinationId, bool addToBeginning = false, bool clearOtherWaypoints = false) =>
            _esiClient.PostNoContentRequestAsync(SetAutopilotWaypointRequest.Create(destinationId, addToBeginning, clearOtherWaypoints));
    }
}
