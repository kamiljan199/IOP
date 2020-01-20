namespace View
{
    partial class LogisticsRouteViewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listRoutes = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.pdfButton = new System.Windows.Forms.Button();
            this.driverLabel = new System.Windows.Forms.Label();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kierowca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pojazd:";
            // 
            // listRoutes
            // 
            this.listRoutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader10});
            this.listRoutes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listRoutes.FullRowSelect = true;
            this.listRoutes.GridLines = true;
            this.listRoutes.HideSelection = false;
            this.listRoutes.Location = new System.Drawing.Point(12, 86);
            this.listRoutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listRoutes.MultiSelect = false;
            this.listRoutes.Name = "listRoutes";
            this.listRoutes.Size = new System.Drawing.Size(444, 375);
            this.listRoutes.TabIndex = 2;
            this.listRoutes.UseCompatibleStateImageBehavior = false;
            this.listRoutes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "#";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Adres";
            this.columnHeader10.Width = 390;
            // 
            // pdfButton
            // 
            this.pdfButton.Location = new System.Drawing.Point(332, 468);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(124, 29);
            this.pdfButton.TabIndex = 3;
            this.pdfButton.Text = "Wygeneruj PDF";
            this.pdfButton.UseVisualStyleBackColor = true;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.driverLabel.Location = new System.Drawing.Point(146, 9);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(49, 18);
            this.driverLabel.TabIndex = 0;
            this.driverLabel.Text = "nazwa";
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleLabel.Location = new System.Drawing.Point(146, 32);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(49, 18);
            this.vehicleLabel.TabIndex = 0;
            this.vehicleLabel.Text = "nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data utworzenia:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(146, 55);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(49, 18);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "nazwa";
            // 
            // LogisticsRouteViewForm
            // 
            this.ClientSize = new System.Drawing.Size(462, 509);
            this.Controls.Add(this.listRoutes);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogisticsRouteViewForm";
            this.Text = "Podgląd trasy";
            this.Shown += new System.EventHandler(this.LogisticsRouteViewForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listRoutes;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
    }
}