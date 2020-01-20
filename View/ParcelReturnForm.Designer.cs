namespace View
{
    partial class ParcelReturnForm
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
            this.parcelIdTextBox = new System.Windows.Forms.TextBox();
            this.parcelStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zwróć paczkę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id paczki";
            // 
            // parcelIdTextBox
            // 
            this.parcelIdTextBox.Location = new System.Drawing.Point(71, 43);
            this.parcelIdTextBox.Name = "parcelIdTextBox";
            this.parcelIdTextBox.Size = new System.Drawing.Size(141, 23);
            this.parcelIdTextBox.TabIndex = 2;
            // 
            // parcelStatus
            // 
            this.parcelStatus.Location = new System.Drawing.Point(12, 72);
            this.parcelStatus.Name = "parcelStatus";
            this.parcelStatus.Size = new System.Drawing.Size(200, 23);
            this.parcelStatus.TabIndex = 3;
            this.parcelStatus.Text = "Status";
            this.parcelStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zwrot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnReturn);
            // 
            // ParcelReturnForm
            // 
            this.ClientSize = new System.Drawing.Size(226, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parcelStatus);
            this.Controls.Add(this.parcelIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ParcelReturnForm";
            this.Load += new System.EventHandler(this.ParcelReturnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parcelIdTextBox;
        private System.Windows.Forms.TextBox parcelStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}