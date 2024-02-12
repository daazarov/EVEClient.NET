using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using EVEOnline.ESI.Communication;
using EVEOnline.ESI.Communication.DependencyInjection;
using EVEOnline.ESI.Communication.Handlers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class EsiClientConfigurationBuilderExtensions
    {
        public static IEsiClientConfigurationBuilder UseAccessTokenProvider<T>(this IEsiClientConfigurationBuilder builder) where T : IAccessTokenProvider
        {
            return builder.UseAccessTokenProvider(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseAccessTokenProvider(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IAccessTokenProvider), instanceType);

            builder.ServiceCollection.TryAddTransient(typeof(IAccessTokenProvider), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseScopeValidator<T>(this IEsiClientConfigurationBuilder builder) where T : IScopeAccessValidator
        {
            return builder.UseScopeValidator(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseScopeValidator(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IScopeAccessValidator), instanceType);

            builder.ServiceCollection.TryAddTransient(typeof(IScopeAccessValidator), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseETagStorage<T>(this IEsiClientConfigurationBuilder builder) where T : IETagStorage
        {
            return builder.UseETagStorage(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseETagStorage(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IETagStorage), instanceType);

            builder.ServiceCollection.AddSingletonWithReplace(typeof(IETagStorage), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseRequestHeadersHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestHeadersHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseRequestHeadersHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestHeadersHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestHeadersHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseProtectionHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseProtectionHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseProtectionHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(ProtectionHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(ProtectionHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseETagHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseETagHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseETagHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(ETagHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(ETagHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseBodyRequestParametersHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseBodyRequestParametersHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseBodyRequestParametersHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(BodyRequestParametersHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(BodyRequestParametersHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseUrlRequestParametersHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseUrlRequestParametersHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseUrlRequestParametersHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(UrlRequestParametersHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(UrlRequestParametersHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseEndpointHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseEndpointHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseEndpointHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(EndpointHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(EndpointHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseRequestGetHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestGetHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseRequestGetHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestGetHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestGetHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseRequestPostHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestPostHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseRequestPostHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestPostHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestPostHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseRequestPutHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestPutHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseRequestPutHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestPutHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestPutHandler), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseRequestDeleteHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestDeleteHandler(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseRequestDeleteHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestDeleteHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestDeleteHandler), instanceType);

            return builder;
        }

        private static void IsAssignableFrom(Type from, Type to)
        {
            if (!to.GetTypeInfo().IsAssignableFrom(from.GetTypeInfo()))
            {
                throw new InvalidCastException(); // todo
            }
        }
    }
}
