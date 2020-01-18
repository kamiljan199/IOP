using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Api.Controllers;
using Api.DTOs;
using Model.Models;
using System.Linq;

namespace View
{
    public partial class LogisticsRouteViewForm : Form
    {
        private readonly RouteController _routeController;

        public Route route;
        public LogisticsRouteViewForm(RouteController routeController)
        {
            _routeController = routeController;
            InitializeComponent();
        }

        private void LogisticsRouteView_Load(object sender, EventArgs e)
        {
            driverLabel.Text = route.Employee.Surname;
            vehicleLabel.Text = route.Vehicle.Model;
        }
    }
}
