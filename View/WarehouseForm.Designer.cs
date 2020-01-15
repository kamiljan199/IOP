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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.storePlaceTextbox = new System.Windows.Forms.TextBox();
            this.parcelsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.buttonPost = new System.Windows.Forms.Button();
            this.chooseVehicleTextbox = new System.Windows.Forms.TextBox();
            this.chooseVehicleCombobox = new System.Windows.Forms.ComboBox();
            this.vehicleSpaceTakenRichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(568, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(173, 37);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(569, 271);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(172, 38);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Sortuj";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // storePlaceTextbox
            // 
            this.storePlaceTextbox.Enabled = false;
            this.storePlaceTextbox.Location = new System.Drawing.Point(15, 12);
            this.storePlaceTextbox.Name = "storePlaceTextbox";
            this.storePlaceTextbox.Size = new System.Drawing.Size(320, 31);
            this.storePlaceTextbox.TabIndex = 2;
            this.storePlaceTextbox.Text = "Id pracownika: Magazyn: ";
            // 
            // parcelsListView
            // 
            this.parcelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.parcelsListView.FullRowSelect = true;
            this.parcelsListView.HideSelection = false;
            this.parcelsListView.Location = new System.Drawing.Point(15, 109);
            this.parcelsListView.Name = "parcelsListView";
            this.parcelsListView.Size = new System.Drawing.Size(534, 289);
            this.parcelsListView.TabIndex = 3;
            this.parcelsListView.UseCompatibleStateImageBehavior = false;
            this.parcelsListView.View = System.Windows.Forms.View.Details;
            this.parcelsListView.SelectedIndexChanged += new System.EventHandler(this.ParcelListView_ItemSelectionChanged);
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
            // buttonPost
            // 
            this.buttonPost.Enabled = false;
            this.buttonPost.Location = new System.Drawing.Point(569, 315);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(172, 64);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Nadaj";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // chooseVehicleTextbox
            // 
            this.chooseVehicleTextbox.Enabled = false;
            this.chooseVehicleTextbox.Location = new System.Drawing.Point(15, 53);
            this.chooseVehicleTextbox.Name = "chooseVehicleTextbox";
            this.chooseVehicleTextbox.Size = new System.Drawing.Size(139, 31);
            this.chooseVehicleTextbox.TabIndex = 5;
            this.chooseVehicleTextbox.Text = "Wybierz pojazd:";
            // 
            // chooseVehicleCombobox
            // 
            this.chooseVehicleCombobox.FormattingEnabled = true;
            this.chooseVehicleCombobox.Location = new System.Drawing.Point(160, 51);
            this.chooseVehicleCombobox.Name = "chooseVehicleCombobox";
            this.chooseVehicleCombobox.Size = new System.Drawing.Size(229, 33);
            this.chooseVehicleCombobox.TabIndex = 6;
            this.chooseVehicleCombobox.SelectedValueChanged += new System.EventHandler(this.ChooseVehicleCombobox_SelectedValueChanged);
            // 
            // vehicleSpaceTakenRichTextBox
            // 
            this.vehicleSpaceTakenRichTextBox.Enabled = false;
            this.vehicleSpaceTakenRichTextBox.Location = new System.Drawing.Point(555, 90);
            this.vehicleSpaceTakenRichTextBox.Name = "vehicleSpaceTakenRichTextBox";
            this.vehicleSpaceTakenRichTextBox.Size = new System.Drawing.Size(185, 60);
            this.vehicleSpaceTakenRichTextBox.TabIndex = 8;
            this.vehicleSpaceTakenRichTextBox.Text = "Obciążenie: 0%\nPojemność: 0%";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Location = new System.Drawing.Point(574, 162);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(165, 37);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Załaduj";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // WarehouseForm
            // 
            this.ClientSize = new System.Drawing.Size(753, 410);
            this.Controls.Add(this.parcelsListView);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.vehicleSpaceTakenRichTextBox);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.chooseVehicleCombobox);
            this.Controls.Add(this.storePlaceTextbox);
            this.Controls.Add(this.chooseVehicleTextbox);
            this.Name = "WarehouseForm";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chooseVehicleTextbox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ListView parcelsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox storePlaceTextBox;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox storePlaceTextbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ComboBox chooseVehicleCombobox;
        private System.Windows.Forms.RichTextBox vehicleSpaceTakenRichTextBox;
        private System.Windows.Forms.Button buttonLoad;
    }
}