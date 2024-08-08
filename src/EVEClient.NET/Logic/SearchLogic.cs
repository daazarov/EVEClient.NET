using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;

using static EVEClient.NET.Models.SearchRequests;

namespace EVEClient.NET.Logic
{
    internal class SearchLogic : ISearchLogic
    {
        private readonly IEsiHttpClient<ISearchLogic> _esiClient;

        public SearchLogic(IEsiHttpClient<ISearchLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<SearchResult>> Query(int characterId, string search, SearchCategory categories, bool strict = false, string? token = null) =>
            _esiClient.GetRequestAsync<SearchRequest, SearchResult>(SearchRequest.Create(characterId, search, categories.ToEsiString(), strict), token);
    }
}
