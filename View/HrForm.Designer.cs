namespace View
{
    partial class HrForm
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
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.PositionsButton = new System.Windows.Forms.Button();
            this.VehiclesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(24, 30);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(107, 23);
            this.EmployeesButton.TabIndex = 0;
            this.EmployeesButton.Text = "Pracownicy";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // PositionsButton
            // 
            this.PositionsButton.Location = new System.Drawing.Point(24, 59);
            this.PositionsButton.Name = "PositionsButton";
            this.PositionsButton.Size = new System.Drawing.Size(107, 23);
            this.PositionsButton.TabIndex = 0;
            this.PositionsButton.Text = "Stanowiska";
            this.PositionsButton.UseVisualStyleBackColor = true;
            this.PositionsButton.Click += new System.EventHandler(this.PositionsButton_Click);
            // 
            // VehiclesButton
            // 
            this.VehiclesButton.Location = new System.Drawing.Point(24, 88);
            this.VehiclesButton.Name = "VehiclesButton";
            this.VehiclesButton.Size = new System.Drawing.Size(107, 23);
            this.VehiclesButton.TabIndex = 0;
            this.VehiclesButton.Text = "Pojazdy";
            this.VehiclesButton.UseVisualStyleBackColor = true;
            // 
            // HrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 155);
            this.Controls.Add(this.VehiclesButton);
            this.Controls.Add(this.PositionsButton);
            this.Controls.Add(this.EmployeesButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HrForm";
            this.Text = "HR";
            this.Load += new System.EventHandler(this.HrForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button PositionsButton;
        private System.Windows.Forms.Button VehiclesButton;
    }
}