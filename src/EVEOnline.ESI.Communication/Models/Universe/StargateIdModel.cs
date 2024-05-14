using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class StargateIdModel
    {
        public StargateIdModel(int stargateId)
        { 
            StargateId = stargateId;
        }

        [PathParameter("stargate_id")]
        public int StargateId { get; set; }
    }
}
