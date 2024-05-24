using System.Reflection;
using NUnit.Framework;
using EVEClient.NET.UnitTests.TestsClasses;
using EVEClient.NET.Utilities;

namespace EVEClient.NET.UnitTests.Utilities
{
    public class DynamicMethodPropertyGetAccessorTests
    {
        [Test]
        public void DynamicMethodPropertyGetAccessor_CreateGet_NotNull_Typed()
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
        public void DynamicMethodPropertyGetAccessor_CreateGet_Null_Typed()
        {
            PropertyInfo namePropertyInfo = typeof(Person).GetProperty(nameof(Person.Name))!;

            Person p = new Person();

            var call = DynamicMethodPropertyGetAccessor.Instance.CreateGet<Person>(namePropertyInfo);
            object? result = call(p);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void DynamicMethodPropertyGetAccessor_CreateGet_NotNull_Object()
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
        public void DynamicMethodPropertyGetAccessor_CreateGet_Null_Object()
        {
            PropertyInfo namePropertyInfo = typeof(Person).GetProperty(nameof(Person.Name))!;

            Person p = new Person();

            var call = DynamicMethodPropertyGetAccessor.Instance.CreateGet<object>(namePropertyInfo);
            object? result = call(p);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void DynamicMethodPropertyGetAccessor_CreateGet_Nullable_Null_Object()
        {
            PropertyInfo namePropertyInfo = typeof(Person).GetProperty(nameof(Person.Age))!;

            Person p = new Person();

            var call = DynamicMethodPropertyGetAccessor.Instance.CreateGet<object>(namePropertyInfo);
            object? result = call(p);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void DynamicMethodPropertyGetAccessor_CreateGet_Nullable_NotNull_Object()
        {
            PropertyInfo namePropertyInfo = typeof(Person).GetProperty(nameof(Person.Age))!;

            Person p = new Person();
            p.Age = 10;

            var call = DynamicMethodPropertyGetAccessor.Instance.CreateGet<object>(namePropertyInfo);
            object? result = call(p);

            Assert.That((int)result, Is.EqualTo(10));
        }
    }
}
