namespace View
{
    partial class CourierForm
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.changeStatus = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.listBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(443, 12);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(144, 32);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Wyloguj się";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // listBox1
            // 
            this.listBox1.Controls.Add(this.StatusLabel);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(2, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 229);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // changeStatus
            // 
            this.changeStatus.FormattingEnabled = true;
            this.changeStatus.Items.AddRange(new object[] {
            "Przesyłka w punkcie nadania",
            "Przeyłka w drodze do magazynu",
            "Przesyłka w magazynie",
            "Przesyłka w drodze do odbiorcy",
            "Przesyłka zwrócona",
            "Przesyłka dostarczona",
            "Brak przesyłki o podanym numerze"});
            this.changeStatus.Location = new System.Drawing.Point(328, 128);
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(168, 23);
            this.changeStatus.TabIndex = 2;
            this.changeStatus.SelectedIndexChanged += new System.EventHandler(this.changeStatus_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(54, 113);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(7, 15);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "\r\n";
            // 
            // CourierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 322);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.changeStatus);
            this.Controls.Add(this.buttonLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourierForm";
            this.Text = "Kurier";
            this.Load += new System.EventHandler(this.CourierWindow_Load);
            this.listBox1.ResumeLayout(false);
            this.listBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox changeStatus;
        private System.Windows.Forms.Label StatusLabel;
    }
}