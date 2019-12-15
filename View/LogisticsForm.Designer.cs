namespace View
{
    partial class LogisticsForm
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
            this.listRoute = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.buttonShowRoute = new System.Windows.Forms.Button();
            this.textRouteCounter = new System.Windows.Forms.RichTextBox();
            this.labelRouteCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listRoute
            // 
            this.listRoute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listRoute.FullRowSelect = true;
            this.listRoute.GridLines = true;
            this.listRoute.HideSelection = false;
            this.listRoute.HoverSelection = true;
            this.listRoute.Location = new System.Drawing.Point(12, 12);
            this.listRoute.MultiSelect = false;
            this.listRoute.Name = "listRoute";
            this.listRoute.Scrollable = false;
            this.listRoute.Size = new System.Drawing.Size(255, 464);
            this.listRoute.TabIndex = 0;
            this.listRoute.UseCompatibleStateImageBehavior = false;
            this.listRoute.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwa";
            this.columnHeader2.Width = 195;
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.Location = new System.Drawing.Point(288, 12);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(166, 83);
            this.buttonAddRoute.TabIndex = 1;
            this.buttonAddRoute.Text = "Dodaj trasę";
            this.buttonAddRoute.UseVisualStyleBackColor = true;
            this.buttonAddRoute.Click += new System.EventHandler(this.buttonAddRoute_Click);
            // 
            // buttonShowRoute
            // 
            this.buttonShowRoute.Location = new System.Drawing.Point(288, 130);
            this.buttonShowRoute.Name = "buttonShowRoute";
            this.buttonShowRoute.Size = new System.Drawing.Size(166, 81);
            this.buttonShowRoute.TabIndex = 2;
            this.buttonShowRoute.Text = "Wyświetl trasę";
            this.buttonShowRoute.UseVisualStyleBackColor = true;
            // 
            // textRouteCounter
            // 
            this.textRouteCounter.Location = new System.Drawing.Point(288, 245);
            this.textRouteCounter.Name = "textRouteCounter";
            this.textRouteCounter.Size = new System.Drawing.Size(96, 75);
            this.textRouteCounter.TabIndex = 3;
            this.textRouteCounter.Text = "Liczba stworzonych tras:";
            // 
            // labelRouteCounter
            // 
            this.labelRouteCounter.AutoSize = true;
            this.labelRouteCounter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRouteCounter.Location = new System.Drawing.Point(390, 264);
            this.labelRouteCounter.Name = "labelRouteCounter";
            this.labelRouteCounter.Size = new System.Drawing.Size(26, 31);
            this.labelRouteCounter.TabIndex = 4;
            this.labelRouteCounter.Text = "0";
            // 
            // LogisticsForm
            // 
            this.ClientSize = new System.Drawing.Size(466, 488);
            this.Controls.Add(this.labelRouteCounter);
            this.Controls.Add(this.textRouteCounter);
            this.Controls.Add(this.buttonShowRoute);
            this.Controls.Add(this.buttonAddRoute);
            this.Controls.Add(this.listRoute);
            this.Name = "LogisticsForm";
            this.Text = "Okno Logistyka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listRoute;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonAddRoute;
        private System.Windows.Forms.Button buttonShowRoute;
        private System.Windows.Forms.RichTextBox textRouteCounter;
        private System.Windows.Forms.Label labelRouteCounter;
    }
}