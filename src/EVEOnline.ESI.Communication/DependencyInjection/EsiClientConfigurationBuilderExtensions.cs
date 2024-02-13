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
        /// <summary>
        /// Adds the specified <see cref="IAccessTokenProvider"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IAccessTokenProvider"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseAccessTokenProvider<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseAccessTokenProvider(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IAccessTokenProvider"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseAccessTokenProvider(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IAccessTokenProvider), instanceType);

            builder.ServiceCollection.TryAddTransient(typeof(IAccessTokenProvider), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="IScopeAccessValidator"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IScopeAccessValidator"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseScopeValidator<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseScopeValidator(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IScopeAccessValidator"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseScopeValidator(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IScopeAccessValidator), instanceType);

            builder.ServiceCollection.TryAddTransient(typeof(IScopeAccessValidator), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="IETagStorage"/> as a <see cref="ServiceLifetime.Singleton"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IETagStorage"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseETagStorage<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseETagStorage(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IETagStorage"/> as a <see cref="ServiceLifetime.Singleton"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseETagStorage(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IETagStorage), instanceType);

            builder.ServiceCollection.AddSingletonWithReplace(typeof(IETagStorage), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="RequestHeadersHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="RequestHeadersHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestHeadersHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestHeadersHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="RequestHeadersHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestHeadersHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestHeadersHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestHeadersHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="ProtectionHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="ProtectionHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseProtectionHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseProtectionHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="ProtectionHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseProtectionHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(ProtectionHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(ProtectionHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="ETagHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="ETagHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseETagHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseETagHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="ETagHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseETagHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(ETagHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(ETagHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="BodyRequestParametersHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="BodyRequestParametersHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseBodyRequestParametersHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseBodyRequestParametersHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="BodyRequestParametersHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseBodyRequestParametersHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(BodyRequestParametersHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(BodyRequestParametersHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="UrlRequestParametersHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="UrlRequestParametersHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseUrlRequestParametersHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseUrlRequestParametersHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="UrlRequestParametersHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseUrlRequestParametersHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(UrlRequestParametersHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(UrlRequestParametersHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="EndpointHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="EndpointHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseEndpointHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseEndpointHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="EndpointHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseEndpointHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(EndpointHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(EndpointHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="RequestGetHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="RequestGetHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestGetHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestGetHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="RequestGetHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestGetHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestGetHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestGetHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="RequestPostHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="RequestPostHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestPostHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestPostHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="RequestPostHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestPostHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestPostHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestPostHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="RequestPutHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="RequestPutHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestPutHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestPutHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="RequestPutHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestPutHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestPutHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestPutHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="RequestDeleteHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="RequestDeleteHandler"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestDeleteHandler<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseRequestDeleteHandler(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="RequestDeleteHandler"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseRequestDeleteHandler(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(RequestDeleteHandler), instanceType);

            builder.ServiceCollection.AddTransientWithReplace(typeof(RequestDeleteHandler), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="ICustomEndpointRoutePriorityProvider"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="ICustomEndpointRoutePriorityProvider"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseEndpointRoutePriorityProvider<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseEndpointRoutePriorityProvider(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="ICustomEndpointRoutePriorityProvider"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseEndpointRoutePriorityProvider(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(ICustomEndpointRoutePriorityProvider), instanceType);

            builder.ServiceCollection.TryAddTransient(typeof(ICustomEndpointRoutePriorityProvider), instanceType);

            return builder;
        }

        private static void IsAssignableFrom(Type from, Type to)
        {
            if (!to.GetTypeInfo().IsAssignableFrom(from.GetTypeInfo()))
            {
                throw new InvalidCastException($"{to.FullName} is not assignable from {from.FullName}");
            }
        }
    }
}
