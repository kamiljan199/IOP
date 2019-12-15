using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class LogisticsForm : Form
    {
        private readonly LogisticsNewRouteForm _form;
        public LogisticsForm(LogisticsNewRouteForm form)
        {
            _form = form;
            InitializeComponent();
        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            Application.Run(_form);
        }
    }
}
