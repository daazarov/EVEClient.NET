using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Skills
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.skills.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<SkillAttributes>), nameof(DeserializationTestCaseSourceProvider<SkillAttributes>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Skills_SkillAttributes(SkillAttributes model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Intelligence, Is.EqualTo(30));
            Assert.That(model.Willpower, Is.EqualTo(22));
            Assert.That(model.Perception, Is.EqualTo(21));
            Assert.That(model.AccruedRemapCooldownDate.HasValue, Is.True);
            Assert.That(model.AccruedRemapCooldownDate.Value.Year, Is.EqualTo(2016));
            Assert.That(model.BonusRemaps, Is.EqualTo(10));
            Assert.That(model.Charisma, Is.EqualTo(20));
            Assert.That(model.Memory, Is.EqualTo(25));
            Assert.That(model.LastRemapDate.HasValue, Is.True);
            Assert.That(model.LastRemapDate.Value.Year, Is.EqualTo(2017));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<SkillQueueItem>), nameof(DeserializationTestCaseSourceProvider<SkillQueueItem>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Skills_SkillQueueItem(SkillQueueItem model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.LevelEndSp, Is.EqualTo(5));
            Assert.That(model.FinishedLevel, Is.EqualTo(3));
            Assert.That(model.QueuePosition, Is.EqualTo(1));
            Assert.That(model.StartDate.HasValue, Is.True);
            Assert.That(model.StartDate.Value.Year, Is.EqualTo(2015));
            Assert.That(model.SkillId, Is.EqualTo(1));
            Assert.That(model.TrainingStartSp, Is.EqualTo(10));
            Assert.That(model.LevelStartSp, Is.EqualTo(6));
            Assert.That(model.FinishDate.HasValue, Is.True);
            Assert.That(model.FinishDate.Value.Year, Is.EqualTo(2016));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<SkillDetails>), nameof(DeserializationTestCaseSourceProvider<SkillDetails>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Skills_SkillDetails(SkillDetails model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.TotalSp, Is.EqualTo(20000));
            Assert.That(model.UnallocatedSp, Is.EqualTo(1200000));

            Assert.That(model.Skills, Is.Not.Null);
            Assert.That(model.Skills, Is.Not.Empty);
            Assert.That(model.Skills.First().SkillpointsInSkill, Is.EqualTo(10000));
            Assert.That(model.Skills.First().ActiveSkillLevel, Is.EqualTo(1));
            Assert.That(model.Skills.First().SkillId, Is.EqualTo(2));
            Assert.That(model.Skills.First().ActiveSkillLevel, Is.EqualTo(1));
        }
    }
}
