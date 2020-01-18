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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kierowca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
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
            this.listRoutes.Location = new System.Drawing.Point(12, 66);
            this.listRoutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listRoutes.MultiSelect = false;
            this.listRoutes.Name = "listRoutes";
            this.listRoutes.Size = new System.Drawing.Size(444, 386);
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
            this.columnHeader10.Width = 300;
            // 
            // pdfButton
            // 
            this.pdfButton.Location = new System.Drawing.Point(332, 468);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(124, 29);
            this.pdfButton.TabIndex = 3;
            this.pdfButton.Text = "Wygeneruj PDF";
            this.pdfButton.UseVisualStyleBackColor = true;
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.driverLabel.Location = new System.Drawing.Point(98, 9);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(0, 23);
            this.driverLabel.TabIndex = 0;
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleLabel.Location = new System.Drawing.Point(77, 32);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(0, 23);
            this.vehicleLabel.TabIndex = 0;
            // 
            // LogisticsRouteViewForm
            // 
            this.ClientSize = new System.Drawing.Size(462, 509);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.listRoutes);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogisticsRouteViewForm";
            this.Text = "Podgląd trasy";
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
    }
}