using Api.Controllers;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace View
{
    public partial class ParcelRegistrationForm : Form
    {
        private readonly ParcelController _parcelController;

        public ParcelRegistrationForm(ParcelController parcelController)
        {
            _parcelController = parcelController;
            InitializeComponent();
        }

        private void ParcelRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void OnParcelAddClick(object sender, EventArgs e)
        {
            ValidateData();
            SendData();
        }

        private void SendData()
        {
            Parcel parcelToAdd = new Parcel
            {
                SenderData = new PersonalData
                {
                    FirstName = senderFirstNameTextBox.Text

                },
            };
        }

        private bool ValidateData()
        {
            // First / Last name validity
            Regex nameRegex = new Regex(@"\w");

            if (!nameRegex.IsMatch(senderFirstNameTextBox.Text))
            {
                senderFirstNameTextBox.BackColor = Color.Red;
                senderFirstNameTextBox.ForeColor = Color.White;
                return false;
            }
            else
            {
                senderFirstNameTextBox.BackColor = Color.White;
                senderFirstNameTextBox.ForeColor = Color.Black;
            }



            return true;
        }
    };
}

