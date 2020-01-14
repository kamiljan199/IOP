using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class PositionListForm : Form
    {
        private readonly Api.Controllers.PositionController _positionController;
        private readonly PositionAddEditForm _positionAddEditForm;

        private Api.DTOs.PositionsDTO _positionsDTO;

        public PositionListForm(Api.Controllers.PositionController positionController, PositionAddEditForm positionAddEditForm)
        {
            _positionController = positionController;
            _positionAddEditForm = positionAddEditForm;
            _positionAddEditForm.FormClosed += delegate { SynchronizePositions(); };
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listView1.SelectedItems.Count > 0;
            button3.Enabled = listView1.SelectedItems.Count > 0;
        }

        private void PositionListForm_Load(object sender, EventArgs e)
        {
            SynchronizePositions();
        }

        private void SynchronizePositions()
        {
            _positionsDTO = _positionController.GetAllPositions();

            listView1.Items.Clear();

            if (_positionsDTO.Positions != null)
            {
                foreach (var p in _positionsDTO.Positions)
                {
                    string[] lv = { p.Id.ToString(), p.Name, p.MinSalary.ToString(), p.MaxSalary.ToString() };
                    listView1.Items.Add(new ListViewItem(lv));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrane rekordy?", "Potwierdzenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (ListViewItem s in listView1.SelectedItems)
                {
                    _positionController.RemovePosition(_positionsDTO.Positions[listView1.Items.IndexOf(s)]);
                }
                SynchronizePositions();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _positionAddEditForm.position = new Model.Models.Position();
            _positionAddEditForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                _positionAddEditForm.position = _positionController.GetPositionById(_positionsDTO.Positions[listView1.Items.IndexOf(listView1.SelectedItems[0])].Id);
                _positionAddEditForm.ShowDialog();
            }
        }
    }
}
