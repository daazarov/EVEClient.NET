using EVEClient.NET.Handlers;
using EVEClient.NET.UnitTests.TestsClasses;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.Pipline
{
    public class PiplineCustomizationTests
    {
        [Test]
        public void CustomizePipline_AdditionalComponent_EmptyComponentName_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<ArgumentNullException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("", (next) => context => next(context), addToStart: true);
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_EmptyEndpointId_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<ArgumentNullException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor("")
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToStart: true);
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_UnknownEndpointId_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor("non-existent endpointId")
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToStart: true);
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_DublicateComponentId_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToStart: true, startOrder: 0)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToStart: true, startOrder: 1);
            }));
        }

        [Test]
        public void CustomizePipline_ReplcaeHandler_DublicateReplaceId_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .ReplaceHandler<CustomHandler>("ETagHandler")
                    .ReplaceHandler<CustomHandler1>("ETagHandler");
            }));
        }

        [Test]
        public void CustomizePipline_ReplcaeHandler_UnknownReplaceId_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .ReplaceHandler<CustomHandler>("non-existent handler");
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_WithoutSetting_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context));
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_ConflictSetting_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToStart: true, addToEnd: true);
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_ConflictSettingAddAfter_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToStart: true, addAfter: "ProtectionHandler");
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_ConflictSettingMultipleAddToEndWithouOrder_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToEnd: true)
                    .AdditionalMiddleware("customComponent1", (next) => context => next(context), addToEnd: true);
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_ConflictSettingMultipleAddToStartWithoutOrder_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToStart: true)
                    .AdditionalMiddleware("customComponent1", (next) => context => next(context), addToStart: true);
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_ConflictSettingMultipleAddToStartWithSameOrder_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToStart: true, startOrder: 1)
                    .AdditionalMiddleware("customComponent1", (next) => context => next(context), addToStart: true, startOrder: 1);
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_ConflictSettingMultipleAddToEndWithSameOrder_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addToEnd: true, startOrder: 1)
                    .AdditionalMiddleware("customComponent1", (next) => context => next(context), addToEnd: true, startOrder: 1);
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_UnknownAddAfter_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addAfter: "unknown component");
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_AddAfterReferToReplacedComponent_ThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.Throws<InvalidOperationException>(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .ReplaceHandler<CustomHandler>("ETagHandler")
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addAfter: "ETagHandler");
            }));
        }

        [Test]
        public void CustomizePipline_AdditionalComponent_ValidConfiguration_NotThrowException()
        {
            var builder = new ServiceCollection().AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });

            Assert.DoesNotThrow(() => builder.CustomizePipline(configure =>
            {
                configure.ModificationFor(ESI.Endpoints.Status.ServerStatus)
                    .AdditionalMiddleware("customComponent", (next) => context => next(context), addAfter: "RequestHeadersHandler")
                    .AdditionalMiddleware("customComponent1", (next) => context => next(context), addAfter: "customComponent")
                    .AdditionalMiddleware("customComponent2", (next) => context => next(context), addToEnd: true)
                    .AdditionalMiddleware("customComponent3", (next) => context => next(context), addToStart: true, startOrder: 1)
                    .AdditionalMiddleware("customComponent4", (next) => context => next(context), addToStart: true, startOrder: 2)
                    .ReplaceHandler<CustomHandler>("ProtectionHandler")
                    .ReplaceHandler<CustomHandler1, ETagHandler>();
            }));
        }
    }
}
