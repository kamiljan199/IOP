namespace View
{
    partial class VehicleAddEditForm
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
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.warehouseComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.maxLoadTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maxCapacityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rejestracja:";
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Location = new System.Drawing.Point(131, 10);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(190, 23);
            this.registrationTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(131, 39);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(190, 23);
            this.brandTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(131, 68);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(190, 23);
            this.modelTextBox.TabIndex = 1;
            // 
            // warehouseComboBox
            // 
            this.warehouseComboBox.FormattingEnabled = true;
            this.warehouseComboBox.Location = new System.Drawing.Point(131, 156);
            this.warehouseComboBox.Name = "warehouseComboBox";
            this.warehouseComboBox.Size = new System.Drawing.Size(190, 23);
            this.warehouseComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Magazyn:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maxLoadTextBox
            // 
            this.maxLoadTextBox.Location = new System.Drawing.Point(131, 127);
            this.maxLoadTextBox.Name = "maxLoadTextBox";
            this.maxLoadTextBox.Size = new System.Drawing.Size(190, 23);
            this.maxLoadTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maks. pojemność:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // maxCapacityTextBox
            // 
            this.maxCapacityTextBox.Location = new System.Drawing.Point(131, 99);
            this.maxCapacityTextBox.Name = "maxCapacityTextBox";
            this.maxCapacityTextBox.Size = new System.Drawing.Size(190, 23);
            this.maxCapacityTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Maks. obciążenie:";
            // 
            // VehicleAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 226);
            this.Controls.Add(this.maxCapacityTextBox);
            this.Controls.Add(this.maxLoadTextBox);
            this.Controls.Add(this.registrationTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.warehouseComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VehicleAddEditForm";
            this.Text = "Dodaj/Edytuj pojazd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehicleAddEditForm_FormClosing);
            this.Load += new System.EventHandler(this.VehicleAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.ComboBox warehouseComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox maxLoadTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxCapacityTextBox;
        private System.Windows.Forms.Label label7;
    }
}