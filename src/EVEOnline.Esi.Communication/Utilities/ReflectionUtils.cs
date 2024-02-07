using System;
using System.Linq;
using System.Reflection;
using EVEOnline.ESI.Communication.Extensions;

namespace EVEOnline.ESI.Communication.Utilities
{
    internal class ReflectionUtils
    {
        public static MethodInfo GetIndirectMethodInfo<T>(string methodName)
        {
            methodName.ArgumentStringNotNullOrEmpty(nameof(methodName));

            return typeof(T).GetMethod(methodName) 
                ?? throw new ArgumentException($"Invalid method name ({methodName}). Method not found in the {typeof(T).FullName} type.");
        }

        public static Func<object, TReturnValue> GetPropertyValueDelegate<TReturnValue>(Type instanceType, string propertyName)
        {
            instanceType.ArgumentNotNull(nameof(instanceType));
            propertyName.ArgumentStringNotNullOrEmpty(nameof(propertyName));

            return (Func<object, TReturnValue>)Delegate.CreateDelegate(typeof(Func<object, TReturnValue>), null, instanceType.GetProperty(propertyName).GetGetMethod());
        }
    }
}
