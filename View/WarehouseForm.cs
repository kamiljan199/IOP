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

        public WarehouseForm(EmployeeController employeeController, SortController sortController)
        {
            _employeeController = employeeController;
            _sortController = sortController;
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
                textBox1.Text = "Id pracownika: " + _employeeController.GetLoggedEmployee().Id +
                " Magazyn: " + "controller.getStorePlaceForEmployee(id).Id";
            }

            string[] parcelInfo1 = { "1", "abc", "def" };
            string[] parcelInfo2 = { "2", "def", "ghi" };
            parcelsListView.Items.Add(new ListViewItem(parcelInfo1));
            parcelsListView.Items.Add(new ListViewItem(parcelInfo2));

            //List<Parcel> parcels = parcelController.getParcelsByStoreId(storeId).asList();

            //foreach(var parcel in parcels)
            //{
            //    string[] parcelInfo = { parcel.Id, parcel.SenderData.PersonalAddress.Street,
            //    parcel.ReceiverData.PersonalAddress.Street};
            //    parcelsListView.Items.Add(new ListViewItem(parcelInfo));
            //}
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

            //List<Parcel> parcels = parcelController.getParcelsByStoreId(storeId);
            List<Parcel> sortedParcels;
            sortedParcels = _sortController.Sort(parcels);

            foreach (var parcel in sortedParcels)
            {
                string[] parcelInfo = { parcel.Id.ToString(),
                    parcel.SenderData.PersonalAddress.Street,
                parcel.ReceiverData.PersonalAddress.Street};
                parcelsListView.Items.Add(new ListViewItem(parcelInfo));
            }
        }

        private void ParcelListView_ItemSelectionChanged(object sender, EventArgs e)
        {
            buttonPost.Enabled = parcelsListView.SelectedItems.Count > 0;
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
    }
}
