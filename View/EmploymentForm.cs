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
                var positionName = _positionsDTO.Positions.Find(p => { return p.Id.Equals(Employment.PositionId); }).Name;
                positionComboBox.SelectedIndex = _positionsDTO.Positions.FindIndex(p => { return p.Name.Equals(positionName); });
                //TODO: magazyny
                salaryTextBox.Text = Employment.Salary.ToString();
                startDateTextBox.Text = Employment.StartDate.ToString();
                endDateTextBox.Text = Employment.EndDate.ToString();
            }
            UpdateForks();
        }

        private void SynchronizePositions()
        {
            _positionsDTO = _positionController.GetAllPositions();
            positionComboBox.Items.Clear();

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
            employmentListView.Items.Clear();

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
            Employment.PositionId = _positionsDTO.Positions.Find(p => { return p.Name.Equals(positionComboBox.SelectedItem.ToString()); }).Id;
            //TODO: magazyny
            Employment.Salary = float.Parse(salaryTextBox.Text);
            Employment.StartDate = DateTime.Parse(startDateTextBox.Text);
            Employment.EndDate = DateTime.Parse(endDateTextBox.Text);
            if (Employment.Id.Equals(0))
            {
                Employment.EmployeeId = Employee.Id;
                Employment.IsActive = true;
                _employmentController.CreateEmployment(Employment);
                ClearForm();
            }
            else
            {
                //_positionController.UpdatePosition(position);
            }
            this.Close();
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            if (!Employment.Id.Equals(0))
            {
                _employmentController.DeactivateEmployment(Employment);
                ClearForm();
                this.Close();
            }
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

        private void UpdateForks()
        {
            if (positionComboBox.SelectedIndex > -1)
            {
                var position = _positionsDTO.Positions.Find(p => { return p.Name.Equals(positionComboBox.SelectedItem.ToString()); });
                forksxDLabel.Text = "( " + position.MinSalary + " - " + position.MaxSalary + " )";
            } else
            {
                forksxDLabel.Text = "( widełki )";
            }
        }

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForks();
        }
    }
}
