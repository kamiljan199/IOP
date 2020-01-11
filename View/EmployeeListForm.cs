using Api.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class EmployeeListForm : Form
    {
        private readonly EmployeeController _employeeController;
        private readonly EmployeeAddEditForm _employeeAddEditFOrm;

        private Api.DTOs.EmployeesDTO _employeesDTO;
        public EmployeeListForm(EmployeeController employeeController, EmployeeAddEditForm employeeAddEditFOrm)
        {
            _employeeController = employeeController;
            _employeeAddEditFOrm = employeeAddEditFOrm;
            _employeeAddEditFOrm.FormClosed += delegate { SynchronizeEmployees(); };
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            SynchronizeEmployees();
        }

        private void SynchronizeEmployees()
        {
            _employeesDTO = _employeeController.GetAllEmployees();

            listView1.Items.Clear();
            foreach (var e in _employeesDTO.Employees)
            {
                string[] lv = { e.Id.ToString(), e.Name, e.Surname, e.Pesel, e.Birthday.ToString(), (e.ActiveEmployment == null) ? "Nie" : "Tak" };
                listView1.Items.Add(new ListViewItem(lv));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrane rekordy?", "Potwierdzenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (ListViewItem s in listView1.SelectedItems)
                {
                    _employeeController.RemoveEmployee(((List<Model.Models.Employee>)_employeesDTO.Employees)[listView1.Items.IndexOf(s)]);
                }
                SynchronizeEmployees();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _employeeAddEditFOrm.employee = new Model.Models.Employee();
            _employeeAddEditFOrm.ShowDialog();
        }
    }
}
