using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class StarIdModel
    {
        public StarIdModel(int starId)
        { 
            StarId = starId;
        }

        [PathParameter("star_id")]
        public int StarId { get; set; }
    }
}
