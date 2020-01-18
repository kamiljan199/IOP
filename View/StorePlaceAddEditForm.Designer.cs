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
            this.labelStorePlaceManager = new System.Windows.Forms.Label();
            this.textBoxWarehouseManagerName = new System.Windows.Forms.TextBox();
            this.labelAdressCity = new System.Windows.Forms.Label();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelHomeNumber = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxHomeNumber = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.counterStorePlaceWorkersCount = new System.Windows.Forms.NumericUpDown();
            this.labelStorePlaceWorkersCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.counterStorePlaceWorkersCount)).BeginInit();
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
            this.textBoxStorePlaceName.Location = new System.Drawing.Point(171, 43);
            this.textBoxStorePlaceName.Name = "textBoxStorePlaceName";
            this.textBoxStorePlaceName.Size = new System.Drawing.Size(263, 27);
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
            this.comboBoxStorePlaceType.Items.AddRange(new object[] {
            "Magazyn",
            "Punkt wysyłki"});
            this.comboBoxStorePlaceType.Location = new System.Drawing.Point(171, 81);
            this.comboBoxStorePlaceType.Name = "comboBoxStorePlaceType";
            this.comboBoxStorePlaceType.Size = new System.Drawing.Size(263, 28);
            this.comboBoxStorePlaceType.TabIndex = 3;
            this.comboBoxStorePlaceType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxStorePlaceType_SelectionChangeCommitted);
            // 
            // labelStorePlaceManager
            // 
            this.labelStorePlaceManager.AutoSize = true;
            this.labelStorePlaceManager.Location = new System.Drawing.Point(25, 120);
            this.labelStorePlaceManager.Name = "labelStorePlaceManager";
            this.labelStorePlaceManager.Size = new System.Drawing.Size(75, 20);
            this.labelStorePlaceManager.TabIndex = 4;
            this.labelStorePlaceManager.Text = "Menadżer";
            // 
            // textBoxWarehouseManagerName
            // 
            this.textBoxWarehouseManagerName.Location = new System.Drawing.Point(171, 119);
            this.textBoxWarehouseManagerName.Name = "textBoxWarehouseManagerName";
            this.textBoxWarehouseManagerName.Size = new System.Drawing.Size(263, 27);
            this.textBoxWarehouseManagerName.TabIndex = 5;
            // 
            // labelAdressCity
            // 
            this.labelAdressCity.AutoSize = true;
            this.labelAdressCity.Location = new System.Drawing.Point(12, 213);
            this.labelAdressCity.Name = "labelAdressCity";
            this.labelAdressCity.Size = new System.Drawing.Size(54, 20);
            this.labelAdressCity.TabIndex = 6;
            this.labelAdressCity.Text = "Miasto";
            this.labelAdressCity.Click += new System.EventHandler(this.labelAdressCity_Click);
            // 
            // labelPostCode
            // 
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Location = new System.Drawing.Point(12, 245);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(104, 20);
            this.labelPostCode.TabIndex = 7;
            this.labelPostCode.Text = "Kod pocztowy";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(12, 278);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(42, 20);
            this.labelStreet.TabIndex = 8;
            this.labelStreet.Text = "Ulica";
            this.labelStreet.Click += new System.EventHandler(this.labelStreet_Click);
            // 
            // labelHomeNumber
            // 
            this.labelHomeNumber.AutoSize = true;
            this.labelHomeNumber.Location = new System.Drawing.Point(12, 311);
            this.labelHomeNumber.Name = "labelHomeNumber";
            this.labelHomeNumber.Size = new System.Drawing.Size(104, 20);
            this.labelHomeNumber.TabIndex = 9;
            this.labelHomeNumber.Text = "Numer posesji";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(142, 212);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(292, 27);
            this.textBoxCity.TabIndex = 10;
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.Location = new System.Drawing.Point(142, 244);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(292, 27);
            this.textBoxPostCode.TabIndex = 11;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(142, 277);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(292, 27);
            this.textBoxStreet.TabIndex = 12;
            // 
            // textBoxHomeNumber
            // 
            this.textBoxHomeNumber.Location = new System.Drawing.Point(142, 310);
            this.textBoxHomeNumber.Name = "textBoxHomeNumber";
            this.textBoxHomeNumber.Size = new System.Drawing.Size(292, 27);
            this.textBoxHomeNumber.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(62, 369);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 39);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(258, 369);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 39);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Wyjdź";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // counterStorePlaceWorkersCount
            // 
            this.counterStorePlaceWorkersCount.Location = new System.Drawing.Point(317, 150);
            this.counterStorePlaceWorkersCount.Name = "counterStorePlaceWorkersCount";
            this.counterStorePlaceWorkersCount.Size = new System.Drawing.Size(117, 27);
            this.counterStorePlaceWorkersCount.TabIndex = 16;
            // 
            // labelStorePlaceWorkersCount
            // 
            this.labelStorePlaceWorkersCount.AutoSize = true;
            this.labelStorePlaceWorkersCount.Location = new System.Drawing.Point(19, 152);
            this.labelStorePlaceWorkersCount.Name = "labelStorePlaceWorkersCount";
            this.labelStorePlaceWorkersCount.Size = new System.Drawing.Size(131, 20);
            this.labelStorePlaceWorkersCount.TabIndex = 17;
            this.labelStorePlaceWorkersCount.Text = "Ilość pracowników";
            // 
            // StorePlaceAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 435);
            this.Controls.Add(this.textBoxStorePlaceName);
            this.Controls.Add(this.comboBoxStorePlaceType);
            this.Controls.Add(this.textBoxWarehouseManagerName);
            this.Controls.Add(this.textBoxHomeNumber);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxPostCode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.counterStorePlaceWorkersCount);
            this.Controls.Add(this.labelStorePlaceWorkersCount);
            this.Controls.Add(this.labelHomeNumber);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelPostCode);
            this.Controls.Add(this.labelAdressCity);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelStorePlaceManager);
            this.Controls.Add(this.labelStorePlaceType);
            this.Controls.Add(this.labelStorePlaceName);
            this.Name = "StorePlaceAddEditForm";
            this.Text = "Edycja placówki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StorePlaceAddEditForm_FormClosing);
            this.Load += new System.EventHandler(this.StorePlaceAddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.counterStorePlaceWorkersCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStorePlaceName;
        private System.Windows.Forms.TextBox textBoxStorePlaceName;
        private System.Windows.Forms.Label labelStorePlaceType;
        private System.Windows.Forms.ComboBox comboBoxStorePlaceType;
        private System.Windows.Forms.Label labelStorePlaceManager;
        private System.Windows.Forms.TextBox textBoxStorePlaceManagerName;
        private System.Windows.Forms.TextBox textBoxWarehouseManagerName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelAdressCity;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelHomeNumber;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxHomeNumber;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.NumericUpDown counterStorePlaceWorkersCount;
        private System.Windows.Forms.Label labelStorePlaceWorkersCount;
    }
}