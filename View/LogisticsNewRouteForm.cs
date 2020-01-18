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
    public partial class LogisticsNewRouteForm : Form
    {
        private readonly RouteController _routeController;
        private readonly VehicleController _vehicleController;
        private readonly EmployeeController _employeeController;
        private readonly StorePlaceController _storePlaceController;
        private readonly PositionController _positionController;
        private readonly ParcelController _parcelController;

        VehiclesDTO vehicles;
        EmployeesDTO couriers;
        Parcel[] parcels;

        StorePlace currentWarehouse;

        public LogisticsNewRouteForm(
            RouteController routeController,
            VehicleController vehicleController,
            EmployeeController employeeController,
            StorePlaceController storePlaceController,
            PositionController positionController,
            ParcelController parcelController
            )
        {
            _routeController = routeController;
            _vehicleController = vehicleController;
            _employeeController = employeeController;
            _storePlaceController = storePlaceController;
            _positionController = positionController;
            _parcelController = parcelController;
            InitializeComponent();
        }

        private void LogisticsNewRouteForm_Shown(object sender, EventArgs e)
        {
            comboBoxDriver.Items.Clear();
            comboBoxVehicle.Items.Clear();

            listViewWarehouseParcels.Items.Clear();
            listViewVehicleParcels.Items.Clear();

            // TODO: show error message when no vehicles etc. to not crash app

            Position courierPosition = _positionController.GetPositionByName("Kurier");
            currentWarehouse = _storePlaceController.GetAllWarehouses().StorePlaces[0];

            vehicles = _vehicleController.GetAllVehicles();
            couriers = _employeeController.GetEmployeesByPositionId(courierPosition.Id);
            parcels = _parcelController.GetParcelsFromStorePlaceByStatus(currentWarehouse, Model.Enums.ParcelStatus.InWarehouse);


            foreach (var vehicle in vehicles.Vehicles)
            {
                comboBoxVehicle.Items.Add(string.Format(
                    "{0} {1} ({2})", vehicle.Brand, vehicle.Model, vehicle.Registration
                    ));
            }

            foreach (var courier in couriers.Employees)
            {
                comboBoxDriver.Items.Add(string.Format(
                    "{0} {1}", courier.Name, courier.Surname
                    ));
            }

            foreach (var parcel in parcels)
            {
                Address addr = parcel.ReceiverData.PersonalAddress;
                string addressText = string.Format("{0} {1}/{2}, {3}, {4}", addr.Street, addr.HomeNumber, addr.ApartmentNumber, addr.PostCode, addr.City);
                int volume = (int)(parcel.ParcelLength * parcel.ParcelHeight * parcel.ParcelWidth);
                ListViewItem item = new ListViewItem(new string[] { "", addressText, "0", volume.ToString() });
                item.Tag = parcel.Id;
                if (parcel.Priority > 0)
                    item.BackColor = Color.LightGoldenrodYellow;
                listViewWarehouseParcels.Items.Add(item);
            }

            ReordereOrdinNumbers(listViewWarehouseParcels);
            UpdateWeightVolumeInfo();
        }

        void ReordereOrdinNumbers(ListView list)
        {
            int i = 1;
            foreach (ListViewItem item in list.Items)
                item.Text = (i++).ToString();
        }

        private void buttonMoveToVehicle_Click(object sender, EventArgs e)
        {
            MoveParcel(listViewWarehouseParcels, listViewVehicleParcels);
        }

        private void buttonMoveToWarehouse_Click(object sender, EventArgs e)
        {
            MoveParcel(listViewVehicleParcels, listViewWarehouseParcels);
        }

        void MoveParcel(ListView from, ListView to)
        {
            if (from.SelectedIndices.Count > 0)
            {
                int index = from.SelectedIndices[0];
                ListViewItem item = from.Items[index];
                from.Items.Remove(item);
                to.Items.Add(item);

                ReordereOrdinNumbers(listViewWarehouseParcels);
                ReordereOrdinNumbers(listViewVehicleParcels);

                UpdateWeightVolumeInfo();
            }
        }

        private void buttonMoveParcelUp_Click(object sender, EventArgs e)
        {
            if (listViewVehicleParcels.SelectedIndices.Count > 0)
            {
                int index = listViewVehicleParcels.SelectedIndices[0];
                if (index > 0)
                {
                    ListViewItem item = listViewVehicleParcels.Items[index];
                    listViewVehicleParcels.Items.Remove(item);
                    listViewVehicleParcels.Items.Insert(index - 1, item);
                    ReordereOrdinNumbers(listViewVehicleParcels);
                    listViewVehicleParcels.Items[index - 1].Selected = true;
                }
            }
        }

        private void buttonMoveParcelDown_Click(object sender, EventArgs e)
        {
            if (listViewVehicleParcels.SelectedIndices.Count > 0)
            {
                int index = listViewVehicleParcels.SelectedIndices[0];
                if (index < listViewVehicleParcels.Items.Count - 1)
                {
                    ListViewItem item = listViewVehicleParcels.Items[index];
                    listViewVehicleParcels.Items.Remove(item);
                    listViewVehicleParcels.Items.Insert(index + 1, item);
                    ReordereOrdinNumbers(listViewVehicleParcels);
                    listViewVehicleParcels.Items[index + 1].Selected = true;
                }
            }
        }

        void UpdateWeightVolumeInfo()
        {
            int maxWeight = 0, maxVolume = 0;
            if (comboBoxVehicle.SelectedIndex >= 0)
            {
                maxWeight = (int)vehicles.Vehicles[comboBoxVehicle.SelectedIndex].MaxLoad;
                maxVolume = (int)vehicles.Vehicles[comboBoxVehicle.SelectedIndex].MaxCapacity;
            }

            int totalWeight = 0, totalVolume = 0;
            foreach (ListViewItem item in listViewVehicleParcels.Items)
            {
                totalWeight += Convert.ToInt32(item.SubItems[2].Text);
                totalVolume += Convert.ToInt32(item.SubItems[3].Text);
            }

            labelWeight.Text = String.Format("{0} / {1}", totalWeight, maxWeight);
            labelVolume.Text = String.Format("{0} / {1}", totalVolume, maxVolume);

            labelWeight.ForeColor = totalWeight > maxWeight ? Color.DarkRed : Color.DarkGreen;
            labelVolume.ForeColor = totalVolume > maxVolume ? Color.DarkRed : Color.DarkGreen;
        }

        private void buttonCreateRoute_Click(object sender, EventArgs e)
        {
            if (comboBoxDriver.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz kierowcę.", "Nieprawdiłowy formularz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxVehicle.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz samochód.", "Nieprawdiłowy formularz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listViewVehicleParcels.Items.Count == 0)
            {
                MessageBox.Show("Wybierz paczki.", "Nieprawdiłowy formularz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int driverId = couriers.Employees.ToArray()[comboBoxDriver.SelectedIndex].Id;
            int carId = vehicles.Vehicles.ToArray()[comboBoxVehicle.SelectedIndex].Id;
            List<int> parcelIds = new List<int>();
            foreach (ListViewItem item in listViewVehicleParcels.Items)
                parcelIds.Add((int)item.Tag);

            NewRouteDTO dto = _routeController.CreateRoute(driverId, carId, parcelIds.ToArray());
            if (dto.Status == Api.Enums.NewRouteStatus.Failure)
            {
                MessageBox.Show(dto.ErrorMessage, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dto.Status == Api.Enums.NewRouteStatus.Success)
            {
                MessageBox.Show("Trasa została utworzona", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void comboBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWeightVolumeInfo();
        }
    }
}
