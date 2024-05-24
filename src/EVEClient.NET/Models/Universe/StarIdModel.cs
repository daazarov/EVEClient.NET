using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
