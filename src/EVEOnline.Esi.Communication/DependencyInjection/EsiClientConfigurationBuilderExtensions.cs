using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EVEOnline.Esi.Communication.DependencyInjection
{
    public static partial class EsiClientConfigurationBuilderExtensions
    {
        public static IEsiClientConfigurationBuilder UseAccessTokenProvider<T>(this IEsiClientConfigurationBuilder builder) where T : IAccessTokenProvider
        {
            return builder.UseAccessTokenProvider(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseAccessTokenProvider(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            if (!typeof(IAccessTokenProvider).GetTypeInfo().IsAssignableFrom(instanceType.GetTypeInfo()))
            {
                throw new NotSupportedException(); // todo
            }

            builder.ServiceCollection.TryAddTransient(typeof(IAccessTokenProvider), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseScopeValidator<T>(this IEsiClientConfigurationBuilder builder) where T : IScopeAccessValidator
        {
            return builder.UseScopeValidator(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseScopeValidator(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            if (!typeof(IScopeAccessValidator).GetTypeInfo().IsAssignableFrom(instanceType.GetTypeInfo()))
            {
                throw new NotSupportedException(); // todo
            }

            builder.ServiceCollection.TryAddTransient(typeof(IScopeAccessValidator), instanceType);

            return builder;
        }

        public static IEsiClientConfigurationBuilder UseETagStorage<T>(this IEsiClientConfigurationBuilder builder) where T : IETagStorage
        {
            return builder.UseETagStorage(typeof(T));
        }

        public static IEsiClientConfigurationBuilder UseETagStorage(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            if (!typeof(IETagStorage).GetTypeInfo().IsAssignableFrom(instanceType.GetTypeInfo()))
            {
                throw new NotSupportedException(); // todo
            }

            builder.ServiceCollection.AddSingletonWithReplace(typeof(IETagStorage), instanceType);

            return builder;
        }
    }
}
