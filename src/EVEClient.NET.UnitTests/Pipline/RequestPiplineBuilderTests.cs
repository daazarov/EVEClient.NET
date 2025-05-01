using System.Reflection;
using EVEClient.NET.Handlers;
using EVEClient.NET.Pipline;
using EVEClient.NET.Pipline.Modifications;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.Pipline
{
    public class RequestPiplineBuilderTests
    {
        [Test]
        public void RequestPiplineBuilder_Additional_StartAndEnd()
        {
            var expectedComponents = new List<string>
            {
                "StartHandler",
                nameof(DefaultRequestProtectionHandler),
                nameof(DefaultRequestETagHandler),
                nameof(DefaultRequestSendingHandler),
                "EndHandler"
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddToEnd = true, PiplineComponent = new PiplineComponent("EndHandler", next => context => next(context)) },
                new AdditionalComponent { AddToStart = true, PiplineComponent = new PiplineComponent("StartHandler", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(additions).UseDefaultPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Additional_AddAfter_Simple()
        {
            var expectedComponents = new List<string>
            {
                nameof(DefaultRequestProtectionHandler),
                nameof(DefaultRequestETagHandler),
                "HandlerAfterETagHandler",
                nameof(DefaultRequestSendingHandler)
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddAfter = nameof(DefaultRequestETagHandler), PiplineComponent = new PiplineComponent("HandlerAfterETagHandler", next => context => next(context)) },
            };

            var builder = new RequestPiplineBuilder(additions).UseDefaultPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Additional_AddAfter_Complicate()
        {
            var expectedComponents = new List<string>
            {
                nameof(DefaultRequestProtectionHandler),
                nameof(DefaultRequestETagHandler),
                "CustomHandler1",
                "CustomHandler2",
                nameof(DefaultRequestSendingHandler)
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddAfter = nameof(DefaultRequestETagHandler), PiplineComponent = new PiplineComponent("CustomHandler1", next => context => next(context)) },
                new AdditionalComponent { AddAfter = "CustomHandler1", PiplineComponent = new PiplineComponent("CustomHandler2", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(additions).UseDefaultPipline();
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
                nameof(DefaultRequestProtectionHandler),
                nameof(DefaultRequestETagHandler),
                nameof(DefaultRequestSendingHandler),
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

            var builder = new RequestPiplineBuilder(additions).UseDefaultPipline();
            var pipline = builder.Build();
            var changedCollection = getterComponents(builder);

            Assert.That(changedCollection.Select(x => x.ComponentId), Is.EqualTo(expectedComponents));
        }

        [Test]
        public void RequestPiplineBuilder_Mixed_Complicated()
        {
            var expectedComponents = new List<string>
            {
                nameof(DefaultRequestProtectionHandler),
                nameof(DefaultRequestETagHandler),
                "CustomAdditionHandler1",
                "CustomAdditionHandler2",
                nameof(DefaultRequestSendingHandler),
            };

            var additions = new List<AdditionalComponent>()
            {
                new AdditionalComponent { AddAfter = nameof(DefaultRequestETagHandler), PiplineComponent = new PiplineComponent("CustomAdditionHandler1", next => context => next(context)) },
                new AdditionalComponent { AddAfter = "CustomAdditionHandler1", PiplineComponent = new PiplineComponent("CustomAdditionHandler2", next => context => next(context)) }
            };

            var builder = new RequestPiplineBuilder(additions).UseDefaultPipline();
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
