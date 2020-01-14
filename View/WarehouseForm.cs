using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        public void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
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

            //List<Parcel> parcels = parcelController.getParcelsByStoreId(storeId);
            //List<Parcel> sortedParcels = parcelController.sort(parcels);

            //foreach (var parcel in parcels)
            //{
            //    string[] parcelInfo = { parcel.Id, parcel.SenderData.PersonalAddress.Street,
            //    parcel.ReceiverData.PersonalAddress.Street};
            //    parcelsListView.Items.Add(new ListViewItem(parcelInfo));
            //}
        }

        private void ParcelListView_ItemSelectionChanged(object sender, EventArgs e)
        {
            buttonPost.Enabled = parcelsListView.SelectedItems.Count > 0;
        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            //nadawanie przesyłek
        }
    }
}
