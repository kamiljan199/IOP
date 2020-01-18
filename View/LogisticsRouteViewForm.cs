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
using Api.Helpers;

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

        private void LogisticsRouteViewForm_Shown(object sender, EventArgs e)
        {
            driverLabel.Text = string.Format(
                    "{0} {1}",
                    route.Employee.Name,
                    route.Employee.Surname
                 );
            vehicleLabel.Text = string.Format(
                    "{0} {1} ({2})",
                    route.Vehicle.Brand,
                    route.Vehicle.Model,
                    route.Vehicle.Registration
                 );
            dateLabel.Text = string.Format("{0} {1}",
                    route.CreationDateTime.ToShortDateString(),
                    route.CreationDateTime.ToShortTimeString()
                );

            listRoutes.Items.Clear();
            foreach (var point in route.RoutePoints)
            {
                Address addr = point.Parcel.ReceiverData.PersonalAddress;
                string addressText = string.Format("{0} {1}/{2}, {3}, {4}", addr.Street, addr.HomeNumber, addr.ApartmentNumber, addr.PostCode, addr.City);
                ListViewItem item = new ListViewItem(new string[] { point.Index.ToString(), addressText });
                if (point.Parcel.Priority > 0)
                    item.BackColor = Color.LightGoldenrodYellow;
                listRoutes.Items.Add(item);
            }
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            RouteReporter reporter = new RouteReporter(route);
            reporter.GeneratePDF();
        }
    }
}
