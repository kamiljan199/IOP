namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenLoginWindow = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCheckStatus = new System.Windows.Forms.Button();
            this.textBoxInsertNumber = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenLoginWindow
            // 
            this.buttonOpenLoginWindow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenLoginWindow.Location = new System.Drawing.Point(440, 10);
            this.buttonOpenLoginWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenLoginWindow.Name = "buttonOpenLoginWindow";
            this.buttonOpenLoginWindow.Size = new System.Drawing.Size(147, 32);
            this.buttonOpenLoginWindow.TabIndex = 0;
            this.buttonOpenLoginWindow.Text = "Zaloguj się";
            this.buttonOpenLoginWindow.UseVisualStyleBackColor = true;
            this.buttonOpenLoginWindow.Click += new System.EventHandler(this.ButtonOpenLoginWindow_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(176, 118);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(225, 27);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Śledzenie przesyłki";
            // 
            // buttonCheckStatus
            // 
            this.buttonCheckStatus.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckStatus.Location = new System.Drawing.Point(423, 180);
            this.buttonCheckStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCheckStatus.Name = "buttonCheckStatus";
            this.buttonCheckStatus.Size = new System.Drawing.Size(70, 32);
            this.buttonCheckStatus.TabIndex = 2;
            this.buttonCheckStatus.Text = "Szukaj";
            this.buttonCheckStatus.UseVisualStyleBackColor = true;
            this.buttonCheckStatus.Click += new System.EventHandler(this.ButtonCheckStatus_Click);
            // 
            // textBoxInsertNumber
            // 
            this.textBoxInsertNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInsertNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxInsertNumber.Location = new System.Drawing.Point(143, 184);
            this.textBoxInsertNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInsertNumber.Name = "textBoxInsertNumber";
            this.textBoxInsertNumber.Size = new System.Drawing.Size(263, 24);
            this.textBoxInsertNumber.TabIndex = 4;
            this.textBoxInsertNumber.TextChanged += new System.EventHandler(this.textBoxInsertNumber_TextChanged);
            this.textBoxInsertNumber.Enter += new System.EventHandler(this.TextBoxInsertNumber_Enter);
            this.textBoxInsertNumber.Leave += new System.EventHandler(this.TextBoxInsertNumber_Leave);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(176, 223);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 16);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "label2";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 322);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxInsertNumber);
            this.Controls.Add(this.buttonCheckStatus);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonOpenLoginWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Śledzenie przesyłki";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenLoginWindow;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCheckStatus;
        private System.Windows.Forms.TextBox textBoxInsertNumber;
        private System.Windows.Forms.Label labelStatus;
    }
}

