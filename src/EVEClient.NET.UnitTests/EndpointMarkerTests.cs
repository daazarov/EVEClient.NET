using NUnit.Framework;

namespace EVEClient.NET.UnitTests
{
    public class EndpointMarkerTests
    {
        [Test]
        public void EndpointMarker_Defaults_ToString()
        {
            var get = EndpointMarker.DefaultGet;
            var post = EndpointMarker.DefaultPost;
            var put = EndpointMarker.DefaultPut;
            var delete = EndpointMarker.DefaultDelete;

            Assert.That(get.ToString(), Is.EqualTo("get_default"));
            Assert.That(post.ToString(), Is.EqualTo("post_default"));
            Assert.That(put.ToString(), Is.EqualTo("put_default"));
            Assert.That(delete.ToString(), Is.EqualTo("delete_default"));
        }

        [Test]
        public void EndpointMarker_InvalidHttpMethod_ThowException()
        {
            Assert.Throws<NotSupportedException>(() => new EndpointMarker("CONNECT"));
        }

        [Test]
        public void EndpointMarker_AsMethodInfo_Empty_ThowException()
        {
            Assert.Throws<InvalidOperationException>(() => new EndpointMarker().AsMethodInfo());
        }

        [Test]
        public void EndpointMarker_AsMethodInfo_Default_ThowException()
        {
            Assert.Throws<InvalidOperationException>(() => new EndpointMarker("POST").AsMethodInfo());
        }

        [Test]
        public void EndpointMarker_EmptyConstructor_Null()
        {
            var marker = new EndpointMarker();

            Assert.That(marker.IsNull, Is.True);
        }

        [Test]
        public void EndpointMarker_PassValidHttpMethodOnly_Default()
        {
            var marker = new EndpointMarker("DELETE");

            Assert.That(marker.IsNull, Is.False);
            Assert.That(marker.IsDefault, Is.True);
        }

        [Test]
        public void EndpointMarker_ImplicitConstructor_Default()
        {
            EndpointMarker marker = "DELETE";

            Assert.That(marker.IsNull, Is.False);
            Assert.That(marker.IsDefault, Is.True);
        }

        [Test]
        public void EndpointMarker_PassValidHttpMethodOnly_LowerCase_Default()
        {
            var marker = new EndpointMarker("delete");

            Assert.That(marker.IsNull, Is.False);
            Assert.That(marker.IsDefault, Is.True);
        }

        [Test]
        public void EndpointMarker_ImplicitConstructor_Null()
        {
            EndpointMarker marker = "";

            Assert.That(marker.IsNull, Is.True);
        }

        [Test]
        public void EndpointMarker_EmptyConstructor_EqualToNull()
        {
            var marker = default(EndpointMarker);

            Assert.That(marker, Is.EqualTo(EndpointMarker.Null));
        }

        [Test]
        public void EndpointMarker_SameMarkers_Equals()
        {
            var marker1 = new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.PublicInformation));
            var marker2 = new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.PublicInformation));

            Assert.That(marker1, Is.EqualTo(marker2));
            Assert.That(() => marker1 == marker2);
        }

        [Test]
        public void EndpointMarker_DifferentMarkers_NotEquals()
        {
            var marker1 = new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.PublicInformation));
            var marker2 = new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.ContactNotifications));

            Assert.That(marker1, Is.Not.EqualTo(marker2));
            Assert.That(() => marker1 != marker2);
        }

        [Test]
        public void EndpointMarker_SameMarkers_SameHashCodes()
        {
            var marker1 = new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.PublicInformation));
            var marker2 = new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.PublicInformation));

            Assert.That(marker1.GetHashCode(), Is.EqualTo(marker2.GetHashCode()));
        }

        [Test]
        public void EndpointMarker_ValidMarker_ToString_ReturnEndpointId()
        {
            var marker = new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.PublicInformation));
            string markerToStringString = marker.ToString();
            string markerAsImplictString = marker;

            Assert.That(markerToStringString, Is.EqualTo("get_characters_character_id"));
            Assert.That(markerAsImplictString, Is.EqualTo("get_characters_character_id"));
        }

        [Test]
        public void EndpointMarker_EmptyMarker_ToString_ReturnNullString()
        {
            var marker = new EndpointMarker();

            Assert.That(marker.ToString(), Is.EqualTo("(null)"));
        }

        [Test]
        public void EndpointMarker_EmptyMarker_ImplictString_ReturnNull()
        {
            var marker = new EndpointMarker();
            string markerAsImplictString = marker;

            Assert.That(markerAsImplictString, Is.Null);
        }
    }
}
