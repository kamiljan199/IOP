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
        public LoginForm _loginForm;

        public ModuleChoiceForm(CourierForm courierForm, LogisticsForm logisticsForm)
        {
            _courierForm = courierForm;
            _logisticsForm = logisticsForm;
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
            _courierForm.ShowDialog();
        }

      
        private void ModuleChoiceWindow_Load(object sender, EventArgs e)
        {
            if (_loginForm.textBoxUsername.Text == "Courier")
            {
                buttonOpenCourierWindow.Enabled = true;
            }
            if (_loginForm.textBoxUsername.Text == "Logistic")
            {
                buttonOpenLogisticsWindow.Enabled = true;
            }
            if (_loginForm.textBoxUsername.Text == "Warehouse")
            {
                buttonOpenWarehouseWindow.Enabled = true;
            }
            if (_loginForm.textBoxUsername.Text == "Registration")
            {
                buttonOpenPostingWindow.Enabled = true;
            }
            if (_loginForm.textBoxUsername.Text == "Admin")
            {
                buttonOpenWarehouseWindow.Enabled = true;
                buttonOpenLogisticsWindow.Enabled = true;
                buttonOpenCourierWindow.Enabled = true;
                buttonOpenPostingWindow.Enabled = true;
            }
        }
    }
}
