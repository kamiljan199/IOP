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
            this.logoutButton = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.parcelsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.chooseStorePlaceCombobox = new System.Windows.Forms.ComboBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.chooseVehicleTextbox = new System.Windows.Forms.TextBox();
            this.chooseStorePlaceTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // chooseStorePlaceCombobox
            // 
            this.chooseStorePlaceCombobox.FormattingEnabled = true;
            this.chooseStorePlaceCombobox.Location = new System.Drawing.Point(187, 49);
            this.chooseStorePlaceCombobox.Name = "chooseStorePlaceCombobox";
            this.chooseStorePlaceCombobox.Size = new System.Drawing.Size(381, 33);
            this.chooseStorePlaceCombobox.TabIndex = 7;
            this.chooseStorePlaceCombobox.SelectedValueChanged += new System.EventHandler(this.ChooseStorePlaceCombobox_SelectedValueChanged);
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
            // chooseVehicleTextbox
            // 
            this.chooseVehicleTextbox.Enabled = false;
            this.chooseVehicleTextbox.Location = new System.Drawing.Point(12, 49);
            this.chooseVehicleTextbox.Name = "chooseVehicleTextbox";
            this.chooseVehicleTextbox.Size = new System.Drawing.Size(143, 31);
            this.chooseVehicleTextbox.TabIndex = 6;
            this.chooseVehicleTextbox.Text = "Wybierz pojazd:";
            // 
            // chooseStorePlaceTextbox
            // 
            this.chooseStorePlaceTextbox.Enabled = false;
            this.chooseStorePlaceTextbox.Location = new System.Drawing.Point(12, 49);
            this.chooseStorePlaceTextbox.Name = "chooseStorePlaceTextbox";
            this.chooseStorePlaceTextbox.Size = new System.Drawing.Size(160, 31);
            this.chooseStorePlaceTextbox.TabIndex = 9;
            this.chooseStorePlaceTextbox.Text = "Wybierz magazyn:";
            // 
            // WarehouseForm
            // 
            this.ClientSize = new System.Drawing.Size(938, 407);
            this.Controls.Add(this.chooseStorePlaceCombobox);
            this.Controls.Add(this.chooseStorePlaceTextbox);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.parcelsListView);
            this.Controls.Add(this.buttonSort);
            this.Name = "WarehouseForm";
            this.Load += WarehouseForm_Load;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListView parcelsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox chooseStorePlaceCombobox;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox chooseVehicleTextbox;
        private System.Windows.Forms.TextBox chooseStorePlaceTextbox;
    }
}