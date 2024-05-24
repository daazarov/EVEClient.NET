using System.Net.Http;
using System.Threading.Tasks;

using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    public abstract class RequestBaseHandler : IHandler
    {
        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var response = await ExecuteRequestAsync(context.RequestContext.RequestUrl, context).ConfigureAwait(false);
            context.SetHttpResponseMessage(response);
            await next.Invoke(context);
        }

        protected abstract Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context);
    }

    public class RequestPutHandler : RequestBaseHandler
    {
        protected override Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context)
        {
            return context.HttpClient.PutAsync(url, context.RequestContext.Body);
        }
    }

    public class RequestPostHandler : RequestBaseHandler
    {
        protected override Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context)
        {
            return context.HttpClient.PostAsync(url, context.RequestContext.Body);
        }
    }

    public class RequestGetHandler : RequestBaseHandler
    {
        protected override Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context)
        {
            return context.HttpClient.GetAsync(url);
        }
    }

    public class RequestDeleteHandler : RequestBaseHandler
    {
        protected override Task<HttpResponseMessage> ExecuteRequestAsync(string url, EsiContext context)
        {
            return context.HttpClient.DeleteAsync(url);
        }
    }
}
