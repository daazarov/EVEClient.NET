using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EVEOnline.ESI.Communication.Extensions;

namespace EVEOnline.ESI.Communication.Handlers
{
    internal abstract class RequestBaseHandler : IHandler
    {
        private readonly HttpStatusCode[] _unacceptableHttpStatusCodes = new HttpStatusCode[]
        {
            HttpStatusCode.NotFound,
            HttpStatusCode.InternalServerError,
            HttpStatusCode.ServiceUnavailable,
            HttpStatusCode.RequestTimeout,
            HttpStatusCode.NotImplemented,
            HttpStatusCode.GatewayTimeout,
            HttpStatusCode.BadGateway
        };

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            HttpResponseMessage response = null;

            do
            {
                if (TryGetNextUrl(context, out var url))
                {
                    response = await ExecuteRequestAsync(url, context).ConfigureAwait(false);
                }
                else
                {
                    break;
                }
            }
            while (response.StatusCode.In(_unacceptableHttpStatusCodes));

            context.SetHttpResponseMessage(response);

            await next.Invoke(context);
        }

        protected abstract Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context);

        private bool TryGetNextUrl(EsiContext context, out string url)
        {
            return context.RequestContext.RouteQueue.TryGetNextRoute(out url);
        }
    }

    internal class RequestPutHandler : RequestBaseHandler
    {
        protected override Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context)
        {
            return context.HttpClient.PutAsync(url, context.RequestContext.Body);
        }
    }

    internal class RequestPostHandler : RequestBaseHandler
    {
        protected override Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context)
        {
            return context.HttpClient.PostAsync(url, context.RequestContext.Body);
        }
    }

    internal class RequestGetHandler : RequestBaseHandler
    {
        protected override Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context)
        {
            return context.HttpClient.GetAsync(url);
        }
    }

    internal class RequestDeleteHandler : RequestBaseHandler
    {
        protected override Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context)
        {
            return context.HttpClient.DeleteAsync(url);
        }
    }
}
