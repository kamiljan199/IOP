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
            SynchronizeDrivers();
            //Magazyny
            if (!vehicle.Id.Equals(0))
            {
                registrationTextBox.Text = vehicle.Registration;
                brandTextBox.Text = vehicle.Brand;
                modelTextBox.Text = vehicle.Model;
                if (vehicle.DriverId != null)
                {
                    driverComboBox.SelectedIndex = ((List<Employee>)_employeesDTO.Employees).FindIndex(e => { return e.Id.Equals(vehicle.DriverId); });
                }
                //mag
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (driverComboBox.SelectedIndex > -1)
            {
                vehicle.DriverId = ((List<Employee>)_employeesDTO.Employees)[driverComboBox.SelectedIndex].Id;//((List<Employee>)_employeesDTO.Employees).Find(e => { return e.Pesel.Equals(driverComboBox.SelectedItem.ToString()); }).Id;
            } else
            {
                vehicle.Driver = null;
            }
            vehicle.Registration = registrationTextBox.Text;
            vehicle.Brand = brandTextBox.Text;
            vehicle.Model = modelTextBox.Text;
            //mag
            if (vehicle.Id.Equals(0))
            {
                _vehicleController.AddVehicle(vehicle);
            }
            else
            {
                _vehicleController.UpdateVehicle(vehicle);
            }
            this.Close();
        }

        private void SynchronizeDrivers()
        {
            _employeesDTO = _employeeController.GetAllEmployees();
            driverComboBox.Items.Clear();

            if (_employeesDTO.Employees != null)
            {
                foreach (var e in _employeesDTO.Employees)
                {
                    driverComboBox.Items.Add(e.Name + " " + e.Surname + " (" + e.Pesel + ")");
                }
            }
        }
    }
}
