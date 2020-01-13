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
   
    public partial class ModuleChoiceForm : Form
    {
        private readonly CourierForm _courierForm;
        private readonly LogisticsForm _logisticsForm;
        private readonly HrForm _hrForm;
        public LoginForm _loginForm;

        public ModuleChoiceForm(CourierForm courierForm, LogisticsForm logisticsForm, HrForm hrForm)
        {
            _courierForm = courierForm;
            _logisticsForm = logisticsForm;
            _hrForm = hrForm;
            InitializeComponent();
        }   

        private void ButtonOpenPostingWindow_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonOpenWarehouseWindow_Click(object sender, EventArgs e)
        {

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
            if (_loginForm.textBoxUsername.Text == "Courier")
            {
                buttonOpenWarehouseWindow.Enabled = false;
                buttonOpenLogisticsWindow.Enabled = false;
                buttonOpenCourierWindow.Enabled = true;
                buttonOpenPostingWindow.Enabled = false;
                buttonOpenHRWindow.Enabled = false;
            }
            if (_loginForm.textBoxUsername.Text == "Logistic")
            {
                buttonOpenWarehouseWindow.Enabled = false;
                buttonOpenLogisticsWindow.Enabled = true;
                buttonOpenCourierWindow.Enabled = false;
                buttonOpenPostingWindow.Enabled = false;
                buttonOpenHRWindow.Enabled = false;
            }
            if (_loginForm.textBoxUsername.Text == "Warehouse")
            {
                buttonOpenWarehouseWindow.Enabled = true;
                buttonOpenLogisticsWindow.Enabled = false;
                buttonOpenCourierWindow.Enabled = false;
                buttonOpenPostingWindow.Enabled = false;
                buttonOpenHRWindow.Enabled = false;
            }
            if (_loginForm.textBoxUsername.Text == "Registration")
            {
                buttonOpenWarehouseWindow.Enabled = false;
                buttonOpenLogisticsWindow.Enabled = false;
                buttonOpenCourierWindow.Enabled = false;
                buttonOpenPostingWindow.Enabled = true;
                buttonOpenHRWindow.Enabled = false;
            }
            if (_loginForm.textBoxUsername.Text == "Admin")
            {
                buttonOpenWarehouseWindow.Enabled = true;
                buttonOpenLogisticsWindow.Enabled = true;
                buttonOpenCourierWindow.Enabled = true;
                buttonOpenPostingWindow.Enabled = true;
                buttonOpenHRWindow.Enabled = true;
            }
        }
    }
}
