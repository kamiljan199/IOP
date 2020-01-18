using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model.Models;
using Api.Controllers;

namespace View
{
    public partial class StorePlaceAddEditForm : Form
    {
        private readonly StorePlaceController _storePlaceController;
        public StorePlace storePlace;

        public StorePlaceAddEditForm(StorePlaceController storePlaceController)
        {
            _storePlaceController = storePlaceController;
            InitializeComponent();
        }

        private void labelStreet_Click(object sender, EventArgs e)
        {

        }

        private void labelAdressCity_Click(object sender, EventArgs e)
        {

        }

        private void StorePlaceAddEditForm_Load(object sender, EventArgs e)
        {
            textBoxStorePlaceName.Text = storePlace.Name;
        }
    }
}
