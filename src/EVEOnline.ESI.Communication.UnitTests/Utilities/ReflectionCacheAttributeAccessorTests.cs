using System.Reflection;
using NUnit.Framework;
using EVEOnline.ESI.Communication.UnitTests.TestsClasses;
using EVEOnline.ESI.Communication.Utilities;

namespace EVEOnline.ESI.Communication.UnitTests.Utilities
{
    public class ReflectionCacheAttributeAccessorTests
    {
        [Test]
        public void ReflectionCacheAttributeAccessor_CreateGet_NotNull_Typed()
        {
            PropertyInfo namePropertyInfo = typeof(Person).GetProperty(nameof(Person.Name))!;

            Person p = new Person();
            p.Name = "Name!1";

            var call = DynamicMethodPropertyGetAccessor.Instance.CreateGet<Person>(namePropertyInfo);
            object? result = call(p);

            Assert.That(result, Is.Not.Null);
            Assert.That((string)result, Is.EqualTo("Name!1"));
        }

        [Test]
        public void ReflectionCacheAttributeAccessor_CreateGet_Null_Typed()
        {
            PropertyInfo namePropertyInfo = typeof(Person).GetProperty(nameof(Person.Name))!;

            Person p = new Person();

            var call = DynamicMethodPropertyGetAccessor.Instance.CreateGet<Person>(namePropertyInfo);
            object? result = call(p);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void ReflectionCacheAttributeAccessor_CreateGet_NotNull_Object()
        {
            PropertyInfo namePropertyInfo = typeof(Person).GetProperty(nameof(Person.Name))!;

            Person p = new Person();
            p.Name = "Name!2";

            var call = DynamicMethodPropertyGetAccessor.Instance.CreateGet<object>(namePropertyInfo);
            object? result = call(p);

            Assert.That(result, Is.Not.Null);
            Assert.That((string)result, Is.EqualTo("Name!2"));
        }

        [Test]
        public void ReflectionCacheAttributeAccessor_CreateGet_Null_Object()
        {
            PropertyInfo namePropertyInfo = typeof(Person).GetProperty(nameof(Person.Name))!;

            Person p = new Person();

            var call = DynamicMethodPropertyGetAccessor.Instance.CreateGet<object>(namePropertyInfo);
            object? result = call(p);

            Assert.That(result, Is.Null);
        }
    }
}
