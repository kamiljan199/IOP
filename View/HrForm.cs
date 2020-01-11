using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class HrForm : Form
    {
        private readonly PositionListForm _positionListForm;
        public HrForm(PositionListForm positionListForm)
        {
            _positionListForm = positionListForm;
            InitializeComponent();
        }

        private void HrForm_Load(object sender, EventArgs e)
        {

        }

        private void PositionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _positionListForm.ShowDialog();
        }
    }
}
