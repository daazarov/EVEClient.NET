using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract.Requests.Internal;

namespace EVEOnline.Esi.Communication.Handlers
{
    internal class BodyRequestParametersHandler : IHandler
    {
        private readonly JsonSerializerOptions _options;

        public BodyRequestParametersHandler(JsonSerializerOptions options = null) 
        {
            _options = options;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var bodyRequestModel = context.RequestModel as IBodyModel;

            if (bodyRequestModel != null) 
            {
                context.RequestContext.Body = JsonContent.Create(bodyRequestModel.Body, mediaType: null, _options);
            }

            await next.Invoke(context);
        }
    }
}
