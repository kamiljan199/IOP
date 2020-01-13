using Api.Controllers;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class EmployeeAddEditForm : Form
    {
        public Employee employee;

        private readonly EmployeeController _employeeController;

        public EmployeeAddEditForm(EmployeeController employeeController)
        {
            _employeeController = employeeController;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee.Name = nameTextBox.Text;
            employee.Surname = surnameTextBox.Text;
            employee.Pesel = peselTextBox.Text;
            employee.Birthday = DateTime.Parse(birthdayTextBox.Text);
            employee.Login = loginTextbox.Text;
            if (employee.Id.Equals(0))
            {
                employee.Password = passwordTextBox.Text;
                _employeeController.AddEmployee(employee, true);
            }
            else
            {
                bool IsPasswordModified = false;
                if (passwordTextBox.Text.Length > 0)
                {
                    employee.Password = passwordTextBox.Text;
                    IsPasswordModified = true;
                }
                _employeeController.UpdateEmployee(employee, IsPasswordModified);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeAddEditForm_Load(object sender, EventArgs e)
        {
            if (!employee.Id.Equals(0))
            {
                nameTextBox.Text = employee.Name;
                surnameTextBox.Text = employee.Surname;
                peselTextBox.Text = employee.Pesel;
                birthdayTextBox.Text = employee.Birthday.ToString();
                loginTextbox.Text = employee.Login;
                passwordInfoLabel.Visible = true;
            } else
            {
                passwordInfoLabel.Visible = false;
            }
        }

        private void EmployeeAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
