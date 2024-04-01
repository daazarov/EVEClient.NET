using System;
using System.Linq;
using System.Net.Http;

namespace EVEOnline.ESI.Communication
{
    public class EsiResponsePagination<T> : EsiResponse<T>
    {
        private readonly int _pages;

        public int Pages => _pages;

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
    }
}
