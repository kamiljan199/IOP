using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Api.Controllers;
using Model.Models;

namespace View
{
    public partial class WarehouseForm : Form
    {
        private readonly EmployeeController _employeeController;
        private readonly SortController _sortController;

        private List<Vehicle> _availableVehicles;
        private List<ListViewItem> _availableParcels;

        private Dictionary<Vehicle, List<ListViewItem>> vehiclesCargoDictionary;

        public WarehouseForm(EmployeeController employeeController, SortController sortController)
        {
            _employeeController = employeeController;
            _sortController = sortController;
            vehiclesCargoDictionary = new Dictionary<Vehicle, List<ListViewItem>>();
            _availableVehicles = new List<Vehicle>();
            _availableParcels = new List<ListViewItem>();
            InitializeComponent();
        }

        public void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            if (_employeeController.GetLoggedEmployee() != null)
            {
                chooseVehicleTextbox.Text = "Id pracownika: " + _employeeController.GetLoggedEmployee().Id +
                " Magazyn: " + "controller.getStorePlaceForEmployee(id).Id";
            }

            string[] parcelInfo1 = { "1", "abc", "def" };
            string[] parcelInfo2 = { "2", "def", "ghi" };

            parcelsListView.Items.Add(new ListViewItem(parcelInfo1));
            parcelsListView.Items.Add(new ListViewItem(parcelInfo2));

            _availableParcels.Add(parcelsListView.Items[0]);
            _availableParcels.Add(parcelsListView.Items[1]);

            //StorePlace storePlace = employeeController.GetemployeesStorePlace(_employeeController.GetLoggedEmployee());
            //List<Parcel> parcels = parcelController.GetParcelsByStorePlace(storePlace);

            //foreach (var parcel in parcels)
            //{
            //    string[] parcelInfo = { parcel.Id.ToString(),
            //        parcel.SenderData.PersonalAddress.Street +", "+
            //        parcel.SenderData.PersonalAddress.ApartmentNumber+"/"+
            //        parcel.SenderData.PersonalAddress.HomeNumber + ", "+
            //        parcel.SenderData.PersonalAddress.PostCode+" "+
            //        parcel.SenderData.PersonalAddress.City,
            //    parcel.ReceiverData.PersonalAddress.Street +", "+
            //        parcel.ReceiverData.PersonalAddress.ApartmentNumber+"/"+
            //        parcel.ReceiverData.PersonalAddress.HomeNumber + ", "+
            //        parcel.ReceiverData.PersonalAddress.PostCode+" "+
            //        parcel.ReceiverData.PersonalAddress.City};
            //    parcelsListView.Items.Add(new ListViewItem(parcelInfo));
            //    _availableParcels.Add(parcelsListView.Items[parcelsListView.Items.Count-1]);
            //}

            //load Vehicles to combobox

            //List<Vehicles> vechicles = _vehicleController.getVehiclesByStorePlace(controller.getStorePlaceForEmployee(id).Id);

            _availableVehicles.Clear();

            Vehicle v = new Vehicle();
            v.Brand = "MAN";
            v.Model = "TGX";
            v.Registration = "EPD3G53";

            Vehicle v1 = new Vehicle();
            v1.Brand = "MAN";
            v1.Model = "TGL";
            v1.Registration = "EPD3G54";

            _availableVehicles.Add(v);
            _availableVehicles.Add(v1);

            foreach (var vehicle in _availableVehicles)
            {
                string vehicleInfo = vehicle.Brand + " " + vehicle.Model;
                chooseVehicleCombobox.Items.Add(vehicleInfo);
            }

            if (_availableVehicles.Count != 0)
            {
                //chooseVehicleCombobox.SelectedItem = chooseVehicleCombobox.Items[0];
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            parcelsListView.Items.Clear();

            List<Parcel> parcels = new List<Parcel>();

            Address adressA = new Address();
            adressA.Street = "b";

            Address adressB = new Address();
            adressB.Street = "c";

            PersonalData dataAS = new PersonalData();
            dataAS.PersonalAddress = adressA;
            PersonalData dataAR = new PersonalData();
            dataAR.PersonalAddress = adressB;
            PersonalData dataBS = new PersonalData();
            dataBS.PersonalAddress = adressB;
            PersonalData dataBR = new PersonalData();
            dataBR.PersonalAddress = adressA;

            Parcel a = new Parcel();
            a.Id = 22;
            a.SenderData = dataAS;
            a.ReceiverData = dataAR;

            Parcel b = new Parcel();
            b.Id = 17;
            b.SenderData = dataBS;
            b.ReceiverData = dataBR;

            parcels.Add(a);
            parcels.Add(b);//getting our parcels

            List<Parcel> sortedParcels;
            sortedParcels = _sortController.Sort(parcels);

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
                _availableParcels.Add(new ListViewItem(parcelInfo));
            }
        }

        private void ParcelListView_ItemSelectionChanged(object sender, EventArgs e)
        {
            buttonPost.Enabled = parcelsListView.SelectedItems.Count > 0;
        }

        private void ChooseVehicleCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            buttonLoad.Enabled = chooseVehicleCombobox.SelectedItem != null;

            foreach (ListViewItem parcel in parcelsListView.Items)
            {
                parcel.Selected = false;

                if (!_availableParcels.Contains(parcel))
                {
                    parcelsListView.Items.Remove(parcel);
                }
            }

            if (chooseVehicleCombobox.SelectedItem != null && vehiclesCargoDictionary.ContainsKey(_availableVehicles[chooseVehicleCombobox.SelectedIndex]))
            {
                foreach (ListViewItem item in vehiclesCargoDictionary[_availableVehicles[chooseVehicleCombobox.SelectedIndex]])
                {
                    parcelsListView.Items.Add(item);
                    item.Selected = true;
                }
            }

            //if (chooseVehicleCombobox.SelectedItem != null && vehiclesCargoDictionary.ContainsKey(_availableVehicles[chooseVehicleCombobox.SelectedIndex]))
            //{
            //    foreach(ListViewItem parcel in parcelsListView.Items)
            //    {
            //        if (vehiclesCargoDictionary[_availableVehicles[chooseVehicleCombobox.SelectedIndex]].
            //            Contains(parcel))
            //        {
            //            parcel.Selected = true;
            //        }
            //    }
            //}

            parcelsListView.Select();
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
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = _availableVehicles[chooseVehicleCombobox.SelectedIndex];

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
