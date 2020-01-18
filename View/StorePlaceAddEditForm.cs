using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model.Models;
using Api.Controllers;

namespace View
{
    public partial class StorePlaceAddEditForm : Form
    {
        private readonly StorePlaceController _storePlaceController;
        public StorePlace storePlace;

        public StorePlaceAddEditForm(StorePlaceController storePlaceController)
        {
            _storePlaceController = storePlaceController;
            InitializeComponent();
        }

        private void labelStreet_Click(object sender, EventArgs e)
        {

        }

        private void labelAdressCity_Click(object sender, EventArgs e)
        {

        }

        private void StorePlaceAddEditForm_Load(object sender, EventArgs e)
        {
            storePlace = _storePlaceController.GetByIdWithAddress(storePlace.Id);
            textBoxStorePlaceName.Text = storePlace.Name;
            
            switch(storePlace.GetType().Name)
            {
                case "StorePlace":
                case "Warehouse":

                    var warehouse = storePlace as Warehouse;
                    
                    comboBoxStorePlaceType.SelectedIndex = 0;

                    labelStorePlaceDetail.Text = "Menadżer";
                    counterSendingPointWorkersCount.Enabled = false;
                    counterSendingPointWorkersCount.Visible = false;
                    textBoxStorePlaceManagerName.Enabled = true;
                    textBoxStorePlaceManagerName.Visible = true;
                    textBoxStorePlaceManagerName.Text = warehouse.ManagerName;

                    break;

                case "SendingPoint":

                    var sendingPoint = storePlace as SendingPoint;

                    labelStorePlaceDetail.Text = "Ilość pracowników";
                    textBoxStorePlaceManagerName.Enabled = false;
                    textBoxStorePlaceManagerName.Visible = false;
                    counterSendingPointWorkersCount.Enabled = true;
                    counterSendingPointWorkersCount.Visible = true;
                    counterSendingPointWorkersCount.Value = sendingPoint.WorkersCount;

                    break;
            }

            textBoxCity.Text = storePlace.Address.City;
            textBoxPostCode.Text = storePlace.Address.PostCode;
            textBoxStreet.Text = storePlace.Address.Street;
            textBoxHomeNumber.Text = storePlace.Address.ApartmentNumber.ToString();
        }

        private void StorePlaceAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    {
                        (control as TextBox).Clear();
                    }
                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = -1;
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };

            func(Controls);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
