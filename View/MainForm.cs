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
        private readonly Api.Controllers.ParcelController _parcelController;
        private readonly LoginForm _loginForm;

        public MainForm(LoginForm loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void ButtonOpenLoginWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginForm.ShowDialog();
            
            if(_loginForm.isClosed == true)
            {
                textBoxInsertNumber.Text = "";
                TextBoxInsertNumber_Leave(sender, e);
                this.Show();
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

        private int ConvertStringToInt(string intString)
        {
            int i = 0;
            if (!Int32.TryParse(intString, out i))
            {
                i = -1;
            }
            return i;
        }

        private void ButtonCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(textBoxInsertNumber.Text == "") && !(textBoxInsertNumber.Text == "Wpisz numer przesyłki"))
                {
                    labelStatus.Text = _parcelController.GetParcelStatusById(ConvertStringToInt(textBoxInsertNumber.Text)).ToString();              
                }
            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message);
                labelStatus.Text = "Brak przesyłki o podanym numerze";
            }        
        }  
    }     
}
