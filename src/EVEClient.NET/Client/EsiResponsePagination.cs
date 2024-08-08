using System.Linq;
using System.Net.Http;

namespace EVEClient.NET
{
    public class EsiResponsePagination<T> : EsiResponse<T>
    {
        /// <summary>
        /// Gets the total count of pages.
        /// </summary>
        public int Pages { get; }

        // A future concept
        /*
        public int CurrentPage => _currentPage;
        public Func<Task<EsiResponsePagination<T>>> NextPage { get; }
        public Func<Task<EsiResponsePagination<T>>> PreviousPage { get; }
        public Func<int, Task<EsiResponsePagination<T>>> SpecificPage { get; }
        */

        public EsiResponsePagination(HttpResponseMessage response) : base(response)
        {
            if (response.Headers.Contains("X-Pages"))
            {
                Pages = int.Parse(response.Headers.GetValues("X-Pages").First());
            }
        }
    }
}
