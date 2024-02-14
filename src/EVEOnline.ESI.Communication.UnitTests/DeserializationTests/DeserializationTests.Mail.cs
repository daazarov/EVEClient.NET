using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.UnitTests.Datasets.Providers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EVEOnline.ESI.Communication.UnitTests.DeserializationTests.Mail
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.mail.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Header>), nameof(DeserializationTestCaseSourceProvider<Header>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Mail_Header(Header model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.From, Is.EqualTo(90000001));
            Assert.That(model.IsRead, Is.True);
            Assert.That(model.MailId, Is.EqualTo(7));
            Assert.That(model.Subject, Is.EqualTo("Title for EVE Mail"));
            Assert.That(model.Timestamp.HasValue, Is.True);
            Assert.That(model.Timestamp.Value.Year, Is.EqualTo(2015));

            Assert.That(model.Labels, Is.Not.Empty);
            Assert.That(model.Labels, Has.Exactly(1).EqualTo(3));

            Assert.That(model.Recipients, Is.Not.Empty);
            Assert.That(model.Recipients.First().RecipientType, Is.EqualTo(RecipientType.Character));
            Assert.That(model.Recipients.First().RecipientId, Is.EqualTo(90000002));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Message>), nameof(DeserializationTestCaseSourceProvider<Message>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Mail_Message(Message model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.From, Is.EqualTo(90000001));
            Assert.That(model.Read, Is.True);
            Assert.That(model.Body, Is.EqualTo("blah blah blah"));
            Assert.That(model.Subject, Is.EqualTo("test"));
            Assert.That(model.Timestamp.HasValue, Is.True);
            Assert.That(model.Timestamp.Value.Year, Is.EqualTo(2015));

            Assert.That(model.Labels, Is.Not.Empty);
            Assert.That(model.Labels, Has.Exactly(2).GreaterThan(1));

            Assert.That(model.Recipients, Is.Not.Empty);
            Assert.That(model.Recipients.First().RecipientType, Is.EqualTo(RecipientType.Character));
            Assert.That(model.Recipients.First().RecipientId, Is.EqualTo(90000002));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<MailingList>), nameof(DeserializationTestCaseSourceProvider<MailingList>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Mail_MailingList(MailingList model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.MailingListId, Is.EqualTo(1));
            Assert.That(model.Name, Is.EqualTo("test_mailing_list"));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<LabelCounts>), nameof(DeserializationTestCaseSourceProvider<LabelCounts>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Mail_LabelCounts(LabelCounts model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.TotalUnreadCount, Is.EqualTo(5));
            Assert.That(model.Labels, Is.Not.Empty);
            Assert.That(model.Labels.First().Name, Is.EqualTo("PINK"));
            Assert.That(model.Labels.First().Color, Is.EqualTo(LabelColor.Pink));
            Assert.That(model.Labels.First().LabelId, Is.EqualTo(16));
            Assert.That(model.Labels.First().UnreadCount, Is.EqualTo(4));
        }
    }
}
