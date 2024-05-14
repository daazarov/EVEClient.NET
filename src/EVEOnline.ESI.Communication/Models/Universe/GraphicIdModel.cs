using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class GraphicIdModel
    {
        public GraphicIdModel(int graphicId)
        {
            GraphicId = graphicId;
        }

        [PathParameter("graphic_id")]
        public int GraphicId { get; set; }
    }
}
