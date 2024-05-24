using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
