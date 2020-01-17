using Api.Controllers;
using Api.DTOs;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class VehicleAddEditForm : Form
    {
        public Vehicle vehicle;

        private readonly VehicleController _vehicleController;
        private readonly EmployeeController _employeeController;

        //private readonly WarehousesDTO warehouseDTO;

        private EmployeesDTO _employeesDTO;
        public VehicleAddEditForm(VehicleController vehicleController, EmployeeController employeeController)
        {
            _vehicleController = vehicleController;
            _employeeController = employeeController;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VehicleAddEditForm_Load(object sender, EventArgs e)
        {
            //Magazyny
            if (!vehicle.Id.Equals(0))
            {
                registrationTextBox.Text = vehicle.Registration;
                brandTextBox.Text = vehicle.Brand;
                modelTextBox.Text = vehicle.Model;
                maxLoadTextBox.Text = vehicle.MaxLoad.ToString();
                maxCapacityTextBox.Text = vehicle.MaxCapacity.ToString();
                //mag
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle.DriverId = null;
            vehicle.Registration = registrationTextBox.Text;
            vehicle.Brand = brandTextBox.Text;
            vehicle.Model = modelTextBox.Text;
            vehicle.MaxLoad = float.Parse(maxLoadTextBox.Text);
            vehicle.MaxCapacity = float.Parse(maxCapacityTextBox.Text);
            //mag
            if (vehicle.Id.Equals(0))
            {
                _vehicleController.AddVehicle(vehicle, true);
            }
            else
            {
                _vehicleController.UpdateVehicle(vehicle);
            }
            this.Close();
        }
        private void VehicleAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
