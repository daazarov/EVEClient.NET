using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Prepares the body of the Post and Put requests.
    /// </summary>
    public class BodyRequestParametersHandler : IHandler
    {
        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            if (context.Request.Parameters.Body is not null)
            {
                context.Request.Content = CreateHttpContent(context.Request.Parameters.Body);
            }

            await next.Invoke(context);
        }

        protected virtual HttpContent? CreateHttpContent(object bodyModel)
        { 
            return new StringContent(JsonConvert.SerializeObject(bodyModel));
        }
    }
}
