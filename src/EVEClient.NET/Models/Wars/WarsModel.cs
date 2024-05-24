using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
