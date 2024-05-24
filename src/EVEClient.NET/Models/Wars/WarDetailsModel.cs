using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class WarDetailsModel
    {
        public WarDetailsModel(int warId)
        {
            WarId = warId;
        }

        [PathParameter("war_id")]
        public int WarId { get; private set; }
    }
}
