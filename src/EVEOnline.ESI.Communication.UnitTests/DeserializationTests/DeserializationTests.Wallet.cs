using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEOnline.ESI.Communication.UnitTests.DeserializationTests.Wallet
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.wallet.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<JournalItem>), nameof(DeserializationTestCaseSourceProvider<JournalItem>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Wallet_JournalItem(JournalItem model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Amount, Is.EqualTo(-100000));
            Assert.That(model.Description, Is.EqualTo("Contract Deposit"));
            Assert.That(model.Balance, Is.EqualTo(500000.4316d));
            Assert.That(model.ContextId, Is.EqualTo(4));
            Assert.That(model.Date.Year, Is.EqualTo(2018));
            Assert.That(model.FirstPartyId, Is.EqualTo(2112625428));
            Assert.That(model.ID, Is.EqualTo(89));
            Assert.That(model.RefType, Is.EqualTo(TransactionType.ContractDeposit));
            Assert.That(model.SecondPartyId, Is.EqualTo(1000132));
            Assert.That(model.Reason, Is.EqualTo("blah blah blag"));
            Assert.That(model.Tax, Is.EqualTo(125.25d));
            Assert.That(model.TaxReceiverId, Is.EqualTo(14445877));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Transaction>), nameof(DeserializationTestCaseSourceProvider<Transaction>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Wallet_Transaction(Transaction model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.ClientId, Is.EqualTo(54321));
            Assert.That(model.IsBuy, Is.True);
            Assert.That(model.IsPersonal, Is.True);
            Assert.That(model.JournalRefId, Is.EqualTo(67890));
            Assert.That(model.Date.Year, Is.EqualTo(2016));
            Assert.That(model.LocationId, Is.EqualTo(60014719));
            Assert.That(model.Quantity, Is.EqualTo(1));
            Assert.That(model.TransactionId, Is.EqualTo(1234567890));
            Assert.That(model.TypeId, Is.EqualTo(587));
            Assert.That(model.UnitPrice, Is.EqualTo(1));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<DataContract.Wallet>), nameof(DeserializationTestCaseSourceProvider<DataContract.Wallet >.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Wallet_Wallet(DataContract.Wallet model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Balance, Is.EqualTo(123.45d));
            Assert.That(model.Division, Is.EqualTo(1));
        }
    }
}
