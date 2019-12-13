namespace View
{
    partial class TestForm
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
            this.idPicker = new System.Windows.Forms.NumericUpDown();
            this.queryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.senderNameText = new System.Windows.Forms.Label();
            this.receiverNameText = new System.Windows.Forms.Label();
            this.storagePointIdText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick package id:";
            // 
            // idPicker
            // 
            this.idPicker.Location = new System.Drawing.Point(239, 24);
            this.idPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idPicker.Name = "idPicker";
            this.idPicker.Size = new System.Drawing.Size(48, 27);
            this.idPicker.TabIndex = 1;
            this.idPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(89, 68);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(183, 31);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SenderName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ReceiverName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "StoragePointId:";
            // 
            // senderNameText
            // 
            this.senderNameText.AutoSize = true;
            this.senderNameText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.senderNameText.Location = new System.Drawing.Point(148, 123);
            this.senderNameText.Name = "senderNameText";
            this.senderNameText.Size = new System.Drawing.Size(30, 20);
            this.senderNameText.TabIndex = 6;
            this.senderNameText.Text = "???";
            // 
            // receiverNameText
            // 
            this.receiverNameText.AutoSize = true;
            this.receiverNameText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receiverNameText.Location = new System.Drawing.Point(148, 143);
            this.receiverNameText.Name = "receiverNameText";
            this.receiverNameText.Size = new System.Drawing.Size(30, 20);
            this.receiverNameText.TabIndex = 6;
            this.receiverNameText.Text = "???";
            // 
            // storagePointIdText
            // 
            this.storagePointIdText.AutoSize = true;
            this.storagePointIdText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storagePointIdText.Location = new System.Drawing.Point(148, 163);
            this.storagePointIdText.Name = "storagePointIdText";
            this.storagePointIdText.Size = new System.Drawing.Size(30, 20);
            this.storagePointIdText.TabIndex = 6;
            this.storagePointIdText.Text = "???";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 211);
            this.Controls.Add(this.storagePointIdText);
            this.Controls.Add(this.receiverNameText);
            this.Controls.Add(this.senderNameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idPicker);
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.idPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown idPicker;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label senderNameText;
        private System.Windows.Forms.Label receiverNameText;
        private System.Windows.Forms.Label storagePointIdText;
    }
}