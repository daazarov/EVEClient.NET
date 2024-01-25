﻿using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.Attributes;
using EVEOnline.Esi.Communication.Configuration;
using EVEOnline.Esi.Communication.DataContract.Requests.Internal;
using EVEOnline.Esi.Communication.Extensions;
using EVEOnline.Esi.Communication.Utilities;
using Microsoft.Extensions.Options;

namespace EVEOnline.Esi.Communication.Handlers
{
    internal class UrlRequestParametersHandler : IHandler
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
                context.RequestContext.RouteParametersMap.Merge(() => GetUrlParameters<RouteParameterAttribute>(routeModel.QueryRoute));
                context.RequestContext.QueryParametersMap.Merge(() => GetUrlParameters<QueryParameterAttribute>(routeModel.QueryRoute));
            }
            
            await next.Invoke(context);
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
                    var value = ReflectionUtils.GetPropertyValueDelegate<string>(type, prop.Name).Invoke(model);
                    if (!string.IsNullOrEmpty(value))
                    {
                        result.Add(attribute.ParameterName, value);
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
