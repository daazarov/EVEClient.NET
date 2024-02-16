using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using EVEOnline.ESI.Communication.Models;

namespace EVEOnline.ESI.Communication.Handlers
{
    public class BodyRequestParametersHandler : IHandler
    {
        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var bodyRequestModel = context.RequestModel as IBodyModel;

            if (bodyRequestModel != null) 
            {
                context.RequestContext.Body = CreateHttpContent(bodyRequestModel.Body);
            }

            await next.Invoke(context);
        }

        protected virtual HttpContent? CreateHttpContent(object bodyModel)
        { 
            return new StringContent(JsonConvert.SerializeObject(bodyModel));
        }
    }
}
