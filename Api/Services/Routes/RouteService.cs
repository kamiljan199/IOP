using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Api.Managers;

namespace Api.Services
{
    public class RouteService : IRouteService
    {
        private readonly IRouteManager _routeManager;

        public RouteService(IRouteManager routeManager)
        {
            _routeManager = routeManager;
        }
    }
}
