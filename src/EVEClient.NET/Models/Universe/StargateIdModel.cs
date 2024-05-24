using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
