using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using System.Diagnostics;

namespace Api.Helpers
{
    public class RouteReporter
    {
        private Route route;

        public RouteReporter(Route route)
        {
            this.route = route;
        }

        public void GeneratePDF()
        {
            string filename = "routereport.pdf";

            // TODO

            Process.Start(filename); // open file in external program
        }
    }
}
