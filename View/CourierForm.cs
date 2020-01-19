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
        private  EmployeeController _employeeController;
        private  Employee _employee;
        public bool isClosed = false;
        private readonly StorePlaceController _storePlaceController;
        private readonly ParcelController _parcelController;
        private  Employment _employment;
        private  StorePlace _storePlace;
        private  ParcelsDTO _parcelsDTO;

        public CourierForm(StorePlaceController storePlaceController, ParcelController parcelController,EmployeeController employeeController)
        {
            _storePlaceController = storePlaceController;
            _parcelController = parcelController;
            _employeeController = employeeController;
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
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    radioButton5.Enabled = true;
                    radioButton6.Enabled = true;
                    radioButton7.Enabled = true;
                    ParcelStatus status = _parcelController.GetParcelStatusById(ConvertStringToInt(listBox1.Items[i].ToString()));
                    switch (status)
                    {
                        case ParcelStatus.AtPostingPoint:
                            {
                                radioButton1.Checked = true;
                                break;
                            }
                        case ParcelStatus.OnWayToWarehouse:
                            {
                                radioButton2.Checked = true;
                                break;
                            }
                        case ParcelStatus.InWarehouse:
                            {
                                radioButton3.Checked = true;
                                break;
                            }
                        case ParcelStatus.OnWayToTheCustomer:
                            {
                                radioButton4.Checked = true;
                                break;
                            }
                        case ParcelStatus.Returned:
                            {
                                radioButton5.Checked = true;
                                break;
                            }
                        case ParcelStatus.Delivered:
                            {
                                radioButton6.Checked = true;
                                break;
                            }
                        default:
                            {
                                radioButton7.Checked = true;
                                break;
                            }
                    }
                }
            }
        }
        private void CourierWindow_Load(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
            _employee = _employeeController.GetLoggedEmployee();
            if (_employee != null)
            {
                try
                {
                    listBox1.Items.Clear();
                    _employment = _employee.ActiveEmployments[0];
                    _storePlace = _employment.StorePlaceId != null ? _storePlaceController.GetById(_employment.StorePlaceId.GetValueOrDefault()) : null;
                    _parcelsDTO = _storePlaceController.GetCouriersParcels(_storePlace, _employee.Id);
                    if (_parcelsDTO.Status == CollectionGetStatus.Success)
                    {
                        for (int i = 0; i < _parcelsDTO.StorePlaces.Count; i++)
                        {
                            listBox1.Items.Add(_parcelsDTO.StorePlaces[i].Id);
                        }
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.AtPostingPoint);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.OnWayToWarehouse);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.InWarehouse);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.OnWayToTheCustomer);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.Returned);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.Delivered);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            _parcelController.ChangeParcelStatus(ConvertStringToInt(listBox1.GetItemText(listBox1.SelectedItem)), ParcelStatus.Unknown);
        }
    }
}
