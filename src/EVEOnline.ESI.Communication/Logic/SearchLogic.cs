using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;

using static EVEOnline.ESI.Communication.Models.SearchRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class SearchLogic : ISearchLogic
    {
        private readonly IEsiHttpClient<ISearchLogic> _esiClient;

        public SearchLogic(IEsiHttpClient<ISearchLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<SearchResult>> Query(int characterId, string search, SearchCategory categories, bool strict = false) =>
            _esiClient.GetRequestAsync<SearchRequest, SearchResult>(SearchRequest.Create(characterId, search, categories.ToEsiString(), strict));
    }
}
