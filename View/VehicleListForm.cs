using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class VehicleListForm : Form
    {

        private readonly Api.Controllers.VehicleController _vehicleController;
        private readonly VehicleAddEditForm _vehicleAddEditForm;

        private Api.DTOs.VehiclesDTO _vehiclesDTO;
        public VehicleListForm(Api.Controllers.VehicleController vehicleController, VehicleAddEditForm vehicleAddEditForm)
        {
            _vehicleController = vehicleController;
            _vehicleAddEditForm = vehicleAddEditForm;
            _vehicleAddEditForm.FormClosed += delegate { SynchronizeVehicles(); };
            InitializeComponent();
        }

        private void VehicleListForm_Load(object sender, EventArgs e)
        {
            SynchronizeVehicles();
        }

        private void SynchronizeVehicles()
        {
            _vehiclesDTO = _vehicleController.GetAllVehicles();

            listView1.Items.Clear();

            if (_vehiclesDTO.Vehicles != null)
            {
                foreach (var v in _vehiclesDTO.Vehicles)
                {
                    string[] lv = { v.Id.ToString(), v.Registration, v.Brand, v.Model, "TODO", "TODO" };
                    listView1.Items.Add(new ListViewItem(lv));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrane rekordy?", "Potwierdzenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (ListViewItem s in listView1.SelectedItems)
                {
                    _vehicleController.RemoveVehicle(_vehiclesDTO.Vehicles[listView1.Items.IndexOf(s)]);
                }
                SynchronizeVehicles();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _vehicleAddEditForm.vehicle = new Model.Models.Vehicle();
            _vehicleAddEditForm.ShowDialog();
        }
    }
}
