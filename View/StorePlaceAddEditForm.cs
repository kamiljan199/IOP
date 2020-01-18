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
            if(storePlace.Type != -1)
            {
                storePlace = _storePlaceController.GetByIdWithAddress(storePlace.Id);
                textBoxStorePlaceName.Text = storePlace.Name;

                textBoxCity.Text = storePlace.Address.City;
                textBoxPostCode.Text = storePlace.Address.PostCode;
                textBoxStreet.Text = storePlace.Address.Street;
                textBoxHomeNumber.Text = storePlace.Address.ApartmentNumber.ToString();
            }

            switch(storePlace.Type)
            {
                case -1:
                case 0:

                    var warehouse = storePlace as Warehouse;
                    
                    comboBoxStorePlaceType.SelectedIndex = 0;

                    labelStorePlaceDetail.Text = "Menadżer";
                    counterSendingPointWorkersCount.Enabled = false;
                    counterSendingPointWorkersCount.Visible = false;
                    textBoxWarehouseManagerName.Enabled = true;
                    textBoxWarehouseManagerName.Visible = true;

                    if(storePlace.Type != -1)
                    {
                        textBoxWarehouseManagerName.Text = warehouse.ManagerName;
                    }

                    break;

                case 1:

                    var sendingPoint = storePlace as SendingPoint;

                    labelStorePlaceDetail.Text = "Ilość pracowników";
                    textBoxWarehouseManagerName.Enabled = false;
                    textBoxWarehouseManagerName.Visible = false;
                    counterSendingPointWorkersCount.Enabled = true;
                    counterSendingPointWorkersCount.Visible = true;
                    counterSendingPointWorkersCount.Value = sendingPoint.WorkersCount;

                    break;
            }
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StorePlace editedStorePlace = null;
            var address = new Address
            {
                City = textBoxCity.Text,
                PostCode = textBoxPostCode.Text,
                Street = textBoxStreet.Text,
                ApartmentNumber = Int32.Parse(textBoxHomeNumber.Text)
            };

            switch(comboBoxStorePlaceType.SelectedIndex)
            {
                case 0:
                    editedStorePlace = new Warehouse()
                    {
                        Name = textBoxStorePlaceName.Text,
                        Address = address,
                        ManagerName = textBoxStorePlaceManagerName.Text,
                        Type = 0
                    };

                    break;

                case 1:
                    editedStorePlace = new SendingPoint()
                    {
                        Name = textBoxStorePlaceName.Text,
                        Address = address,
                        WorkersCount = (int) counterSendingPointWorkersCount.Value,
                        Type = 1
                    };

                    break;
            }

            if(storePlace.Type == -1)
            {
                _storePlaceController.AddStoreplace(editedStorePlace);
            }
            else
            {
                editedStorePlace.Id = storePlace.Id;
                _storePlaceController.UpdateStoreplace(editedStorePlace);
            }
        }
    }
}
