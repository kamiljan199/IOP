namespace View
{
    partial class LogisticsNewRouteForm
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
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
            this.listViewWarehouseParcels = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listViewVehicleParcels = new System.Windows.Forms.ListView();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.buttonMoveToVehicle = new System.Windows.Forms.Button();
            this.buttonMoveToWarehouse = new System.Windows.Forms.Button();
            this.buttonMoveParcelUp = new System.Windows.Forms.Button();
            this.buttonMoveParcelDown = new System.Windows.Forms.Button();
            this.buttonCreateRoute = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kierowca:";
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriver.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.Items.AddRange(new object[] {
            "kierowca1",
            "kierowca2",
            "kierowca3"});
            this.comboBoxDriver.Location = new System.Drawing.Point(88, 12);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(250, 26);
            this.comboBoxDriver.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(380, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pojazd:";
            // 
            // comboBoxVehicle
            // 
            this.comboBoxVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxVehicle.FormattingEnabled = true;
            this.comboBoxVehicle.Items.AddRange(new object[] {
            "pojazd1",
            "pojazd2",
            "pojazd3"});
            this.comboBoxVehicle.Location = new System.Drawing.Point(442, 12);
            this.comboBoxVehicle.Name = "comboBoxVehicle";
            this.comboBoxVehicle.Size = new System.Drawing.Size(250, 26);
            this.comboBoxVehicle.TabIndex = 1;
            this.comboBoxVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicle_SelectedIndexChanged);
            // 
            // listViewWarehouseParcels
            // 
            this.listViewWarehouseParcels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewWarehouseParcels.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewWarehouseParcels.FullRowSelect = true;
            this.listViewWarehouseParcels.GridLines = true;
            this.listViewWarehouseParcels.HideSelection = false;
            this.listViewWarehouseParcels.Location = new System.Drawing.Point(12, 95);
            this.listViewWarehouseParcels.MultiSelect = false;
            this.listViewWarehouseParcels.Name = "listViewWarehouseParcels";
            this.listViewWarehouseParcels.Size = new System.Drawing.Size(544, 311);
            this.listViewWarehouseParcels.TabIndex = 2;
            this.listViewWarehouseParcels.UseCompatibleStateImageBehavior = false;
            this.listViewWarehouseParcels.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "#";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adres";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Waga";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Objętość";
            this.columnHeader3.Width = 80;
            // 
            // listViewVehicleParcels
            // 
            this.listViewVehicleParcels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewVehicleParcels.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewVehicleParcels.FullRowSelect = true;
            this.listViewVehicleParcels.GridLines = true;
            this.listViewVehicleParcels.HideSelection = false;
            this.listViewVehicleParcels.Location = new System.Drawing.Point(621, 95);
            this.listViewVehicleParcels.MultiSelect = false;
            this.listViewVehicleParcels.Name = "listViewVehicleParcels";
            this.listViewVehicleParcels.Size = new System.Drawing.Size(544, 311);
            this.listViewVehicleParcels.TabIndex = 2;
            this.listViewVehicleParcels.UseCompatibleStateImageBehavior = false;
            this.listViewVehicleParcels.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "#";
            this.columnHeader12.Width = 40;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Adres";
            this.columnHeader9.Width = 300;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Waga";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Objętość";
            this.columnHeader11.Width = 80;
            // 
            // buttonMoveToVehicle
            // 
            this.buttonMoveToVehicle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoveToVehicle.Location = new System.Drawing.Point(562, 213);
            this.buttonMoveToVehicle.Name = "buttonMoveToVehicle";
            this.buttonMoveToVehicle.Size = new System.Drawing.Size(53, 31);
            this.buttonMoveToVehicle.TabIndex = 3;
            this.buttonMoveToVehicle.Text = ">>";
            this.buttonMoveToVehicle.UseVisualStyleBackColor = true;
            this.buttonMoveToVehicle.Click += new System.EventHandler(this.buttonMoveToVehicle_Click);
            // 
            // buttonMoveToWarehouse
            // 
            this.buttonMoveToWarehouse.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoveToWarehouse.Location = new System.Drawing.Point(562, 250);
            this.buttonMoveToWarehouse.Name = "buttonMoveToWarehouse";
            this.buttonMoveToWarehouse.Size = new System.Drawing.Size(53, 31);
            this.buttonMoveToWarehouse.TabIndex = 3;
            this.buttonMoveToWarehouse.Text = "<<";
            this.buttonMoveToWarehouse.UseVisualStyleBackColor = true;
            this.buttonMoveToWarehouse.Click += new System.EventHandler(this.buttonMoveToWarehouse_Click);
            // 
            // buttonMoveParcelUp
            // 
            this.buttonMoveParcelUp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoveParcelUp.Location = new System.Drawing.Point(1171, 203);
            this.buttonMoveParcelUp.Name = "buttonMoveParcelUp";
            this.buttonMoveParcelUp.Size = new System.Drawing.Size(38, 41);
            this.buttonMoveParcelUp.TabIndex = 3;
            this.buttonMoveParcelUp.Text = "/\\";
            this.buttonMoveParcelUp.UseVisualStyleBackColor = true;
            this.buttonMoveParcelUp.Click += new System.EventHandler(this.buttonMoveParcelUp_Click);
            // 
            // buttonMoveParcelDown
            // 
            this.buttonMoveParcelDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoveParcelDown.Location = new System.Drawing.Point(1171, 250);
            this.buttonMoveParcelDown.Name = "buttonMoveParcelDown";
            this.buttonMoveParcelDown.Size = new System.Drawing.Size(38, 41);
            this.buttonMoveParcelDown.TabIndex = 3;
            this.buttonMoveParcelDown.Text = "\\/";
            this.buttonMoveParcelDown.UseVisualStyleBackColor = true;
            this.buttonMoveParcelDown.Click += new System.EventHandler(this.buttonMoveParcelDown_Click);
            // 
            // buttonCreateRoute
            // 
            this.buttonCreateRoute.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateRoute.Location = new System.Drawing.Point(1059, 432);
            this.buttonCreateRoute.Name = "buttonCreateRoute";
            this.buttonCreateRoute.Size = new System.Drawing.Size(150, 42);
            this.buttonCreateRoute.TabIndex = 4;
            this.buttonCreateRoute.Text = "Dodaj trasę";
            this.buttonCreateRoute.UseVisualStyleBackColor = true;
            this.buttonCreateRoute.Click += new System.EventHandler(this.buttonCreateRoute_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(903, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(185, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Paczki w magazynie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(811, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wybrane paczki:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(621, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Waga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(621, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Objętość";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVolume.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelVolume.Location = new System.Drawing.Point(721, 455);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(48, 19);
            this.labelVolume.TabIndex = 0;
            this.labelVolume.Text = "0 / 0";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWeight.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelWeight.Location = new System.Drawing.Point(721, 432);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(48, 19);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "0 / 0";
            // 
            // LogisticsNewRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVehicle);
            this.Controls.Add(this.buttonMoveToWarehouse);
            this.Controls.Add(this.buttonMoveToVehicle);
            this.Controls.Add(this.buttonMoveParcelUp);
            this.Controls.Add(this.buttonMoveParcelDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.buttonCreateRoute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewVehicleParcels);
            this.Controls.Add(this.listViewWarehouseParcels);
            this.Controls.Add(this.comboBoxDriver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogisticsNewRouteForm";
            this.Text = "Nowa trasa";
            this.Shown += new System.EventHandler(this.LogisticsNewRouteForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVehicle;
        private System.Windows.Forms.ListView listViewWarehouseParcels;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewVehicleParcels;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonMoveToVehicle;
        private System.Windows.Forms.Button buttonMoveToWarehouse;
        private System.Windows.Forms.Button buttonMoveParcelUp;
        private System.Windows.Forms.Button buttonMoveParcelDown;
        private System.Windows.Forms.Button buttonCreateRoute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelWeight;
    }
}