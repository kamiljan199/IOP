using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Api.Controllers;
using Api.DTOs;
using System.Linq;

namespace View
{
    public partial class LogisticsForm : Form
    {
        private readonly LogisticsNewRouteForm _form;
        private readonly LogisticsRouteViewForm _routeView;
        private readonly RouteController _routeController;

        RoutesDTO _routesDTO;

        public LogisticsForm(LogisticsNewRouteForm form, LogisticsRouteViewForm routeView, RouteController routeController)
        {
            _form = form;
            _routeView = routeView;
            _routeController = routeController;

            InitializeComponent();
        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            if (_form.ShowDialog() == DialogResult.OK)
                RefreshRoutes();
        }

        private void buttonShowRoute_Click(object sender, EventArgs e)
        {
            if (listRoute.SelectedIndices.Count == 0)
                return;

            int routeId = (int)listRoute.Items[listRoute.SelectedIndices[0]].Tag;
            RoutesDTO routeDto = _routeController.GetRouteById(routeId); ;

            _routeView.route = routeDto.Routes.First();
            _routeView.ShowDialog();
        }

        private void LogisticsForm_Shown(object sender, EventArgs e)
        {
            RefreshRoutes();
        }

        void RefreshRoutes()
        {
            _routesDTO = _routeController.GetAllRoutes();
            listRoute.Items.Clear();

            int ordin = 1;
            foreach (var route in _routesDTO.Routes)
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
