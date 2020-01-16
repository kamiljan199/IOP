using Api.Services;
using Api.Controllers;
using Model.Enums;
using Model.Models;
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
        private readonly Employee _employee;
        public bool isClosed = false;
        private readonly StorePlaceService _storePlaceService;
        private readonly ParcelController _parcelController;
        List<Parcel> courierParcels; 

        public CourierForm(StorePlaceService storePlaceService, ParcelController parcelController, EmployeeController employeeController)
        {
            _storePlaceService = storePlaceService;
            _parcelController = parcelController;
            _employeeController = employeeController;
            courierParcels = _storePlaceService.GetCouriersParcels(_storePlaceService.GetById(_employee.ActiveEmployments[0].WarehouseId), _employee.Id);

            _employee = _employeeController.GetLoggedEmployee();
           

            for (int i = 0; i < courierParcels.Count; i++)
            {
                listBox1.Items.Add(courierParcels[i]);
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
            for (int i = 0; i < courierParcels.Count; i++)
            {
                if (listBox1.SelectedIndex == i)
                {
                    changeStatus.Enabled = true;
                }
            }
        }
        private void CourierWindow_Load(object sender, EventArgs e)
        {
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

      
    }
}
