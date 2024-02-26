using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class RoutesUriModels
    {
        public RoutesUriModels(int origin, int destination, string flag, int[] avoid, int[] connections)
        {
            Origin = origin;
            Destination = destination;
            Flag = flag;

            if (avoid != null)
            { 
                Avoid = string.Join(",", avoid);
            }

            if (connections != null)
            { 
                Connections = string.Join(",", connections);
            }
        }

        [PathParameter("origin")]
        public int Origin {  get; set; }

        [PathParameter("destination")]
        public int Destination { get; set; }

        [QueryParameter("flag")]
        public string Flag {  get; set; }

        [QueryParameter("avoid")]
        public string Avoid { get; set; }

        [QueryParameter("connections")]
        public string Connections { get; set; }
    }
}
