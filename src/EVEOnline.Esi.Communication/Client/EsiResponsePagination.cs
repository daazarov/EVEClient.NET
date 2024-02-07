using System;
using System.Linq;
using System.Net.Http;

namespace EVEOnline.ESI.Communication
{
    public class EsiResponsePagination<T> : EsiResponse<T>
    {
        private readonly int _pages;
        private readonly string _nextPageUrl;
        private readonly string _previousPageUrl;

        public int Pages => _pages;
        public string NextPageUrl => _nextPageUrl;
        public string PreviousPageUrl => _previousPageUrl;

        public EsiResponsePagination(Exception exception) : base(exception)
        { }

        public EsiResponsePagination(HttpResponseMessage response) : base(response)
        {
            try 
            {
                if (response.Headers.Contains("X-Pages"))
                {
                    _pages = int.Parse(response.Headers.GetValues("X-Pages").First());
                }

                if (response.RequestMessage != null &&
                    response.RequestMessage.Options.Any(x => x.Key.Equals("page", StringComparison.OrdinalIgnoreCase)))
                {
                    _nextPageUrl = BuildNexPageUrl(response.RequestMessage);
                    _previousPageUrl = BuildPreviosPageUrl(response.RequestMessage);
                }
            }
            catch (Exception ex)
            {
                if (base._exception != null)
                {
                    base._exception = new Exception(ex.Message, ex);
                }
                else
                {
                    base._exception = ex;
                }
            }
        }

        private string BuildNexPageUrl(HttpRequestMessage request)
        {
            var currentPage = GetCurrentPageNumber(request);

            if (!currentPage.HasValue)
            {
                return String.Empty;
            }

            if (currentPage >= Pages)
            {
                return String.Empty;
            }

            var newPathAndQuery = request.RequestUri?.PathAndQuery.Replace($"page={currentPage}", $"page={currentPage++}");

            return newPathAndQuery ?? String.Empty;
        }

        private string BuildPreviosPageUrl(HttpRequestMessage request)
        {
            var currentPage = GetCurrentPageNumber(request);

            if (!currentPage.HasValue)
            { 
                return String.Empty;
            }

            if (currentPage <= 0)
            {
                return String.Empty;
            }

            var newPathAndQuery = request.RequestUri?.PathAndQuery.Replace($"page={currentPage}", $"page={currentPage--}");

            return newPathAndQuery ?? String.Empty;
        }

        private int? GetCurrentPageNumber(HttpRequestMessage request)
        {
            var currentPageText = request.Options
                    .FirstOrDefault(x => x.Key.Equals("page", StringComparison.OrdinalIgnoreCase)).Value?.ToString();

            if (string.IsNullOrEmpty(currentPageText))
            {
                return null;
            }

            return int.Parse(currentPageText);
        }
    }
}
