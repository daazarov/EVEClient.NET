using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Models;

namespace EVEOnline.ESI.Communication.Handlers
{
    internal class BodyRequestParametersHandler : IHandler
    {
        private readonly JsonSerializerOptions _options;

        public BodyRequestParametersHandler() : this(new JsonSerializerOptions())
        { }

        public BodyRequestParametersHandler(JsonSerializerOptions options) 
        {
            _options = options;

            _options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
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
