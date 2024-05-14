using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class MoonIdModel
    {
        public MoonIdModel(int moonId)
        {
            MoonId = moonId;
        }

        [PathParameter("moon_id")]
        public int MoonId { get; set; }
    }
}
