namespace View
{
    partial class WarehouseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.informationTextbox = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.parcelsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.vehicleSpaceTakenRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chooseVehicleTextbox = new System.Windows.Forms.TextBox();
            this.chooseVehicleCombobox = new System.Windows.Forms.ComboBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informationTextbox
            // 
            this.informationTextbox.Location = new System.Drawing.Point(12, 12);
            this.informationTextbox.Name = "informationTextbox";
            this.informationTextbox.ReadOnly = true;
            this.informationTextbox.Size = new System.Drawing.Size(556, 31);
            this.informationTextbox.TabIndex = 0;
            this.informationTextbox.Text = "Dane magazynu: ";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(724, 7);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(191, 41);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Wyloguj się";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(724, 324);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(190, 48);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sortuj";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // parcelsListView
            // 
            this.parcelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.parcelsListView.FullRowSelect = true;
            this.parcelsListView.HideSelection = false;
            this.parcelsListView.Location = new System.Drawing.Point(12, 86);
            this.parcelsListView.Name = "parcelsListView";
            this.parcelsListView.Size = new System.Drawing.Size(706, 286);
            this.parcelsListView.TabIndex = 3;
            this.parcelsListView.UseCompatibleStateImageBehavior = false;
            this.parcelsListView.View = System.Windows.Forms.View.Details;
            this.parcelsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ParcelListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adres nadawcy";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adres odbiorcy";
            this.columnHeader3.Width = 200;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(724, 140);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(191, 41);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Załaduj";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // vehicleSpaceTakenRichTextBox
            // 
            this.vehicleSpaceTakenRichTextBox.Enabled = false;
            this.vehicleSpaceTakenRichTextBox.Location = new System.Drawing.Point(724, 72);
            this.vehicleSpaceTakenRichTextBox.Name = "vehicleSpaceTakenRichTextBox";
            this.vehicleSpaceTakenRichTextBox.Size = new System.Drawing.Size(190, 62);
            this.vehicleSpaceTakenRichTextBox.TabIndex = 5;
            this.vehicleSpaceTakenRichTextBox.Text = "Ładowność: 0%\nPojemność: 0%";
            // 
            // chooseVehicleTextbox
            // 
            this.chooseVehicleTextbox.Enabled = false;
            this.chooseVehicleTextbox.Location = new System.Drawing.Point(12, 49);
            this.chooseVehicleTextbox.Name = "chooseVehicleTextbox";
            this.chooseVehicleTextbox.Size = new System.Drawing.Size(143, 31);
            this.chooseVehicleTextbox.TabIndex = 6;
            this.chooseVehicleTextbox.Text = "Wybierz pojazd:";
            // 
            // chooseVehicleCombobox
            // 
            this.chooseVehicleCombobox.FormattingEnabled = true;
            this.chooseVehicleCombobox.Location = new System.Drawing.Point(161, 47);
            this.chooseVehicleCombobox.Name = "chooseVehicleCombobox";
            this.chooseVehicleCombobox.Size = new System.Drawing.Size(197, 33);
            this.chooseVehicleCombobox.TabIndex = 7;
            this.chooseVehicleCombobox.SelectedValueChanged += new System.EventHandler(this.ChooseVehicleCombobox_SelectedValueChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(724, 274);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(190, 44);
            this.buttonPost.TabIndex = 8;
            this.buttonPost.Text = "Nadaj";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // WarehouseForm
            // 
            this.ClientSize = new System.Drawing.Size(938, 407);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.chooseVehicleCombobox);
            this.Controls.Add(this.chooseVehicleTextbox);
            this.Controls.Add(this.vehicleSpaceTakenRichTextBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.parcelsListView);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.informationTextbox);
            this.Name = "WarehouseForm";
            this.Load += WarehouseForm_Load;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox informationTextbox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListView parcelsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.RichTextBox vehicleSpaceTakenRichTextBox;
        private System.Windows.Forms.TextBox chooseVehicleTextbox;
        private System.Windows.Forms.ComboBox chooseVehicleCombobox;
        private System.Windows.Forms.Button buttonPost;
    }
}