using System;
using Microsoft.Extensions.DependencyInjection;

namespace EVEOnline.Esi.Communication.DependencyInjection
{
    internal static partial class ServiceCollectionExtensions
    {
        internal static IServiceCollection AddTransientWithReplace<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            if (services == null)
            { 
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddTransientWithReplace(typeof(TService), typeof(TImplementation));
        }

        internal static IServiceCollection AddTransientWithReplace(this IServiceCollection services, Type service, Type implementationType)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddtWithReplace(service, implementationType, ServiceLifetime.Transient);
        }

        internal static IServiceCollection AddScopedWithReplace<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddScopedWithReplace(typeof(TService), typeof(TImplementation));
        }

        internal static IServiceCollection AddScopedWithReplace(this IServiceCollection services, Type service, Type implementationType)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddtWithReplace(service, implementationType, ServiceLifetime.Scoped);
        }

        internal static IServiceCollection AddSingletonWithReplace<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddSingletonWithReplace(typeof(TService), typeof(TImplementation));
        }

        internal static IServiceCollection AddSingletonWithReplace(this IServiceCollection services, Type service, Type implementationType)
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
                            throw new InvalidCastException(); // todo
                    }
                }
            }

            return services;
        }
    }
}
