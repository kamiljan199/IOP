using Api.Controllers;
using Api.DTOs;
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
    public partial class EmploymentForm : Form
    {
        public Employee Employee;
        public Employment Employment;

        private readonly EmploymentController _employmentController;
        private readonly EmployeeController _employeeController;
        private readonly PositionController _positionController;
        //private readonly WarehousesDTO warehouseDTO;

        private PositionsDTO _positionsDTO;
        private EmploymentsDTO _employmentsDTO;
        public EmploymentForm(EmploymentController employmentController, EmployeeController employeeController, PositionController positionController)
        {
            _employmentController = employmentController;
            _employeeController = employeeController;
            _positionController = positionController;
            InitializeComponent();
        }

        private void EmploymentForm_Load(object sender, EventArgs e)
        {
            SynchronizePositions();
            SynchronizeEmployments();
            if (!Employment.Id.Equals(0))
            {
                positionComboBox.SelectedIndex = _positionsDTO.Positions.FindIndex(p => { return p.Name.Equals(Employment.Position.Name); });
                //TODO: magazyny
                salaryTextBox.Text = Employment.Salary.ToString();
                startDateTextBox.Text = Employment.StartDate.ToString();
                endDateTextBox.Text = Employment.EndDate.ToString();
            }
        }

        private void SynchronizePositions()
        {
            _positionsDTO = _positionController.GetAllPositions();

            if (_positionsDTO.Positions != null)
            {
                foreach (var p in _positionsDTO.Positions)
                {
                    positionComboBox.Items.Add(p.Name);
                }
            }
        }

        private void SynchronizeEmployments()
        {
            _employmentsDTO = _employmentController.GetAllEmploymentsByEmployee(Employee);

            if (_employmentsDTO.Employments != null)
            {
                foreach (var e in _employmentsDTO.Employments)
                {
                    if (!e.Id.Equals(Employment.Id))
                    {
                        string[] lv = { e.Id.ToString(), /*e.Position.Name*/ "TODO", e.Salary.ToString(), e.StartDate.ToString(), e.EndDate.ToString() }; //position = null
                        employmentListView.Items.Add(new ListViewItem(lv));
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employment.Position = _positionsDTO.Positions.Find(p => { return p.Name.Equals(positionComboBox.SelectedItem.ToString()); });
            //TODO: magazyny
            Employment.Salary = float.Parse(salaryTextBox.Text);
            Employment.StartDate = DateTime.Parse(startDateTextBox.Text);
            Employment.EndDate = DateTime.Parse(endDateTextBox.Text);
            if (Employment.Id.Equals(0))
            {
                //_employmentController.AddPosition(position);
                //Employment.EmployeeForeignKey = Employee.Id;
                Employment.EmployeeId = Employee.Id;
                _employmentController.CreateEmployment(Employment);
                //_employeeController.HireEmployee(Employee, Employment);
            }
            else
            {
                //_positionController.UpdatePosition(position);
            }
            this.Close();
        }
    }
}
