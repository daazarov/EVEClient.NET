using EVEOnline.ESI.Communication.Extensions;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace EVEOnline.ESI.Communication
{
    public class EsiResponse<T> : EsiResponse
    {
        private readonly T _data;

        public T Data => _data;

        public EsiResponse(Exception exception) : base(exception)
        {}

        public EsiResponse(HttpResponseMessage response) : base(response)
        {
            try 
            {
                if (response.StatusCode.In(HttpStatusCode.OK, HttpStatusCode.Created))
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    if ((result.StartsWith("{") && result.EndsWith("}")) || 
                         result.StartsWith("[") && result.EndsWith("]"))
                    {
                        _data = JsonConvert.DeserializeObject<T>(result);
                    }
                    else
                    {
                        try
                        {
                            _data = (T)Convert.ChangeType(result, typeof(T));
                        }
                        catch { }  
                    }   
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
