using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class HrForm : Form
    {
        private readonly PositionListForm _positionListForm;
        private readonly EmployeeListForm _employeeListForm;
        private readonly VehicleListForm _vehicleListForm;

        public HrForm(PositionListForm positionListForm, EmployeeListForm employeeListForm, VehicleListForm vehicleListForm)
        {
            _positionListForm = positionListForm;
            _employeeListForm = employeeListForm;
            _vehicleListForm = vehicleListForm;
            InitializeComponent();
        }

        private void HrForm_Load(object sender, EventArgs e)
        {

        }

        private void PositionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _positionListForm.ShowDialog();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _employeeListForm.ShowDialog();
        }

        private void VehiclesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _vehicleListForm.ShowDialog();
        }
    }
}
