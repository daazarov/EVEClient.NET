using System.Collections.Generic;

namespace EVEOnline.ESI.Communication
{
    public class RouteQueue
    {
        private readonly PriorityQueue<string, RoutePriority> _routeQueue;

        public RouteQueue()
        {
            _routeQueue = new PriorityQueue<string, RoutePriority>(new RoutePriorityComparer());
        }

        public void AddRoute(string url, RoutePriority routePriority)
        {
            _routeQueue.Enqueue(url, routePriority);
        }

        public bool TryGetNextRoute(out string url)
        {
            return _routeQueue.TryDequeue(out url, out var priority);
        }
    }
}
