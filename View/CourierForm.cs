using Api.Services;
using Api.Controllers;
using Api.Enums;
using Model.Enums;
using Model.Models;
using Api.DTOs;
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
        private readonly EmployeeController _employeeController;
        //private readonly Employee _employee;
        public bool isClosed = false;
        private readonly StorePlaceController _storePlaceController;
        private readonly ParcelController _parcelController;
        private readonly Employment _employment;
        private readonly StorePlace _storePlace;
        private readonly ParcelsDTO _parcelsDTO;

        public CourierForm(StorePlaceController storePlaceController, ParcelController parcelController,EmployeeController employeeController)
        {
            _storePlaceController = storePlaceController;
            _parcelController = parcelController;
            _employeeController = employeeController;

            ///_employee = _employeeController.GetLoggedEmployee();
            if (employeeController.GetLoggedEmployee() != null)
            {
                _employment = employeeController.GetLoggedEmployee().ActiveEmployments[0];
                _storePlace = _storePlaceController.GetById(_employment.StorePlaceId);
                _parcelsDTO = _storePlaceController.GetCouriersParcels(_storePlace, employeeController.GetLoggedEmployee().Id);
                if (_parcelsDTO.Status == CollectionGetStatus.Success)
                {
                    for (int i = 0; i < _parcelsDTO.StorePlaces.Count; i++)
                    {
                        listBox1.Items.Add(_parcelsDTO.StorePlaces[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowe hasło lub login", "Błąd logowania", 0, MessageBoxIcon.Error);
            }

            InitializeComponent();
        }



        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            _employeeController.Logout();
            this.Close();
            isClosed = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < _parcelsDTO.StorePlaces.Count; i++)
            {
                if (listBox1.SelectedIndex == i)
                {
                    changeStatus.Enabled = true;
                    ParcelStatus status = _parcelController.GetParcelStatusById(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)));
                    switch (status)
                    {
                        case ParcelStatus.AtPostingPoint:
                            {
                                changeStatus.SelectedIndex = 0;
                                break;
                            }
                        case ParcelStatus.OnWayToWarehouse:
                            {
                                changeStatus.SelectedIndex = 1;
                                break;
                            }
                        case ParcelStatus.InWarehouse:
                            {
                                changeStatus.SelectedIndex = 2;
                                break;
                            }
                        case ParcelStatus.OnWayToTheCustomer:
                            {
                                changeStatus.SelectedIndex = 3;
                                break;
                            }
                        case ParcelStatus.Returned:
                            {
                                changeStatus.SelectedIndex = 4;
                                break;
                            }
                        case ParcelStatus.Delivered:
                            {
                                changeStatus.SelectedIndex = 5;
                                break;
                            }
                        default:
                            {
                                changeStatus.SelectedIndex = 6;
                                break;
                            }
                    }
                }
            }
        }
        private void CourierWindow_Load(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
            changeStatus.Enabled = false;
           
        }

        private int ConvertStringToInt(string intString)
        {
            int i = 0;
            if (!Int32.TryParse(intString, out i))
            {
                i = -1;
            }
            return i;
        }

        private void changeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (changeStatus.SelectedIndex)
            {
                case 0:
                    {
                        _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.AtPostingPoint);
                        break;
                    }
                case 1:
                    {
                        _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.OnWayToWarehouse);
                        break;
                    }
                case 2:
                    {
                        _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.InWarehouse);
                        break;
                    }
                case 3:
                    {
                        _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.OnWayToTheCustomer);
                        break;
                    }
                case 4:
                    {
                        _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.Returned);
                        break;
                    }
                case 5:
                    {
                        _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.Delivered);
                        break;
                    }
                default:
                    {
                        _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.Unknown);
                        break;
                    }

            }
        }

        private void pickParcel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }      
    }
}
