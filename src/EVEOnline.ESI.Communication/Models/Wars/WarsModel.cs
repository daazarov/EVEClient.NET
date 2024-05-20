using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class WarsModel
    {
        public WarsModel(long? maxWarId)
        {
            MaxWarId = maxWarId;
        }

        [QueryParameter("max_war_id")]
        public long? MaxWarId { get; private set; }
    }
}
