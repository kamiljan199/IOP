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
            position.MinSalary = float.Parse(minSalaryTextBox.Text);
            position.MaxSalary = float.Parse(maxSalaryTextBox.Text);
            if (position.Id.Equals(0))
            {
                _positionController.AddPosition(position);
            } else
            {
                _positionController.UpdatePosition(position);
            }
            this.Close();
        }
    }
}
