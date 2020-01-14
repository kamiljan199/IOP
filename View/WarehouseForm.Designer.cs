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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.parcelsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(556, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Dane magazynu: ";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(709, 17);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(206, 73);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Wyloguj się";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(724, 241);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(190, 131);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Sortuj";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // parcelsListView
            // 
            this.parcelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.parcelsListView.HideSelection = false;
            this.parcelsListView.Location = new System.Drawing.Point(12, 61);
            this.parcelsListView.Name = "parcelsListView";
            this.parcelsListView.Size = new System.Drawing.Size(629, 311);
            this.parcelsListView.TabIndex = 3;
            this.parcelsListView.UseCompatibleStateImageBehavior = false;
            this.parcelsListView.View = System.Windows.Forms.View.Details;
            this.parcelsListView.SelectedIndexChanged += new System.EventHandler(this.parcelsListView_SelectedIndexChanged);
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
            // WarehouseForm
            // 
            this.ClientSize = new System.Drawing.Size(938, 407);
            this.Controls.Add(this.parcelsListView);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.textBox1);
            this.Name = "WarehouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ListView parcelsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}