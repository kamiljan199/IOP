using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Context;

namespace Api.Managers
{
    public class RouteManager : IRouteManager
    {
        private readonly AppDbContext _context;

        public RouteManager(AppDbContext context)
        {
            _context = context;
        }
    }
}
