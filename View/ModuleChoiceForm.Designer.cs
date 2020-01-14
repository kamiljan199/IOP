namespace View
{
    partial class ModuleChoiceForm
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
            this.buttonOpenPostingWindow = new System.Windows.Forms.Button();
            this.buttonOpenLogisticsWindow = new System.Windows.Forms.Button();
            this.buttonOpenWarehouseWindow = new System.Windows.Forms.Button();
            this.buttonOpenCourierWindow = new System.Windows.Forms.Button();
            this.buttonOpenHRWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenPostingWindow
            // 
            this.buttonOpenPostingWindow.Enabled = false;
            this.buttonOpenPostingWindow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenPostingWindow.Location = new System.Drawing.Point(85, 47);
            this.buttonOpenPostingWindow.Name = "buttonOpenPostingWindow";
            this.buttonOpenPostingWindow.Size = new System.Drawing.Size(171, 43);
            this.buttonOpenPostingWindow.TabIndex = 0;
            this.buttonOpenPostingWindow.Text = "Punkt nadania";
            this.buttonOpenPostingWindow.UseVisualStyleBackColor = true;
            this.buttonOpenPostingWindow.Click += new System.EventHandler(this.ButtonOpenPostingWindow_Click);
            // 
            // buttonOpenLogisticsWindow
            // 
            this.buttonOpenLogisticsWindow.Enabled = false;
            this.buttonOpenLogisticsWindow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenLogisticsWindow.Location = new System.Drawing.Point(85, 145);
            this.buttonOpenLogisticsWindow.Name = "buttonOpenLogisticsWindow";
            this.buttonOpenLogisticsWindow.Size = new System.Drawing.Size(171, 43);
            this.buttonOpenLogisticsWindow.TabIndex = 1;
            this.buttonOpenLogisticsWindow.Text = "Logistyka";
            this.buttonOpenLogisticsWindow.UseVisualStyleBackColor = true;
            this.buttonOpenLogisticsWindow.Click += new System.EventHandler(this.ButtonOpenLogisticsWindow_Click);
            // 
            // buttonOpenWarehouseWindow
            // 
            this.buttonOpenWarehouseWindow.Enabled = false;
            this.buttonOpenWarehouseWindow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenWarehouseWindow.Location = new System.Drawing.Point(85, 96);
            this.buttonOpenWarehouseWindow.Name = "buttonOpenWarehouseWindow";
            this.buttonOpenWarehouseWindow.Size = new System.Drawing.Size(171, 43);
            this.buttonOpenWarehouseWindow.TabIndex = 2;
            this.buttonOpenWarehouseWindow.Text = "Magazyn";
            this.buttonOpenWarehouseWindow.UseVisualStyleBackColor = true;
            // 
            // buttonOpenCourierWindow
            // 
            this.buttonOpenCourierWindow.Enabled = false;
            this.buttonOpenCourierWindow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenCourierWindow.Location = new System.Drawing.Point(85, 194);
            this.buttonOpenCourierWindow.Name = "buttonOpenCourierWindow";
            this.buttonOpenCourierWindow.Size = new System.Drawing.Size(171, 43);
            this.buttonOpenCourierWindow.TabIndex = 3;
            this.buttonOpenCourierWindow.Text = "Kurier";
            this.buttonOpenCourierWindow.UseVisualStyleBackColor = true;
            this.buttonOpenCourierWindow.Click += new System.EventHandler(this.ButtonOpenCourierWindow_Click);
            // 
            // buttonOpenHRWindow
            // 
            this.buttonOpenHRWindow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenHRWindow.Location = new System.Drawing.Point(85, 243);
            this.buttonOpenHRWindow.Name = "buttonOpenHRWindow";
            this.buttonOpenHRWindow.Size = new System.Drawing.Size(171, 43);
            this.buttonOpenHRWindow.TabIndex = 4;
            this.buttonOpenHRWindow.Text = "HR";
            this.buttonOpenHRWindow.UseVisualStyleBackColor = true;
            this.buttonOpenHRWindow.Click += new System.EventHandler(this.ButtonOpenHRWindow_Click);
            // 
            // ModuleChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 344);
            this.Controls.Add(this.buttonOpenHRWindow);
            this.Controls.Add(this.buttonOpenCourierWindow);
            this.Controls.Add(this.buttonOpenLogisticsWindow);
            this.Controls.Add(this.buttonOpenWarehouseWindow);
            this.Controls.Add(this.buttonOpenPostingWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModuleChoiceForm";
            this.Text = "Moduły";
            this.Load += new System.EventHandler(this.ModuleChoiceWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenPostingWindow;
        private System.Windows.Forms.Button buttonOpenLogisticsWindow;
        private System.Windows.Forms.Button buttonOpenWarehouseWindow;
        private System.Windows.Forms.Button buttonOpenCourierWindow;
        private System.Windows.Forms.Button buttonOpenHRWindow;
    }
}