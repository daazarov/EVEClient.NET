using System;

namespace EVEClient.NET.Models
{
    internal abstract class RouteModelBase<T> : IRoteModel where T : class
    {
        private readonly T _routeModel;
        
        public RouteModelBase(T routeModel) 
        {
            _routeModel = routeModel ?? throw new ArgumentNullException(nameof(routeModel));
        }

        public object QueryRoute => _routeModel;
    }
}
