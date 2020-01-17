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
        private readonly StorePlaceController _storePlaceController;

        private StorePlacesDTO _storePlacesDTO;
        private PositionsDTO _positionsDTO;
        private EmploymentsDTO _employmentsDTO;

        public EmploymentForm(EmploymentController employmentController, EmployeeController employeeController, PositionController positionController, StorePlaceController storePlaceController)
        {
            _employmentController = employmentController;
            _employeeController = employeeController;
            _positionController = positionController;
            _storePlaceController = storePlaceController;
            InitializeComponent();
        }

        private void EmploymentForm_Load(object sender, EventArgs e)
        {
            SynchronizePositions();
            SynchronizeEmployments();
            SynchronizeStorePlaces();
            if (!Employment.Id.Equals(0))
            {
                var positionName = _positionsDTO.Positions.Find(p => { return p.Id.Equals(Employment.PositionId); }).Name;
                positionComboBox.SelectedIndex = _positionsDTO.Positions.FindIndex(p => { return p.Name.Equals(positionName); });
                if (Employment.StorePlaceId != null)
                {
                    warehouseComboBox.SelectedIndex = _storePlacesDTO.StorePlaces.FindIndex(s => { return s.Id.Equals(Employment.StorePlaceId); });
                }
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

        private void SynchronizeStorePlaces()
        {
            _storePlacesDTO = _storePlaceController.GetAllStorePlaces();
            warehouseComboBox.Items.Clear();

            if (_storePlacesDTO.StorePlaces != null)
            {
                foreach (var s in _storePlacesDTO.StorePlaces)
                {
                    warehouseComboBox.Items.Add(s.Name);
                }
            }
        }

        private void SynchronizeEmployments()
        {
            _employmentsDTO = _employmentController.GetAllEmploymentsByEmployeeId(Employee.Id);
            employmentListView.Items.Clear();

            if (_employmentsDTO.Employments != null)
            {
                foreach (var e in _employmentsDTO.Employments)
                {
                    if (!e.Id.Equals(Employment.Id))
                    {
                        var position = _positionsDTO.Positions.Find(p => p.Id.Equals(e.PositionId));
                        string[] lv = { e.Id.ToString(), (position != null) ? position.Name : "jak to tu jest to niefajnie", e.Salary.ToString(), e.StartDate.ToString(), e.EndDate.ToString(), e.StorePlaceId != null ? e.StorePlace.Name : "BRAK" };
                        employmentListView.Items.Add(new ListViewItem(lv));
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employment.PositionId = _positionsDTO.Positions.Find(p => { return p.Name.Equals(positionComboBox.SelectedItem.ToString()); }).Id;
            Employment.StorePlaceId = _storePlacesDTO.StorePlaces.Find(s => { return s.Name.Equals(warehouseComboBox.SelectedItem.ToString()); }).Id;
            Employment.Salary = float.Parse(salaryTextBox.Text);
            Employment.StartDate = DateTime.Parse(startDateTextBox.Text);
            Employment.EndDate = DateTime.Parse(endDateTextBox.Text);
            if (Employment.Id.Equals(0))
            {
                Employment.EmployeeId = Employee.Id;
                Employment.IsActive = true;
                _employmentController.CreateEmployment(Employment, true);
            }
            else
            {
                _employmentController.UpdateEmployment(Employment);
            }
            this.Close();
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            if (!Employment.Id.Equals(0))
            {
                _employmentController.DeactivateEmployment(Employment);
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

        private void EmploymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearForm();
        }
    }
}
