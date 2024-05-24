using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.WarsRequests;

namespace EVEClient.NET.Logic
{
    internal class WarsLogic : IWarsLogic
    {
        private readonly IEsiHttpClient<IWarsLogic> _esiClient;

        public WarsLogic(IEsiHttpClient<IWarsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<Kill>>> Kills(int warId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<KillsRequest, List<Kill>>(KillsRequest.Create(warId, page));

        public Task<EsiResponse<War>> WarDetails(int warId) =>
            _esiClient.GetRequestAsync<WarDetailsRequest, War>(WarDetailsRequest.Create(warId));

        public Task<EsiResponse<List<int>>> Wars(int? maxWarId) =>
            _esiClient.GetRequestAsync<WarsRequest, List<int>>(WarsRequest.Create(maxWarId));
    }
}
