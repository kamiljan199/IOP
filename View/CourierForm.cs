using Api.Services;
using Api.Controllers;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CourierForm : Form
    {
        private List<int> courierParcels = new List<int>();
        public bool isClosed = false;
        private StorePlaceController _storePlaceController;
        private ParcelController _parcelController;
       
        public CourierForm(StorePlaceController storePlaceController, ParcelController parcelController)
        {
            _storePlaceController = storePlaceController;
            _parcelController = parcelController;
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                courierParcels.Add(i);
            }

            for(int i = 0; i < courierParcels.Count; i++)
            {
                pickParcel.Items.Add(courierParcels[i]);
            }
            //for (int i = 0; i < _storePlaceController.GetCouriersParcels().Count; i ++)
            //{
            //    //pickParcel.Items.Add(test[i]);
            //    //pickParcel.Items.Add(_storePlaceController.GetCouriersParcels()[i]);
            //}
        }



        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            isClosed = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CourierWindow_Load(object sender, EventArgs e)
        {
            changeStatus.Enabled = false;
            buttonLogout.Enabled = false;  
        }

        private void changeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < changeStatus.Items.Count; i++)
            {
                if (changeStatus.SelectedIndex == i)
                {
                    buttonLogout.Enabled = true;
                }
            }
            //if (changeStatus.SelectedIndex == 0)
            //{
            //}
            //if (changeStatus.SelectedIndex == 1)
            //{
            //    //_parcelController.ChangeParcelStatus(,ParcelStatus.AtPostingPoint);
            //}
        }

        private void pickParcel_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < courierParcels.Count; i++)
            {
                if(pickParcel.SelectedIndex == i)
                {
                    changeStatus.Enabled = true;
                }
            }
        }
       
        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
