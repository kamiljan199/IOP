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
        private List<int> courierParcels = new List<int>();
        private EmployeeController _employeeController;
        private Employee _empolyee;
        public bool isClosed = false;
        private IStorePlaceService _storePlaceService;
        private ParcelController _parcelController;
       
        public CourierForm(IStorePlaceService storePlaceService, ParcelController parcelController, EmployeeController employeeController, Employee employee)
        {
            _storePlaceService = storePlaceService;
            _parcelController = parcelController;
            _employeeController = employeeController;
            _empolyee = employee;

            _empolyee = _employeeController.GetLoggedEmployee();
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                courierParcels.Add(i);
            }

            
            for (int i = 0; i < _storePlaceService.GetCouriersParcels(_empolyee.ActiveEmployments, _empolyee.Id).Count; i++)
            {
                listBox1.Items.Add(_storePlaceService.GetCouriersParcels(_empolyee.ActiveEmployments, _empolyee.Id)[i]);
            }
        }



        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            _employeeController.Logout();
            this.Close();
            isClosed = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < _storePlaceService.GetCouriersParcels(_empolyee.ActiveEmployments, _empolyee.Id).Count; i++)
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
           // buttonLogout.Enabled = false;  
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
