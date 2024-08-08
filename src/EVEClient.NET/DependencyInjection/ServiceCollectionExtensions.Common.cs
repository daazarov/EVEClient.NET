using System;
using Microsoft.Extensions.DependencyInjection;

namespace EVEClient.NET.DependencyInjection
{
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Performs a search for an existing registered service with <see cref="TService"/> type in the <see cref="IServiceCollection"/> collection. 
        /// If the registration is found, then replaces its implementation. If not, adds a new registration with <see cref="ServiceLifetime.Transient"/> 
        /// </summary>
        /// <typeparam name="TService">The type of the service to replace.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddTransientWithReplace<TService, TImplementation>(this IServiceCollection services)
            where TImplementation : class, TService
        {
            if (services == null)
            { 
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddTransientWithReplace(typeof(TService), typeof(TImplementation));
        }

        /// <summary>
        /// Performs a search for an existing registered service with <paramref name="service"/> type in the <see cref="IServiceCollection"/> collection. 
        /// If the registration is found, then replaces its implementation. If not, adds a new registration with <see cref="ServiceLifetime.Transient"/> 
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="service">The type of the service to register.</param>
        /// <param name="implementationType">The implementation type of the service.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddTransientWithReplace(this IServiceCollection services, Type service, Type implementationType)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddtWithReplace(service, implementationType, ServiceLifetime.Transient);
        }

        /// <summary>
        /// Performs a search for an existing registered service with <see cref="TService"/> type in the <see cref="IServiceCollection"/> collection. 
        /// If the registration is found, then replaces its implementation. If not, adds a new registration with <see cref="ServiceLifetime.Scoped"/> 
        /// </summary>
        /// <typeparam name="TService">The type of the service to replace.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddScopedWithReplace<TService, TImplementation>(this IServiceCollection services)
            where TImplementation : class, TService
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddScopedWithReplace(typeof(TService), typeof(TImplementation));
        }

        /// <summary>
        /// Performs a search for an existing registered service with <paramref name="service"/> type in the <see cref="IServiceCollection"/> collection. 
        /// If the registration is found, then replaces its implementation. If not, adds a new registration with <see cref="ServiceLifetime.Scoped"/> 
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="service">The type of the service to register.</param>
        /// <param name="implementationType">The implementation type of the service.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddScopedWithReplace(this IServiceCollection services, Type service, Type implementationType)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddtWithReplace(service, implementationType, ServiceLifetime.Scoped);
        }

        /// <summary>
        /// Performs a search for an existing registered service with <see cref="TService"/> type in the <see cref="IServiceCollection"/> collection. 
        /// If the registration is found, then replaces its implementation. If not, adds a new registration with <see cref="ServiceLifetime.Singleton"/> 
        /// </summary>
        /// <typeparam name="TService">The type of the service to replace.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddSingletonWithReplace<TService, TImplementation>(this IServiceCollection services)
            where TImplementation : class, TService
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddSingletonWithReplace(typeof(TService), typeof(TImplementation));
        }

        /// <summary>
        /// Performs a search for an existing registered service with <paramref name="service"/> type in the <see cref="IServiceCollection"/> collection. 
        /// If the registration is found, then replaces its implementation. If not, adds a new registration with <see cref="ServiceLifetime.Singleton"/> 
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="service">The type of the service to register.</param>
        /// <param name="implementationType">The implementation type of the service.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddSingletonWithReplace(this IServiceCollection services, Type service, Type implementationType)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddtWithReplace(service, implementationType, ServiceLifetime.Singleton);
        }

        private static IServiceCollection AddtWithReplace(this IServiceCollection services, Type service, Type implementationType, ServiceLifetime serviceLifetime)
        {
            int count = services.Count;
            bool replaced = false;

            for (int i = 0; i < count; i++)
            {
                if (services[i].ServiceType == service)
                {
                    // Already added
                    switch (serviceLifetime)
                    { 
                        case ServiceLifetime.Transient:
                            services[i] = ServiceDescriptor.Transient(service, implementationType);
                            break;
                        case ServiceLifetime.Scoped:
                            services[i] = ServiceDescriptor.Scoped(service, implementationType);
                            break;
                        case ServiceLifetime.Singleton:
                            services[i] = ServiceDescriptor.Singleton(service, implementationType);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(serviceLifetime));
                    }

                    replaced = true;
                }
            }

            if (!replaced)
            {
                services.Add(new ServiceDescriptor(service, implementationType, serviceLifetime));
            }

            return services;
        }
    }
}
