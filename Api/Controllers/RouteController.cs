using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Api.Services;
using Api.DTOs;

namespace Api.Controllers
{
    public class RouteController
    {
        private readonly IRouteService _routeService;
        public RouteController(IRouteService routeService)
        {
            _routeService = routeService;
        }
    }
}
