[![Build Status](https://github.com/daazarov/EVEClient.NET/actions/workflows/ci.yml/badge.svg?branch=main&event=push)](https://github.com/daazarov/EVEClient.NET/actions/workflows/ci.yml)

## About EVEClient.NET

EVEOnline.ESI is a wrapper over the [`ESI API`](https://esi.evetech.net/ui/) based on a [middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/index/_static/request-delegate-pipeline.png?view=aspnetcore-8.0) approach. The middleware works on the pipline principle in ASP.NET Core and allows you to add/modify the behavior of request generation and response processing.

EVEClient.NET includes following default ordered middlewares:

- `ProtectionHandler` - Performs getting the access token from `IAccessTokenProvider`, validates scope, and sets the Authorization header
- `RequestHeadersHandler` - Configures the default headers for the request.
- `UrlRequestParametersHandler` - Prepares a list of parameters to be passed and replaced in the URL template.
- `BodyRequestParametersHandler` - (only for POST & PUT requests) - Prepares the body of the request.
- `EndpointHandler` - Prepares a ready URL for sending the request.
- `ETagHandler` - Used when the setting "UseETag" is enabled. Stores the eTag value for a particular request in internal storage and applies it to the next request.
- `RequestGetHandler` or `RequestPostHandler` or `RequestDeleteHandler` or `RequestPutHandler` - Make a request to API

## Limitations

1. EVEClient.NET currently has no built-in functionality to work in ESI SSO. You need to implement your own token provider using the provided interface `IAccessTokenProvider`.
In the future it is planned to write a separate library for ASP.NET Core, which will provide native authorization support.
2. EVEClient.NET uses ENDPOINT VERSIONING according to best practices (see [more](https://developers.eveonline.com/blog/article/esi-endpoint-versioning-important-info-and-best-practices)). At the moment there is no way to choose a different route (e.g. legacy/latest or dev) except to override the EndpointHandler in pipline. But in the future, we plan to provide this feature in separate package along with repeat customization. I don't know why it might be necessary :sweat_smile:

## NuGet Packages

| **Package** | **Latest Version** | **About** |
|:--|:--|:--|
| `EVEClient.NET` | [![NuGet](https://buildstats.info/nuget/EVEClient.NET)](https://buildstats.info/nuget/EVEClient.NET "Download EVEClient.NET from NuGet.org") | The core functionality to communicate with [`ESI API`](https://esi.evetech.net/ui/). |
| `EVEClient.NET.Polly` | Coming Soon... | Integration with [`Polly`](https://www.nuget.org/packages/Polly/) APIs to provide a repeat function and selection of alternative routes. |
| `EVEClient.NET.Identity` | Coming Soon... | OAuth 2.0 framework for ASP.NET Core to provide out-of-the-box functionality for EVE SSO authorization. |

## Quick start

### General

To use the library, you need to invoke the extension method for `IServiceCollection`.

<!-- snippet: quick-start -->
```cs
_serviceCollection.AddEVEOnlineEsiClient(config =>
{
    // Required property. Header in your client which includes the source of the request and contact information.
    // This way, CCP can identify and help you with issues if you’re banned.
    config.UserAgent = "agent name";
    // If you want to use the eTag functionality for less ESI API server load.
    // 304 http status code will be returned on a second request as long as the data on the server is cached and has not been changed 
    config.EnableETag = true; // 
})
.UseAccessTokenProvider<YourAccessTokenProvider>();
```
<!-- endSnippet -->

After that you can inject IEsiLogicAccessor or specific logic interface directly.

```cs
public class AccountController : Controller
{
    private readonly IEsiLogicAccessor _esiLogicAccessor;
    private readonly ICharacterLogic _characterLogic;

    public AccountController(IEsiLogicAccessor esiLogicAccessor, ICharacterLogic characterLogic)
    { 
        _esiLogicAccessor = esiLogicAccessor;
        _characterLogic = characterLogic;
    }
	
    public async Task<IActionResult> Index()
    {
        var characterInfo = await _characterLogic.PublicInformation(65151651651);
        var orders = await _esiLogicAccessor.MarketLogic.CharacterOrders(65151651651);
	...
    }
}
```

### Customizations

For example, you don't want to return a 304 http status code when using ETag, but rather return cached data from your local storage. 

To do this, create a new handler, which will then be connected to the existing pipelines.

```cs
internal class CustomHandler : IHandler
{
    // Your custom cache
    private readonly IResponseCache _cache;
    
    public CustomHandler(IResponseCache cache)
    { 
        _cache = cache;
    }

    public async Task HandleAsync(EsiContext context, RequestDelegate next)
    {
        // before request area
        
        await next(context);

        // after request area
        if (context.Response.StatusCode == HttpStatusCode.NotModified)
        {
            var eTag = context.Response.Headers.GetValues("ETag").First().Replace("\"", string.Empty);
            var data = await _cache.GetCachedResponse(eTag);
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            response.Content = new StringContent(JsonConvert.SerializeObject(data));

            context.SetHttpResponseMessage(response);
        }
    }
}
```

Next, register your cache in the service collection and set up customization of the pipline

```cs
_serviceCollection.AddEVEOnlineEsiClient(config =>
{
    config.UserAgent = "agent name";
    config.EnableETag = true;
})
.UseAccessTokenProvider<YourAccessTokenProvider>()
.CustomizePipline(configure =>
{
	configure.ModificationFor(EndpointsSelector.GetRequests) // You can use a preset group or you can specify a specific endpoint Ids
		// Place it so that the handler is launched before the ETagHandler callback (i.e. on the reverse pass of the chain after RequestGetHandler)
		.AdditionalMiddleware<CustomHandler>("eTagResponseModifier", addAfter: "ETagHandler");
});

// Also register your cache and handler it self
_serviceCollection.TryAddSingleton<IResponseCache, MyResponseCache>;
_serviceCollection.TryAddSingleton<CustomHandler>; // scope at your discretion
```
