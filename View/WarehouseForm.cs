using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Api.Controllers;
using Model.Models;
using Api.DTOs;

namespace View
{
    public partial class WarehouseForm : Form
    {
        private readonly EmployeeController _employeeController;
        private readonly SortController _sortController;

        private List<Vehicle> _availableVehicles;
        private List<ListViewItem> _availableParcels;

        private Dictionary<Vehicle, List<ListViewItem>> vehiclesCargoDictionary;

        private readonly StorePlaceController _storePlaceController;
        private StorePlacesDTO _storePlacesDTO;
        private readonly ParcelController _parcelController;

        private List<Parcel> _parcels;

        public WarehouseForm(EmployeeController employeeController, SortController sortController,
            StorePlaceController storePlaceController, ParcelController parcelController)
        {
            _employeeController = employeeController;
            _sortController = sortController;
            vehiclesCargoDictionary = new Dictionary<Vehicle, List<ListViewItem>>();
            _availableVehicles = new List<Vehicle>();
            _availableParcels = new List<ListViewItem>();
            _parcels = new List<Parcel>();
            _storePlaceController = storePlaceController;
            _parcelController = parcelController;
            InitializeComponent();
        }

        public void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            chooseStorePlaceCombobox.Items.Clear();
            _storePlacesDTO = _storePlaceController.GetAllWarehouses();

            if (_storePlacesDTO.Status == Api.Enums.CollectionGetStatus.Success)
            {
                foreach (var storePlace in _storePlacesDTO.StorePlaces)
                {
                    string storePlaceInfo = storePlace.Id + " " + storePlace.Name;
                    chooseStorePlaceCombobox.Items.Add(storePlaceInfo);
                }
            }

            ////foreach (var parcel in parcels)
            ////{
            ////    string[] parcelInfo = { parcel.Id.ToString(),
            ////        parcel.SenderData.PersonalAddress.Street +", "+
            ////        parcel.SenderData.PersonalAddress.ApartmentNumber+"/"+
            ////        parcel.SenderData.PersonalAddress.HomeNumber + ", "+
            ////        parcel.SenderData.PersonalAddress.PostCode+" "+
            ////        parcel.SenderData.PersonalAddress.City,
            ////    parcel.ReceiverData.PersonalAddress.Street +", "+
            ////        parcel.ReceiverData.PersonalAddress.ApartmentNumber+"/"+
            ////        parcel.ReceiverData.PersonalAddress.HomeNumber + ", "+
            ////        parcel.ReceiverData.PersonalAddress.PostCode+" "+
            ////        parcel.ReceiverData.PersonalAddress.City};
            ////    parcelsListView.Items.Add(new ListViewItem(parcelInfo));
            ////    _availableParcels.Add(parcelsListView.Items[parcelsListView.Items.Count-1]);
            ////}
            //if (_employeeController.GetLoggedEmployee() != null)
            //{
            //    chooseVehicleTextbox.Text = "Id pracownika: " + _employeeController.GetLoggedEmployee().Id +
            //    " Magazyn: " + "controller.getStorePlaceForEmployee(id).Id";
            //}

            //string[] parcelInfo1 = { "1", "abc", "def" };
            //string[] parcelInfo2 = { "2", "def", "ghi" };

            //parcelsListView.Items.Add(new ListViewItem(parcelInfo1));
            //parcelsListView.Items.Add(new ListViewItem(parcelInfo2));

            //_availableParcels.Add(parcelsListView.Items[0]);
            //_availableParcels.Add(parcelsListView.Items[1]);

            ////StorePlace storePlace = employeeController.GetemployeesStorePlace(_employeeController.GetLoggedEmployee());
            ////List<Parcel> parcels = parcelController.GetParcelsByStorePlace(storePlace);

            ////foreach (var parcel in parcels)
            ////{
            ////    string[] parcelInfo = { parcel.Id.ToString(),
            ////        parcel.SenderData.PersonalAddress.Street +", "+
            ////        parcel.SenderData.PersonalAddress.ApartmentNumber+"/"+
            ////        parcel.SenderData.PersonalAddress.HomeNumber + ", "+
            ////        parcel.SenderData.PersonalAddress.PostCode+" "+
            ////        parcel.SenderData.PersonalAddress.City,
            ////    parcel.ReceiverData.PersonalAddress.Street +", "+
            ////        parcel.ReceiverData.PersonalAddress.ApartmentNumber+"/"+
            ////        parcel.ReceiverData.PersonalAddress.HomeNumber + ", "+
            ////        parcel.ReceiverData.PersonalAddress.PostCode+" "+
            ////        parcel.ReceiverData.PersonalAddress.City};
            ////    parcelsListView.Items.Add(new ListViewItem(parcelInfo));
            ////    _availableParcels.Add(parcelsListView.Items[parcelsListView.Items.Count-1]);
            ////}

            ////load Vehicles to combobox

            ////List<Vehicles> vechicles = _vehicleController.getVehiclesByStorePlace(controller.getStorePlaceForEmployee(id).Id);

            //_availableVehicles.Clear();

            //Vehicle v = new Vehicle();
            //v.Brand = "MAN";
            //v.Model = "TGX";
            //v.Registration = "EPD3G53";

            //Vehicle v1 = new Vehicle();
            //v1.Brand = "MAN";
            //v1.Model = "TGL";
            //v1.Registration = "EPD3G54";

            //_availableVehicles.Add(v);
            //_availableVehicles.Add(v1);

            //foreach (var vehicle in _availableVehicles)
            //{
            //    string vehicleInfo = vehicle.Brand + " " + vehicle.Model;
            //    chooseVehicleCombobox.Items.Add(vehicleInfo);
            //}

            //if (_availableVehicles.Count != 0)
            //{
            //    //chooseVehicleCombobox.SelectedItem = chooseVehicleCombobox.Items[0];
            //}
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            parcelsListView.Items.Clear();

            List<Parcel> sortedParcels;

            sortedParcels = _sortController.Sort(_parcels);

            parcelsListView.Items.Clear();

            foreach (var parcel in sortedParcels)
            {
                string[] parcelInfo = { parcel.Id.ToString(),
                    parcel.SenderData.PersonalAddress.Street +", "+
                    parcel.SenderData.PersonalAddress.ApartmentNumber+"/"+
                    parcel.SenderData.PersonalAddress.HomeNumber + ", "+
                    parcel.SenderData.PersonalAddress.PostCode+" "+
                    parcel.SenderData.PersonalAddress.City,
                parcel.ReceiverData.PersonalAddress.Street +", "+
                    parcel.ReceiverData.PersonalAddress.ApartmentNumber+"/"+
                    parcel.ReceiverData.PersonalAddress.HomeNumber + ", "+
                    parcel.ReceiverData.PersonalAddress.PostCode+" "+
                    parcel.ReceiverData.PersonalAddress.City};
                parcelsListView.Items.Add(new ListViewItem(parcelInfo));
            }
        }

        private void ParcelListView_ItemSelectionChanged(object sender, EventArgs e)
        {
            buttonPost.Enabled = parcelsListView.SelectedItems.Count > 0;
        }

        private void ChooseStorePlaceCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Parcel[] parcels = _parcelController.GetParcelsByStorePlace(
                _storePlaceController.GetById(int.Parse(
                    chooseStorePlaceCombobox.SelectedItem.ToString().
                    Substring(0, chooseStorePlaceCombobox.SelectedItem.ToString().IndexOf(" ")))));


            parcelsListView.Items.Clear();
            _parcels.Clear();

            foreach(Parcel parcel in parcels)
            {
                _parcels.Add(parcel);
            }

            if (chooseStorePlaceCombobox.SelectedItem != null)
            {
                foreach (var parcel in _parcels)
                {
                    string[] parcelInfo = { parcel.Id.ToString(),
                        parcel.SenderData.PersonalAddress.Street +", "+
                        parcel.SenderData.PersonalAddress.ApartmentNumber+"/"+
                        parcel.SenderData.PersonalAddress.HomeNumber + ", "+
                        parcel.SenderData.PersonalAddress.PostCode+" "+
                        parcel.SenderData.PersonalAddress.City,
                    parcel.ReceiverData.PersonalAddress.Street +", "+
                        parcel.ReceiverData.PersonalAddress.ApartmentNumber+"/"+
                        parcel.ReceiverData.PersonalAddress.HomeNumber + ", "+
                        parcel.ReceiverData.PersonalAddress.PostCode+" "+
                        parcel.ReceiverData.PersonalAddress.City,
                        parcel.ParcelHeight.ToString(),
                        parcel.ParcelLength.ToString(),
                        parcel.ParcelWidth.ToString(),
                        parcel.ParcelWeight.ToString(),
                        parcel.Priority.ToString(),
                        parcel.ParcelType
                    };
                    parcelsListView.Items.Add(new ListViewItem(parcelInfo));
                }
            }

            string[] parcelInfo1 = { "12",
                        "test, "+
                        "12/"+
                        "12, ",
                    "test"};
                    parcelsListView.Items.Add(new ListViewItem(parcelInfo1));

            string[] parcelInfo2 = { "12",
                        "abc, "+
                        "12/"+
                        "12, ",
                    "abc"};
            parcelsListView.Items.Add(new ListViewItem(parcelInfo2));

            //buttonLoad.Enabled = chooseStorePlaceCombobox.SelectedItem != null;

            //foreach (ListViewItem parcel in parcelsListView.Items)
            //{
            //    parcel.Selected = false;

            //    if (!_availableParcels.Contains(parcel))
            //    {
            //        parcelsListView.Items.Remove(parcel);
            //    }
            //}

            //if (chooseStorePlaceCombobox.SelectedItem != null && vehiclesCargoDictionary.ContainsKey(_availableVehicles[chooseStorePlaceCombobox.SelectedIndex]))
            //{
            //    foreach (ListViewItem item in vehiclesCargoDictionary[_availableVehicles[chooseStorePlaceCombobox.SelectedIndex]])
            //    {
            //        parcelsListView.Items.Add(item);
            //        item.Selected = true;
            //    }
            //}

            ////if (chooseVehicleCombobox.SelectedItem != null && vehiclesCargoDictionary.ContainsKey(_availableVehicles[chooseVehicleCombobox.SelectedIndex]))
            ////{
            ////    foreach(ListViewItem parcel in parcelsListView.Items)
            ////    {
            ////        if (vehiclesCargoDictionary[_availableVehicles[chooseVehicleCombobox.SelectedIndex]].
            ////            Contains(parcel))
            ////        {
            ////            parcel.Selected = true;
            ////        }
            ////    }
            ////}

            //parcelsListView.Select();
        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            //nadawanie przesyłek
            if ( _employeeController.GetLoggedEmployee() != null)
            {
                parcelsListView.SelectedItems[0].SubItems[0].Text = _employeeController.GetLoggedEmployee().Id.ToString();
            }
            else
            {
                parcelsListView.SelectedItems[0].SubItems[0].Text = "null";
            }

            //for(int i=0; i < parcelsListView.SelectedItems.Count; i++)
            //{
            //    _parcelController.PostParcel(,parcelsListView.SelectedItems[i].SubItems[1],
            //        parcelsListView.SelectedItems[i].SubItems[2],
            //        parcelsListView.SelectedItems[i].SubItems[3],
            //        parcelsListView.SelectedItems[i].SubItems[4],
            //        parcelsListView.SelectedItems[i].SubItems[5],
            //        parcelsListView.SelectedItems[i].SubItems[6],
            //        parcelsListView.SelectedItems[i].SubItems[7],
            //        parcelsListView.SelectedItems[i].SubItems[8])
            //}
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = _availableVehicles[chooseStorePlaceCombobox.SelectedIndex];

            if (vehiclesCargoDictionary.ContainsKey(selectedVehicle))
            {
                _availableParcels.AddRange(vehiclesCargoDictionary[selectedVehicle]);
            }

            vehiclesCargoDictionary.Remove(selectedVehicle);

            List<ListViewItem> items = new List<ListViewItem>();

            foreach(ListViewItem item in parcelsListView.SelectedItems)
            {
                items.Add(item);
                _availableParcels.Remove(item);
            }

            vehiclesCargoDictionary.Add(selectedVehicle, items);

            parcelsListView.Select();
        }
    }
}
