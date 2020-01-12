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
    public partial class CourierForm : Form
    {
        private List<int> test = new List<int>();
       
        public CourierForm()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                test.Add(i);
            }

            for(int i = 0; i < test.Count; i ++)
            {
                pickParcel.Items.Add(test[i]);
            }
        }



        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            // close choice window
            // show main window
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CourierWindow_Load(object sender, EventArgs e)
        {
            buttonLogout.Enabled = false;
            
        }

        private void changeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (changeStatus.SelectedIndex == 1)
            {
                buttonLogout.Enabled = true; // DZIAŁA
                // tutaj zamienić na ta ChangeStatus funkcję z ParcelStatus
            }
        }

       
        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void pickParcel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void changeStatusButton_Click(object sender, EventArgs e)// przycisk usunąć!
        //{
        //    if(changeStatus.SelectedIndex > 0)
        //    {
        //        string getChangedStatus = changeStatus.SelectedItem.ToString();
        //        MessageBox.Show(getChangedStatus);
        //    }

        //}
    }
}
