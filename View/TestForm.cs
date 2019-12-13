using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Api.Controllers;
using Api.DTOs;
using Api.Enums;
using Model.ViewModels;

namespace View
{   
    public partial class TestForm : Form
    {
        private readonly TestController _testController;
        
        public TestForm(TestController testController)
        {
            _testController = testController;
            InitializeComponent();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            // most useless view model strikes again
            var testViewModel = new TestViewModel
            {
                PackageId = (int)idPicker.Value
            };

            // on daily basis we could as well use simple int here, but it was made for demontration purposes
            
            var queryResult = _testController.GetAndWritePackageDetailsById(testViewModel);

            if(queryResult.Status == TestStatus.Failure)
            {
                senderNameText.Text = "NONE";
                receiverNameText.Text = "NONE";
                storagePointIdText.Text = "NONE";
                return;
            }

            senderNameText.Text = queryResult.SenderName;
            receiverNameText.Text = queryResult.ReceiverName;
            storagePointIdText.Text = queryResult.StoragePointId.ToString();
        }
    }
}
