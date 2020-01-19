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
        private readonly StorePlaceController _storePlaceController;

        private StorePlacesDTO _storePlacesDTO;
        public VehicleAddEditForm(VehicleController vehicleController, StorePlaceController storePlaceController)
        {
            _vehicleController = vehicleController;
            _storePlaceController = storePlaceController;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VehicleAddEditForm_Load(object sender, EventArgs e)
        {
            SynchronizeStorePlaces();
            if (!vehicle.Id.Equals(0))
            {
                registrationTextBox.Text = vehicle.Registration;
                brandTextBox.Text = vehicle.Brand;
                modelTextBox.Text = vehicle.Model;
                maxLoadTextBox.Text = vehicle.MaxLoad.ToString();
                maxCapacityTextBox.Text = vehicle.MaxCapacity.ToString();
                if (vehicle.StorePlaceId != null)
                {
                    warehouseComboBox.SelectedIndex = _storePlacesDTO.StorePlaces.FindIndex(s => { return s.Id.Equals(vehicle.StorePlaceId); });
                }
                //mag
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (warehouseComboBox.SelectedIndex > -1)
            {
                vehicle.StorePlaceId = _storePlacesDTO.StorePlaces[warehouseComboBox.SelectedIndex].Id;
            }
            else
            {
                vehicle.StorePlaceId = null;
            }
            vehicle.Registration = registrationTextBox.Text;
            vehicle.Brand = brandTextBox.Text;
            vehicle.Model = modelTextBox.Text;
            try
            {
                vehicle.MaxLoad = float.Parse(maxLoadTextBox.Text);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                Console.WriteLine("Vehicle max load set to default - 500");
                vehicle.MaxLoad = 500.0f;
            }
            try
            {
                vehicle.MaxCapacity = float.Parse(maxCapacityTextBox.Text);
            }            
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                Console.WriteLine("Vehicle max capacity set to default - 500");
                vehicle.MaxCapacity = 500.0f;
            }
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

        private void SynchronizeStorePlaces()
        {
            _storePlacesDTO = _storePlaceController.GetAllStorePlaces();
            warehouseComboBox.Items.Clear();

            if (_storePlacesDTO.StorePlaces!= null)
            {
                foreach (var s in _storePlacesDTO.StorePlaces)
                {
                    warehouseComboBox.Items.Add(s.Name);
                }
            }
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
