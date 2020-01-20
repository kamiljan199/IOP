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
                textBoxHomeNumber.Text = storePlace.Address.HomeNumber;
                textBoxApartmentNumber.Text = storePlace.Address.ApartmentNumber.ToString();
            }

            switch(storePlace.Type)
            {
                case -1:
                    comboBoxStorePlaceType.Enabled = true;
                    counterStorePlaceWorkersCount.Enabled = false;
                    textBoxWarehouseManagerName.Enabled = false;
                    break;
                case 0:

                    var warehouse = storePlace as Warehouse;
                    
                    comboBoxStorePlaceType.SelectedIndex = 0;
                    comboBoxStorePlaceType.Enabled = false;

                    counterStorePlaceWorkersCount.Enabled = false;
                    textBoxWarehouseManagerName.Enabled = true;

                    if(warehouse.ManagerName != null)
                    {
                        textBoxWarehouseManagerName.Text = warehouse.ManagerName;
                    }

                    break;

                case 1:

                    var sendingPoint = storePlace as SendingPoint;

                    comboBoxStorePlaceType.SelectedIndex = 1;
                    comboBoxStorePlaceType.Enabled = false;

                    textBoxWarehouseManagerName.Enabled = false;
                    counterStorePlaceWorkersCount.Enabled = true;
                    counterStorePlaceWorkersCount.Value = sendingPoint.WorkersCount;

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
                    else if(control is NumericUpDown)
                    {
                        (control as NumericUpDown).Value = 0;
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
            Address address;
            
            try
            {
                var apartmentNumber = Int32.Parse(textBoxApartmentNumber.Text);
                if(apartmentNumber < 0)
                {
                    throw new FormatException();
                }

                address = new Address
                {
                    City = textBoxCity.Text,
                    PostCode = textBoxPostCode.Text,
                    Street = textBoxStreet.Text,
                    HomeNumber = textBoxHomeNumber.Text,
                    ApartmentNumber = apartmentNumber
                };
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Numer domu jest nieujemną liczbą typu całkowitego. Wprowadzono nieprawidłową wartość.", "Nieprawidłowa wartość", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch(comboBoxStorePlaceType.SelectedIndex)
            {
                case 0:
                    editedStorePlace = new Warehouse()
                    {
                        Name = textBoxStorePlaceName.Text,
                        Address = address,
                        ManagerName = textBoxWarehouseManagerName.Text,
                        Type = 0
                    };

                    break;

                case 1:
                    editedStorePlace = new SendingPoint()
                    {
                        Name = textBoxStorePlaceName.Text,
                        Address = address,
                        WorkersCount = (int) counterStorePlaceWorkersCount.Value,
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
                editedStorePlace.AddressId = storePlace.AddressId;
                editedStorePlace.Address.Id = storePlace.AddressId;
                _storePlaceController.UpdateStoreplace(editedStorePlace);
            }

            this.Close();
        }

        private void comboBoxStorePlaceType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(comboBoxStorePlaceType.SelectedIndex)
            {
                case 0:

                    counterStorePlaceWorkersCount.Enabled = false;
                    textBoxWarehouseManagerName.Enabled = true;

                    if (storePlace.Type == 0)
                    {
                        textBoxWarehouseManagerName.Text = (storePlace as Warehouse).ManagerName;
                    }

                    break;

                case 1:

                    labelStorePlaceManager.Text = "Ilość pracowników";
                    textBoxWarehouseManagerName.Enabled = false;
                    counterStorePlaceWorkersCount.Enabled = true;

                    if(storePlace.Type == 1)
                    {
                        counterStorePlaceWorkersCount.Value = (storePlace as SendingPoint).WorkersCount;
                    }

                    break;
            }
        }
    }
}
