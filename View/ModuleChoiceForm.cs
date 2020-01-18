﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Api.Controllers;

namespace View
{
   
    public partial class ModuleChoiceForm : Form
    {
        private readonly EmployeeController _employeeController;
        private readonly CourierForm _courierForm;
        private readonly LogisticsForm _logisticsForm;
        private readonly HrForm _hrForm;
        private readonly WarehouseForm _warehouseForm;
        public LoginForm _loginForm;

        public ModuleChoiceForm(EmployeeController employeeController, CourierForm courierForm, LogisticsForm logisticsForm,
            HrForm hrForm, WarehouseForm warehouseForm)
        {
            _employeeController = employeeController;
            _courierForm = courierForm;
            _logisticsForm = logisticsForm;
            _hrForm = hrForm;
            _warehouseForm = warehouseForm;
            InitializeComponent();
        }   

        private void ButtonOpenPostingWindow_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonOpenWarehouseWindow_Click(object sender, EventArgs e)
        {
            _warehouseForm.ShowDialog();
        }

        private void ButtonOpenLogisticsWindow_Click(object sender, EventArgs e)
        {
            _logisticsForm.ShowDialog();
        }

        public void ButtonOpenCourierWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            _courierForm.ShowDialog();
        }

        private void ButtonOpenHRWindow_Click(object sender, EventArgs e)
        {
            _hrForm.ShowDialog();
        }
              
        private void ModuleChoiceWindow_Load(object sender, EventArgs e)
        {
            if (_employeeController.GetLoggedEmployee().ActiveEmployments.Where(em => em.Position.Name.Equals("Kurier")) != null)
            {
                buttonOpenWarehouseWindow.Enabled = false;
                buttonOpenLogisticsWindow.Enabled = false;
                buttonOpenCourierWindow.Enabled = true;
                buttonOpenPostingWindow.Enabled = false;
                buttonOpenHRWindow.Enabled = false;
            }
            else if (_employeeController.GetLoggedEmployee().ActiveEmployments.Where(em => em.Position.Name.Equals("Logistyk")) != null)
            {
                buttonOpenWarehouseWindow.Enabled = false;
                buttonOpenLogisticsWindow.Enabled = true;
                buttonOpenCourierWindow.Enabled = false;
                buttonOpenPostingWindow.Enabled = false;
                buttonOpenHRWindow.Enabled = false;
            }
            else if (_employeeController.GetLoggedEmployee().ActiveEmployments.Where(em => em.Position.Name.Equals("Magazynier")) != null)
            {
                buttonOpenWarehouseWindow.Enabled = true;
                buttonOpenLogisticsWindow.Enabled = false;
                buttonOpenCourierWindow.Enabled = false;
                buttonOpenPostingWindow.Enabled = false;
                buttonOpenHRWindow.Enabled = false;
            }
            else if (_employeeController.GetLoggedEmployee().ActiveEmployments.Where(em => em.Position.Name.Equals("Rejestracja")) != null)
            {
                buttonOpenWarehouseWindow.Enabled = false;
                buttonOpenLogisticsWindow.Enabled = false;
                buttonOpenCourierWindow.Enabled = false;
                buttonOpenPostingWindow.Enabled = true;
                buttonOpenHRWindow.Enabled = false;
            }
            else if(_employeeController.GetLoggedEmployee().ActiveEmployments.Where(em => em.Position.Name.Equals("HR")) != null)
            {
                buttonOpenWarehouseWindow.Enabled = false;
                buttonOpenLogisticsWindow.Enabled = false;
                buttonOpenCourierWindow.Enabled = false;
                buttonOpenPostingWindow.Enabled = false;
                buttonOpenHRWindow.Enabled = true;
            }
            else if (_employeeController.GetLoggedEmployee().ActiveEmployments.Where(em => em.Position.Name.Equals("Administrator")) != null)
            {
                buttonOpenWarehouseWindow.Enabled = true;
                buttonOpenLogisticsWindow.Enabled = true;
                buttonOpenCourierWindow.Enabled = true;
                buttonOpenPostingWindow.Enabled = true;
                buttonOpenHRWindow.Enabled = true;
            }
            else
            {
                buttonOpenWarehouseWindow.Enabled = false;
                buttonOpenLogisticsWindow.Enabled = false;
                buttonOpenCourierWindow.Enabled = false;
                buttonOpenPostingWindow.Enabled = false;
                buttonOpenHRWindow.Enabled = false;
            }
        }
    }
}
