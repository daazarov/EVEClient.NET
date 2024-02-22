using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.UnitTests.Datasets.Providers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.UnitTests.DeserializationTests.Opportunities
{
    public class DeserializationTests
    {
        private const string FileName = "deserialization.opportunities.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<ComplitedTask>), nameof(DeserializationTestCaseSourceProvider<ComplitedTask>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Opportunities_ComplitedTask(ComplitedTask model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.TaskId, Is.EqualTo(1));
            Assert.That(model.CompletedAt.Year, Is.EqualTo(2016));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<OpportunitiesTask>), nameof(DeserializationTestCaseSourceProvider<OpportunitiesTask>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Opportunities_OpportunitiesTask(OpportunitiesTask model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Description, Is.EqualTo("To use station services..."));
            Assert.That(model.Name, Is.EqualTo("Dock in the station"));
            Assert.That(model.TaskId, Is.EqualTo(10));
            Assert.That(model.Notification, Is.EqualTo("Completed:<br>Docked in a station!"));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<OpportunitiesGroup>), nameof(DeserializationTestCaseSourceProvider<OpportunitiesGroup>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Opportunities_OpportunitiesGroup(OpportunitiesGroup model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Description, Is.EqualTo("As a capsuleer..."));
            Assert.That(model.Name, Is.EqualTo("Welcome to New Eden"));
            Assert.That(model.GroupId, Is.EqualTo(103));
            Assert.That(model.Notification, Is.EqualTo("Completed:<br>Welcome to New Eden"));
            Assert.That(model.ConnectedGroups, Is.Not.Null);
            Assert.That(model.ConnectedGroups, Is.Not.Empty);
            Assert.That(model.ConnectedGroups, Has.Exactly(1).EqualTo(100));
            Assert.That(model.RequiredTasks, Is.Not.Null);
            Assert.That(model.RequiredTasks, Is.Not.Empty);
            Assert.That(model.RequiredTasks, Has.Exactly(1).EqualTo(19));
        }
    }
}
