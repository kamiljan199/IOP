using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Model.Models;

namespace Api.Managers
{
    public interface IRouteManager
    {
        public int Add(Route route, RoutePoint[] routePoints);
        public Route GetRouteByID(int id);
        public Route[] GetAllRoutes();
    }
}
