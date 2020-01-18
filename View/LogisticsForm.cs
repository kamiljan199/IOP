using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Api.Controllers;
using Api.DTOs;

namespace View
{
    public partial class LogisticsForm : Form
    {
        private readonly LogisticsNewRouteForm _form;
        private readonly RouteController _routeController;

        RoutesDTO routes;

        public LogisticsForm(LogisticsNewRouteForm form, RouteController routeController)
        {
            _form = form;
            _routeController = routeController;

            InitializeComponent();
        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            if (_form.ShowDialog() == DialogResult.OK)
                RefreshRoutes();
        }

        private void LogisticsForm_Shown(object sender, EventArgs e)
        {
            RefreshRoutes();
        }

        void RefreshRoutes()
        {
            routes = _routeController.GetAllRoutes();
            listRoute.Items.Clear();

            int ordin = 1;
            foreach (var route in routes.Routes)
            {
                string name = string.Format("{0} {1}, {2} {3} - {4} {5} ({6})",
                    route.CreationDateTime.ToShortDateString(),
                    route.CreationDateTime.ToShortTimeString(),
                    route.Employee.Name,
                    route.Employee.Surname,
                    route.Vehicle.Brand,
                    route.Vehicle.Model,
                    route.Vehicle.Registration
                );
                ListViewItem item = new ListViewItem(new string[] { (ordin++).ToString(), name });
                item.Tag = route.Id;
                listRoute.Items.Add(item);
            }

            labelRouteCounter.Text = (ordin - 1).ToString();
        }
    }
}
