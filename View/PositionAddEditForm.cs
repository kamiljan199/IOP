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
    public partial class PositionAddEditForm : Form
    {
        public Position position;

        private readonly PositionController _positionController;
        public PositionAddEditForm(PositionController positionController)
        {
            _positionController = positionController;
            InitializeComponent();
        }

        private void PositionAddEditForm_Load(object sender, EventArgs e)
        {
            if (!position.Id.Equals(0))
            {
                nameTextBox.Text = position.Name;
                minSalaryTextBox.Text = position.MinSalary.ToString();
                maxSalaryTextBox.Text = position.MaxSalary.ToString();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            position.Name = nameTextBox.Text;
            try
            {
                position.MinSalary = float.Parse(minSalaryTextBox.Text);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                Console.WriteLine("Minimal salary set to default - 500");
                position.MinSalary = 500.0f;
            }
            try
            {
                position.MaxSalary = float.Parse(maxSalaryTextBox.Text);
            }            
             catch (FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                Console.WriteLine("Maximal salary set to default - 1000");
                position.MaxSalary = 1000.0f;
            }
            if (position.MinSalary > position.MaxSalary)
            {
                Console.WriteLine("Minimal salary cannot be greater than maximal - now they are equal");
                position.MinSalary = position.MaxSalary;
            }
                
            if (position.Id.Equals(0))
            {
                _positionController.AddPosition(position, true);
            } else
            {
                _positionController.UpdatePosition(position);
            }
            this.Close();
        }

        private void PositionAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
