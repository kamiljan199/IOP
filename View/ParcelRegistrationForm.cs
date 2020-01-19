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
        private bool isParcelDataValid = false;
        private string parcelType = "";

        public ParcelRegistrationForm(ParcelController parcelController)
        {
            _parcelController = parcelController;
            InitializeComponent();
            Console.WriteLine(parcelPriorityComboBox.SelectedIndex);
        }

        private void ParcelRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void OnParcelAddClick(object sender, EventArgs e)
        {
            bool isPersonalDataValid = ValidateData();

            if (isPersonalDataValid && isParcelDataValid)
                SendData();
        }

        private void UpdateParcelType(object sender, EventArgs e)
        {
            isParcelDataValid = true;

            if (parcelPriorityComboBox.SelectedIndex == -1)
                isParcelDataValid = false;

            double parcelWeight;
            if (!double.TryParse(parcelWeightTextBox.Text, out parcelWeight))
                isParcelDataValid = false;

            float x, y, z;

            if (!float.TryParse(parcelDimensionsXTextBox.Text, out x))
                isParcelDataValid = false;
            if (!float.TryParse(parcelDimensionsYTextBox.Text, out y))
                isParcelDataValid = false;
            if (!float.TryParse(parcelDimensionsZTextBox.Text, out z))
                isParcelDataValid = false;

            if (isParcelDataValid)
            {
                string type = _parcelController.GetParcelType(parcelWeight, x, y, z);

                parcelTypeBox.Text = type;
                parcelType = type;

                if (type == "A")
                    parcelTypeBox.BackColor = Color.Green;
                else if (type == "B")
                    parcelTypeBox.BackColor = Color.Orange;
                else if (type == "C")
                    parcelTypeBox.BackColor = Color.Blue;
                else if (type == "None")
                    parcelTypeBox.BackColor = Color.Red;
                else
                    parcelTypeBox.BackColor = Color.Gray;

                parcelPriorityComboBox.BackColor = Color.White;
                parcelPriorityComboBox.ForeColor = Color.Black;
                parcelWeightTextBox.BackColor = Color.White;
                parcelWeightTextBox.ForeColor = Color.Black;
                parcelDimensionsXTextBox.BackColor = Color.White;
                parcelDimensionsXTextBox.ForeColor = Color.Black;
                parcelDimensionsYTextBox.BackColor = Color.White;
                parcelDimensionsYTextBox.ForeColor = Color.Black;
                parcelDimensionsZTextBox.BackColor = Color.White;
                parcelDimensionsZTextBox.ForeColor = Color.Black;
            }
            else
            {
                parcelPriorityComboBox.BackColor = Color.Red;
                parcelPriorityComboBox.ForeColor = Color.White;
                parcelWeightTextBox.BackColor = Color.Red;
                parcelWeightTextBox.ForeColor = Color.White;
                parcelDimensionsXTextBox.BackColor = Color.Red;
                parcelDimensionsXTextBox.ForeColor = Color.White;
                parcelDimensionsYTextBox.BackColor = Color.Red;
                parcelDimensionsYTextBox.ForeColor = Color.White;
                parcelDimensionsZTextBox.BackColor = Color.Red;
                parcelDimensionsZTextBox.ForeColor = Color.White;
            }
        }

        private void SendData()
        {
            int? senderApartment, recieverApartment;
            int senderAp, recieverAp;
            if (int.TryParse(senderApartmentNumberTextBox.Text, out senderAp))
                senderApartment = senderAp;
            else
                senderApartment = null;

            if (int.TryParse(recieverApartmentNumberTextBox.Text, out recieverAp))
                recieverApartment = senderAp;
            else
                recieverApartment = null;


            Parcel parcelToAdd = new Parcel
            {
                SenderData = new PersonalData
                {
                    FirstName = senderFirstNameTextBox.Text,
                    LastName = senderLastNameTextBox.Text,
                    PhoneNumber = senderPhoneNumberTextBox.Text,
                    PersonalAddress = new Address
                    {
                        City = senderCityTextBox.Text,
                        PostCode = senderPostalCodeTextBox.Text,
                        Street = senderStreetTextBox.Text,
                        HomeNumber = senderHouseNumberTextBox.Text,
                        ApartmentNumber = senderApartment
                    }
                },
                ReceiverData = new PersonalData
                {
                    FirstName = recieverFirstNameTextBox.Text,
                    LastName = recieverLastNameTextBox.Text,
                    PhoneNumber = recieverPhoneNumberTextBox.Text,
                    PersonalAddress = new Address
                    {
                        City = recieverCityTextBox.Text,
                        PostCode = recieverPostalCodeTextBox.Text,
                        Street = recieverStreetTextBox.Text,
                        HomeNumber = recieverHouseNumberTextBox.Text,
                        ApartmentNumber = recieverApartment
                    }
                },
                ParcelHeight = float.Parse(parcelDimensionsXTextBox.Text),
                ParcelWidth = float.Parse(parcelDimensionsYTextBox.Text),
                ParcelLength = float.Parse(parcelDimensionsZTextBox.Text),
                ParcelType = parcelType,
                ParcelWeight = float.Parse(parcelWeightTextBox.Text),
                Priority = parcelPriorityComboBox.SelectedIndex,
            };

            if (_parcelController.PostParcel(parcelToAdd))
            {
                // Display success message and ask for label
            }
            else
            {
                // Display failure message
            }
        }

        private bool ValidateData()
        {
            bool isValid = true;
            // First / Last name validity

            if (!CheckNameValidity(senderFirstNameTextBox))
                isValid = false;

            if (!CheckNameValidity(senderLastNameTextBox))
                isValid = false;

            if (!CheckNameValidity(recieverFirstNameTextBox))
                isValid = false;

            if (!CheckNameValidity(recieverLastNameTextBox))
                isValid = false;

            if (!CheckPhoneNumberValidity(senderPhoneNumberTextBox))
                isValid = false;

            if (!CheckPhoneNumberValidity(recieverPhoneNumberTextBox))
                isValid = false;

            if (!CheckNameValidity(senderCityTextBox))
                isValid = false;

            if (!CheckNameValidity(recieverCityTextBox))
                isValid = false;

            if (!CheckNameValidity(senderStreetTextBox))
                isValid = false;

            if (!CheckNameValidity(recieverStreetTextBox))
                isValid = false;

            if (!CheckPostalCodeValidity(senderPostalCodeTextBox))
                isValid = false;

            if (!CheckPostalCodeValidity(recieverPostalCodeTextBox))
                isValid = false;

            if (!CheckHouseNumberValidity(senderHouseNumberTextBox))
                isValid = false;

            if (!CheckHouseNumberValidity(recieverHouseNumberTextBox))
                isValid = false;

            if (!CheckNumberValidity(senderApartmentNumberTextBox))
                isValid = false;

            if (!CheckNumberValidity(recieverApartmentNumberTextBox))
                isValid = false;

            return isValid;
        }

        private bool CheckNameValidity(TextBox textBox)
        {
            Regex nameRegex = new Regex(@"[^A-ZĄŻŹĆĘŁŃÓa-zążźćęłóń]+");
            if (nameRegex.IsMatch(textBox.Text) || textBox.Text.Length <= 0)
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.White;
                return false;
            }
            else
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                return true;
            }
        }

        private bool CheckPhoneNumberValidity(TextBox textBox)
        {
            Regex phoneRegex = new Regex(@"[^0-9]+");
            if (phoneRegex.IsMatch(textBox.Text) || textBox.Text.Length <= 0 || textBox.Text.Length > 9)
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.White;
                return false;
            }
            else
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                return true;
            }
        }

        private bool CheckPostalCodeValidity(TextBox textBox)
        {
            Regex postalRegex = new Regex(@"\d{2}-\d{3}");
            if (!postalRegex.IsMatch(textBox.Text))
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.White;
                return false;
            }
            else
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                return true;
            }

        }

        private bool CheckHouseNumberValidity(TextBox textBox)
        {
            Regex numberRegex = new Regex(@"\w+");
            if (!numberRegex.IsMatch(textBox.Text))
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.White;
                return false;
            }
            else
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                return true;
            }
        }

        private bool CheckNumberValidity(TextBox textBox)
        {
            Regex numberRegex = new Regex(@"[0-9]*");
            if (!numberRegex.IsMatch(textBox.Text))
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.White;
                return false;
            }
            else
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                return true;
            }
        }
    };
}

