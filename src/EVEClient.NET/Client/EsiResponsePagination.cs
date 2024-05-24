using System.Linq;
using System.Net.Http;

namespace EVEClient.NET
{
    public class EsiResponsePagination<T> : EsiResponse<T>
    {
        private readonly int _pages;

        public int Pages => _pages;

        // A future concept
        /*
        public int CurrentPage => _currentPage;
        public Func<Task<EsiResponsePagination<T>>> NextPage { get; }
        public Func<Task<EsiResponsePagination<T>>> PreviousPage { get; }
        */

        public EsiResponsePagination(HttpResponseMessage response) : base(response)
        {
            if (response.Headers.Contains("X-Pages"))
            {
                _pages = int.Parse(response.Headers.GetValues("X-Pages").First());
            }
        }
    }
}
