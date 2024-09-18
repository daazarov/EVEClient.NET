using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace EVEClient.NET
{
    [Obsolete("EsiResponsePagination<T> will be replaced by EsiResponse<T> in the near future. " +
        "Make sure you don't use an explicit EsiResponsePagination type when creating variables, otherwise replace the declaration with \"var\" usage.")]
    public class EsiResponsePagination<T> : EsiResponseDefaultGeneric<T>
    {
        /// <summary>
        /// Gets the total count of pages.
        /// </summary>
        [Obsolete("The Pages propery is obsolete. Use TotalPages property instead.")]
        public int Pages { get; }

        public override bool Success => base.Success || StatusCode == HttpStatusCode.NotModified;

        public EsiResponsePagination(HttpResponseMessage response) : base(response)
        {
            if (response.Headers.Contains("X-Pages"))
            {
                Pages = int.Parse(response.Headers.GetValues("X-Pages").First());
            }
        }
    }
}
