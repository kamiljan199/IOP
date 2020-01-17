namespace View
{
    partial class StorePlaceAddEditForm
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
            this.labelStorePlaceName = new System.Windows.Forms.Label();
            this.textBoxStorePlaceName = new System.Windows.Forms.TextBox();
            this.labelStorePlaceType = new System.Windows.Forms.Label();
            this.comboBoxStorePlaceType = new System.Windows.Forms.ComboBox();
            this.labelStorePlaceDetail = new System.Windows.Forms.Label();
            this.textBoxWarehouseManagerName = new System.Windows.Forms.TextBox();
            this.counterSendingPointWorkersCount = new System.Windows.Forms.NumericUpDown();
            this.labelAdressCity = new System.Windows.Forms.Label();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelHomeNumber = new System.Windows.Forms.Label();
            this.textBoxWarehouseManagerName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counterSendingPointWorkersCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStorePlaceName
            // 
            this.labelStorePlaceName.AutoSize = true;
            this.labelStorePlaceName.Location = new System.Drawing.Point(25, 44);
            this.labelStorePlaceName.Name = "labelStorePlaceName";
            this.labelStorePlaceName.Size = new System.Drawing.Size(117, 20);
            this.labelStorePlaceName.TabIndex = 0;
            this.labelStorePlaceName.Text = "Nazwa placówki";
            // 
            // textBoxStorePlaceName
            // 
            this.textBoxStorePlaceName.Location = new System.Drawing.Point(148, 41);
            this.textBoxStorePlaceName.Name = "textBoxStorePlaceName";
            this.textBoxStorePlaceName.Size = new System.Drawing.Size(292, 27);
            this.textBoxStorePlaceName.TabIndex = 1;
            // 
            // labelStorePlaceType
            // 
            this.labelStorePlaceType.AutoSize = true;
            this.labelStorePlaceType.Location = new System.Drawing.Point(25, 82);
            this.labelStorePlaceType.Name = "labelStorePlaceType";
            this.labelStorePlaceType.Size = new System.Drawing.Size(95, 20);
            this.labelStorePlaceType.TabIndex = 2;
            this.labelStorePlaceType.Text = "Typ placówki";
            // 
            // comboBoxStorePlaceType
            // 
            this.comboBoxStorePlaceType.FormattingEnabled = true;
            this.comboBoxStorePlaceType.Location = new System.Drawing.Point(148, 79);
            this.comboBoxStorePlaceType.Name = "comboBoxStorePlaceType";
            this.comboBoxStorePlaceType.Size = new System.Drawing.Size(292, 28);
            this.comboBoxStorePlaceType.TabIndex = 3;
            // 
            // labelStorePlaceDetail
            // 
            this.labelStorePlaceDetail.AutoSize = true;
            this.labelStorePlaceDetail.Location = new System.Drawing.Point(25, 120);
            this.labelStorePlaceDetail.Name = "labelStorePlaceDetail";
            this.labelStorePlaceDetail.Size = new System.Drawing.Size(69, 20);
            this.labelStorePlaceDetail.TabIndex = 4;
            this.labelStorePlaceDetail.Text = "----------";
            // 
            // textBoxWarehouseManagerName
            // 
            this.textBoxWarehouseManagerName.Controls.Add(this.counterSendingPointWorkersCount);
            this.textBoxWarehouseManagerName.Location = new System.Drawing.Point(148, 117);
            this.textBoxWarehouseManagerName.Name = "textBoxWarehouseManagerName";
            this.textBoxWarehouseManagerName.Size = new System.Drawing.Size(292, 27);
            this.textBoxWarehouseManagerName.TabIndex = 5;
            // 
            // counterSendingPointWorkersCount
            // 
            this.counterSendingPointWorkersCount.Enabled = false;
            this.counterSendingPointWorkersCount.Location = new System.Drawing.Point(-2, -1);
            this.counterSendingPointWorkersCount.Name = "counterSendingPointWorkersCount";
            this.counterSendingPointWorkersCount.Size = new System.Drawing.Size(76, 27);
            this.counterSendingPointWorkersCount.TabIndex = 6;
            this.counterSendingPointWorkersCount.Visible = false;
            // 
            // labelAdressCity
            // 
            this.labelAdressCity.AutoSize = true;
            this.labelAdressCity.Location = new System.Drawing.Point(25, 202);
            this.labelAdressCity.Name = "labelAdressCity";
            this.labelAdressCity.Size = new System.Drawing.Size(54, 20);
            this.labelAdressCity.TabIndex = 6;
            this.labelAdressCity.Text = "Miasto";
            // 
            // labelPostCode
            // 
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Location = new System.Drawing.Point(25, 231);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(104, 20);
            this.labelPostCode.TabIndex = 7;
            this.labelPostCode.Text = "Kod pocztowy";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(25, 263);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(42, 20);
            this.labelStreet.TabIndex = 8;
            this.labelStreet.Text = "Ulica";
            this.labelStreet.Click += new System.EventHandler(this.labelStreet_Click);
            // 
            // labelHomeNumber
            // 
            this.labelHomeNumber.AutoSize = true;
            this.labelHomeNumber.Location = new System.Drawing.Point(25, 297);
            this.labelHomeNumber.Name = "labelHomeNumber";
            this.labelHomeNumber.Size = new System.Drawing.Size(104, 20);
            this.labelHomeNumber.TabIndex = 9;
            this.labelHomeNumber.Text = "Numer posesji";
            // 
            // StorePlaceAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 391);
            this.Controls.Add(this.labelHomeNumber);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelPostCode);
            this.Controls.Add(this.labelAdressCity);
            this.Controls.Add(this.textBoxWarehouseManagerName);
            this.Controls.Add(this.labelStorePlaceDetail);
            this.Controls.Add(this.comboBoxStorePlaceType);
            this.Controls.Add(this.labelStorePlaceType);
            this.Controls.Add(this.labelStorePlaceName);
            this.Controls.Add(this.textBoxStorePlaceName);
            this.Name = "StorePlaceAddEditForm";
            this.Text = "Edycja/dodawanie placówki";
            this.textBoxWarehouseManagerName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.counterSendingPointWorkersCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStorePlaceName;
        private System.Windows.Forms.TextBox textBoxStorePlaceName;
        private System.Windows.Forms.Label labelStorePlaceType;
        private System.Windows.Forms.ComboBox comboBoxStorePlaceType;
        private System.Windows.Forms.Label labelStorePlaceDetail;
        private System.Windows.Forms.TextBox textBoxStorePlaceManagerName;
        private System.Windows.Forms.TextBox textBoxWarehouseManagerName;
        private System.Windows.Forms.NumericUpDown counterSendingPointWorkersCount;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelAdressCity;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelHomeNumber;
    }
}