using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Api.Controllers;

namespace View
{
    public partial class LogisticsNewRouteForm : Form
    {
        private readonly VehicleController _vehicleController;
        public LogisticsNewRouteForm(VehicleController vehicleController)
        {
            _vehicleController = vehicleController;
            InitializeComponent();
        }

        private void LogisticsNewRouteForm_Shown(object sender, EventArgs e)
        {
            comboBoxVehicle.Items.Clear();
            // TODO: show error message when no vehicles to not crash app
            foreach (var vehicle in _vehicleController.GetAllVehicles().Vehicles)
            {
                comboBoxVehicle.Items.Add(string.Format(
                    "{0} {1} ({2})", vehicle.Brand, vehicle.Model, vehicle.Registration
                    ));
            }
        }
    }
}
