namespace View
{
    partial class StorePlaceListForm
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
            this.listStorePlace = new System.Windows.Forms.ListView();
            this.indexColumn = new System.Windows.Forms.ColumnHeader();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.typeColumn = new System.Windows.Forms.ColumnHeader();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listStorePlace
            // 
            this.listStorePlace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexColumn,
            this.nameColumn,
            this.typeColumn});
            this.listStorePlace.FullRowSelect = true;
            this.listStorePlace.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listStorePlace.HideSelection = false;
            this.listStorePlace.Location = new System.Drawing.Point(12, 12);
            this.listStorePlace.MultiSelect = false;
            this.listStorePlace.Name = "listStorePlace";
            this.listStorePlace.Size = new System.Drawing.Size(776, 364);
            this.listStorePlace.TabIndex = 0;
            this.listStorePlace.UseCompatibleStateImageBehavior = false;
            this.listStorePlace.View = System.Windows.Forms.View.Details;
            this.listStorePlace.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listStorePlace_ItemSelectionChanged);
            // 
            // indexColumn
            // 
            this.indexColumn.Name = "indexColumn";
            this.indexColumn.Text = "#";
            this.indexColumn.Width = 40;
            // 
            // nameColumn
            // 
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Text = "Nazwa Placówki";
            this.nameColumn.Width = 500;
            // 
            // typeColumn
            // 
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Text = "Typ placówki";
            this.typeColumn.Width = 200;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(24, 408);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(130, 30);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(160, 408);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(288, 408);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(122, 30);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Usuń";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(646, 408);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 30);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Wstecz";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // StorePlaceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listStorePlace);
            this.Name = "StorePlaceListForm";
            this.Text = "StorePlaceListForm";
            this.Load += new System.EventHandler(this.StorePlaceListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listStorePlace;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ColumnHeader indexColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
    }
}