using System.Linq;
using System.Net.Http;

namespace EVEOnline.ESI.Communication
{
    public class EsiResponsePagination<T> : EsiResponse<T>
    {
        private readonly int _pages;

        public int Pages => _pages;

        public EsiResponsePagination(HttpResponseMessage response) : base(response)
        {
            if (response.Headers.Contains("X-Pages"))
            {
                _pages = int.Parse(response.Headers.GetValues("X-Pages").First());
            }
        }
    }
}
