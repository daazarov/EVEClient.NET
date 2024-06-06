using System.Reflection;
using EVEClient.NET.Pipline;
using EVEClient.NET.Pipline.Modifications;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.Pipline
{
    public class RequestPiplineBuilderTests
    {
        [Test]
        public void RequestPiplineBuilder_OneReplacements()
        {
            var expectedComponents = new List<string>
            {
                "ProtectionHandler",
                "RequestHeadersHandler",
                "UrlRequestParametersHandler",
                "EndpointHandler",
                "ETagHandlerCustom",
                "RequestGetHandler"
            };
            
            var replacements = new List<ReplaceComponent>()
            {
                new ReplaceComponent { ReplaceId = "ETagHandler", PiplineComponent = new PiplineComponent("ETagHandlerCustom", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(replacements).UseGetPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Additional_StartAndEnd()
        {
            var expectedComponents = new List<string>
            {
                "StartHandler",
                "ProtectionHandler",
                "RequestHeadersHandler",
                "UrlRequestParametersHandler",
                "EndpointHandler",
                "ETagHandler",
                "RequestGetHandler",
                "EndHandler"
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddToEnd = true, PiplineComponent = new PiplineComponent("EndHandler", next => context => next(context)) },
                new AdditionalComponent { AddToStart = true, PiplineComponent = new PiplineComponent("StartHandler", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(null, additions).UseGetPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Additional_AddAfter_Simple()
        {
            var expectedComponents = new List<string>
            {
                "ProtectionHandler",
                "RequestHeadersHandler",
                "UrlRequestParametersHandler",
                "EndpointHandler",
                "ETagHandler",
                "HandlerAfterETagHandler",
                "RequestGetHandler",
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddAfter = "ETagHandler", PiplineComponent = new PiplineComponent("HandlerAfterETagHandler", next => context => next(context)) },
            };

            var builder = new RequestPiplineBuilder(null, additions).UseGetPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Additional_AddAfter_Complicate()
        {
            var expectedComponents = new List<string>
            {
                "ProtectionHandler",
                "RequestHeadersHandler",
                "UrlRequestParametersHandler",
                "EndpointHandler",
                "ETagHandler",
                "CustomHandler1",
                "CustomHandler2",
                "RequestGetHandler",
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddAfter = "ETagHandler", PiplineComponent = new PiplineComponent("CustomHandler1", next => context => next(context)) },
                new AdditionalComponent { AddAfter = "CustomHandler1", PiplineComponent = new PiplineComponent("CustomHandler2", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(null, additions).UseGetPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Additional_StartAndEnd_Ordered()
        {
            var expectedComponents = new List<string>
            {
                "StartHandlerOrder1",
                "StartHandlerOrder2",
                "ProtectionHandler",
                "RequestHeadersHandler",
                "UrlRequestParametersHandler",
                "EndpointHandler",
                "ETagHandler",
                "RequestGetHandler",
                "EndHandlerOrder1",
                "EndHandlerOrder2"
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddToEnd = true, EndOrder = 1, PiplineComponent = new PiplineComponent("EndHandlerOrder1", next => context => next(context)) },
                new AdditionalComponent { AddToEnd = true, EndOrder = 2,PiplineComponent = new PiplineComponent("EndHandlerOrder2", next => context => next(context)) },
                new AdditionalComponent { AddToStart = true, StartOrder = 1, PiplineComponent = new PiplineComponent("StartHandlerOrder1", next => context => next(context)) },
                new AdditionalComponent { AddToStart = true, StartOrder = 2, PiplineComponent = new PiplineComponent("StartHandlerOrder2", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(null, additions).UseGetPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Mixed_Simple()
        {
            var expectedComponents = new List<string>
            {
                "StartHandler",
                "ProtectionHandler",
                "RequestHeadersHandler",
                "UrlRequestParametersHandler",
                "EndpointHandler",
                "ETagHandlerCustom",
                "RequestGetHandler",
                "EndHandler"
            };

            var replacements = new List<ReplaceComponent>()
            {
                new ReplaceComponent { ReplaceId = "ETagHandler", PiplineComponent = new PiplineComponent("ETagHandlerCustom", next => context => next(context)) }
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddToEnd = true, PiplineComponent = new PiplineComponent("EndHandler", next => context => next(context)) },
                new AdditionalComponent { AddToStart = true, PiplineComponent = new PiplineComponent("StartHandler", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(replacements, additions).UseGetPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Mixed_Complicated()
        {
            var expectedComponents = new List<string>
            {
                "ProtectionHandler",
                "RequestHeadersHandler",
                "UrlRequestParametersHandler",
                "EndpointHandler",
                "ETagHandlerCustom",
                "CustomAdditionHandler1",
                "CustomAdditionHandler2",
                "RequestGetHandler",
            };

            var replacements = new List<ReplaceComponent>()
            {
                new ReplaceComponent { ReplaceId = "ETagHandler", PiplineComponent = new PiplineComponent("ETagHandlerCustom", next => context => next(context)) }
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddAfter = "ETagHandlerCustom", PiplineComponent = new PiplineComponent("CustomAdditionHandler1", next => context => next(context)) },
                new AdditionalComponent { AddAfter = "CustomAdditionHandler1", PiplineComponent = new PiplineComponent("CustomAdditionHandler2", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(replacements, additions).UseGetPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        private List<PiplineComponent> getterComponents(IRequestPiplineBuilder instance)
        {
            return (List<PiplineComponent>)typeof(RequestPiplineBuilder).GetField("_components", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(instance);
        }
    }
}
