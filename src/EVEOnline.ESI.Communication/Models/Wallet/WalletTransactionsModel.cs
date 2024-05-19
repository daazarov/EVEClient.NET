using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class WalletTransactionsModel
    {
        public WalletTransactionsModel(int characterId,  long? fromId)
        {
            CharacterId = characterId;
            FromId = fromId;
        }

        [PathParameter("character_id")]
        public int CharacterId { get; private set; }


        [QueryParameter("from_id")]
        public long? FromId {  get; private set; }
    }
}
