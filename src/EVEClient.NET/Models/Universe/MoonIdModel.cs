using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
