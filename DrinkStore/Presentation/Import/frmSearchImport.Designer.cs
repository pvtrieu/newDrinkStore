namespace DrinkStore.Presentation
{
    partial class frmSearchImport
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
            this.components = new System.ComponentModel.Container();
            this.importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.importTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.closeButton1 = new DrinkStore.Presentation.CloseButton();
            this.pnlTop = new DrinkStore.GUI_component.MovePanel();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.dateBefore = new System.Windows.Forms.DateTimePicker();
            this.dateAfter = new System.Windows.Forms.DateTimePicker();
            this.importIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.importDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // importBindingSource
            // 
            this.importBindingSource.DataSource = typeof(DrinkStore.Entities.Import);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.importDateDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dgvCategory.DataSource = this.importTBBindingSource;
            this.dgvCategory.Location = new System.Drawing.Point(17, 245);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(319, 249);
            this.dgvCategory.TabIndex = 61;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            this.dgvCategory.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCategory_DataError);
            // 
            // importTBBindingSource
            // 
            this.importTBBindingSource.DataSource = typeof(DrinkStore.Entities.Import);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DrinkStore.Entities.Supplier);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnSelect.Location = new System.Drawing.Point(256, 189);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 26);
            this.btnSelect.TabIndex = 62;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(136, 189);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.lblLogo.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblLogo.Location = new System.Drawing.Point(12, 6);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(175, 25);
            this.lblLogo.TabIndex = 66;
            this.lblLogo.Text = "Search import";
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.closeButton1.Location = new System.Drawing.Point(314, 7);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(24, 24);
            this.closeButton1.TabIndex = 65;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(352, 39);
            this.pnlTop.TabIndex = 64;
            // 
            // cboSupplier
            // 
            this.cboSupplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.importBindingSource, "SupplierID", true));
            this.cboSupplier.DataSource = this.supplierBindingSource;
            this.cboSupplier.DisplayMember = "SupplierName";
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(136, 51);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(200, 21);
            this.cboSupplier.TabIndex = 72;
            this.cboSupplier.ValueMember = "SupplierID";
        
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblSupplier.Location = new System.Drawing.Point(14, 55);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(73, 17);
            this.lblSupplier.TabIndex = 69;
            this.lblSupplier.Text = "Supplier:";
            
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBefore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBefore.Location = new System.Drawing.Point(14, 146);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(98, 17);
            this.lblBefore.TabIndex = 73;
            this.lblBefore.Text = "Before date:";
            
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblAfter.Location = new System.Drawing.Point(14, 100);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(85, 17);
            this.lblAfter.TabIndex = 75;
            this.lblAfter.Text = "After date:";
            
            // 
            // dateBefore
            // 
            this.dateBefore.Location = new System.Drawing.Point(136, 142);
            this.dateBefore.Name = "dateBefore";
            this.dateBefore.Size = new System.Drawing.Size(200, 20);
            this.dateBefore.TabIndex = 76;
            // 
            // dateAfter
            // 
            this.dateAfter.Location = new System.Drawing.Point(136, 97);
            this.dateAfter.Name = "dateAfter";
            this.dateAfter.Size = new System.Drawing.Size(200, 20);
            this.dateAfter.TabIndex = 77;
            // 
            // importIDDataGridViewTextBoxColumn
            // 
            this.importIDDataGridViewTextBoxColumn.DataPropertyName = "ImportID";
            this.importIDDataGridViewTextBoxColumn.HeaderText = "ImportID";
            this.importIDDataGridViewTextBoxColumn.Name = "importIDDataGridViewTextBoxColumn";
            this.importIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.DataSource = this.supplierBindingSource;
            this.supplierIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.supplierIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplierIDDataGridViewTextBoxColumn.ValueMember = "SupplierID";
            // 
            // importDateDataGridViewTextBoxColumn
            // 
            this.importDateDataGridViewTextBoxColumn.DataPropertyName = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.HeaderText = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.Name = "importDateDataGridViewTextBoxColumn";
            this.importDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmSearchImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(352, 500);
            this.Controls.Add(this.dateAfter);
            this.Controls.Add(this.dateBefore);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchImport";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.frmSerchImport_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmSearchImport_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.BindingSource importTBBindingSource;
        private System.Windows.Forms.BindingSource importBindingSource;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private GUI_component.MovePanel pnlTop;
        private CloseButton closeButton1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.DateTimePicker dateBefore;
        private System.Windows.Forms.DateTimePicker dateAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn importIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
    }
}