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
                //TODO:szyfr hasło
                _employeeController.AddEmployee(employee);
            }
            else
            {
                if (passwordTextBox.Text.Length > 0)
                {
                    //...
                }
                _employeeController.UpdateEmployee(employee);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeAddEditForm_Load(object sender, EventArgs e)
        {
            if (employee.Id != null)
            {
                nameTextBox.Text = employee.Name;
                surnameTextBox.Text = employee.Surname;
                peselTextBox.Text = employee.Pesel;
                birthdayTextBox.Text = employee.Birthday.ToString();
                loginTextbox.Text = employee.Login;
            }
        }
    }
}
