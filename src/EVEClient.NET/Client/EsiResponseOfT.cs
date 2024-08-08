using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;

using EVEClient.NET.Extensions;

using Newtonsoft.Json;

namespace EVEClient.NET
{
    public class EsiResponse<T> : EsiResponse
    {
        /// <summary>
        /// Gets the deserialized response data.
        /// </summary>
        public T? Data { get; }

        /// <summary>
        /// Gets a value that indicates if the HTTP request to the EVE ESI was successfull.
        /// </summary>
        [MemberNotNullWhen(true, nameof(Data))]
        public new bool Success => base.Success;

        public EsiResponse(HttpResponseMessage response) : base(response)
        {
            if (response.StatusCode.In(HttpStatusCode.OK, HttpStatusCode.Created))
            {
                var result = response.Content.ReadAsStringAsync().Result;

                try
                {
                    if ((result.StartsWith("{") && result.EndsWith("}")) ||
                         result.StartsWith("[") && result.EndsWith("]"))
                    {
                        Data = JsonConvert.DeserializeObject<T>(result);
                    }
                    else
                    {
                        Data = (T)Convert.ChangeType(result, typeof(T));
                    }
                }
                catch
                {
                    if (Errors == null)
                    {
                        Errors = new List<string>();
                    }

                    Errors.Add($"Failed to deserializa response data to the model. Model type: {typeof(T).Name}; Response data: {result}");
                }
            }
        }
    }
}
