using Api.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;
        private readonly ParcelController _parcelController;

        public MainForm(LoginForm loginForm, ParcelController parcelController)
        {
            _parcelController = parcelController;
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void ButtonOpenLoginWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginForm.ShowDialog();
            
            if(_loginForm.isClosed == true)
            {
                _loginForm.Hide();
                this.ShowDialog();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            TextBoxInsertNumber_Leave(sender, e);
            labelStatus.Text = "";
        }

        private void TextBoxInsertNumber_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxInsertNumber.Text))
            {
                textBoxInsertNumber.ForeColor = Color.Gray;
                textBoxInsertNumber.Text = "Wpisz numer przesyłki";
            }
            else
            {
                textBoxInsertNumber.ForeColor = Color.Black;
            }
        }

        private void TextBoxInsertNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxInsertNumber.Text == "Wpisz numer przesyłki")
            {
                textBoxInsertNumber.Text = "";
                textBoxInsertNumber.ForeColor = Color.Black;
            }
        }

        private void ButtonCheckStatus_Click(object sender, EventArgs e) // TO DO
        {
            try
            {
                if (!(textBoxInsertNumber.Text == "") && !(textBoxInsertNumber.Text == "Wpisz numer przesyłki"))
                {
                    labelStatus.Text = _parcelController.GetParcelStatusById(int.Parse(textBoxInsertNumber.Text)).ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }        
        }  
    }     
}
