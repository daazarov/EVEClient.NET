using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.Configuration;
using EVEOnline.ESI.Communication.Models;
using EVEOnline.ESI.Communication.Extensions;
using EVEOnline.ESI.Communication.Utilities;

namespace EVEOnline.ESI.Communication.Handlers
{
    public class UrlRequestParametersHandler : IHandler
    {
        private readonly IOptionsMonitor<EsiClientConfiguration> _options;
        
        public UrlRequestParametersHandler(IOptionsMonitor<EsiClientConfiguration> options) 
        {
            _options = options;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var routeModel = context.RequestModel as IRoteModel;

            context.RequestContext.QueryParametersMap.Merge(InitializeDefaultQueryParameters);

            if (routeModel != null)
            {
                context.RequestContext.RouteParametersMap.Merge(() => PrepareRouteKeyPairValues(routeModel));
                context.RequestContext.QueryParametersMap.Merge(() => PrepareQueryKeyPairValues(routeModel));
            }
            
            await next.Invoke(context);
        }

        protected virtual Dictionary<string, string> PrepareRouteKeyPairValues(IRoteModel routeModel)
        {
            return GetUrlParameters<RouteParameterAttribute>(routeModel.QueryRoute);
        }

        protected virtual Dictionary<string, string> PrepareQueryKeyPairValues(IRoteModel routeModel)
        {
            return GetUrlParameters<QueryParameterAttribute>(routeModel.QueryRoute);
        }

        private Dictionary<string, string> GetUrlParameters<T>(object model) where T : UrlParameterAttribute
        {
            var type = model.GetType();
            var propsInfo = type.GetProperties();
            var result = new Dictionary<string, string>();

            foreach (var prop in propsInfo)
            {
                var attribute = ReflectionCacheAttributeAccessor.Instance.GetAttribute<T>(prop);

                if (attribute != null)
                {
                    var getter = DynamicMethodPropertyGetAccessor.Instance.CreateGet<object>(prop);
                    var value = getter(model);

                    if (value != null)
                    {
                        result.Add(attribute.ParameterName, (string)value);
                    }
                }
            }

            return result.Count > 0 ? result : null;
        }

        private Dictionary<string, string> InitializeDefaultQueryParameters()
        {
            return new Dictionary<string, string>()
            {
                { "datasource", _options.CurrentValue.Server }
            };
        }
    }
}
