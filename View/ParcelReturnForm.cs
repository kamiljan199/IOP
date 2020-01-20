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
    public partial class ParcelReturnForm : Form
    {
        private readonly ParcelController _parcelController;

        public ParcelReturnForm(ParcelController parcelController)
        {
            _parcelController = parcelController;
            InitializeComponent();
        }

        private void ParcelReturnForm_Load(object sender, EventArgs e)
        {

        }

        private void OnReturn(object sender, EventArgs e)
        {
            if (_parcelController.ReturnParcel(int.Parse(parcelIdTextBox.Text)))
            {
                parcelStatus.Text = "Sukces";
                parcelStatus.ForeColor = Color.White;
                parcelStatus.BackColor = Color.Green;
            }
            else
            {
                parcelStatus.Text = "Nie znaleziono";
                parcelStatus.ForeColor = Color.White;
                parcelStatus.BackColor = Color.Red;
            }
        }
    }
}
