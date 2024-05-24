using System;
using System.Net;
using System.Net.Http;

using EVEClient.NET.Extensions;

using Newtonsoft.Json;

namespace EVEClient.NET
{
    public class EsiResponse<T> : EsiResponse
    {
        private readonly T _data;

        public T Data => _data;

        public EsiResponse(HttpResponseMessage response) : base(response)
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
    }
}
