using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class SearchLogic : ISearchLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public SearchLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<SearchResult>> Query(int characterId, string search, SearchCategory categories, bool strict = false, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Search] = search;
                    parameters.Query[ESI.Parameters.Query.SearchCategories] = categories.ToEsiString();
                    parameters.Query[ESI.Parameters.Query.SearchStrict] = strict.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Search.Query, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<SearchResult>();
        }
    }
}
