namespace DrinkStore.Presentation
{
    partial class frmImport
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlDataImport = new System.Windows.Forms.Panel();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.importIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblImportDate = new System.Windows.Forms.Label();
            this.dateImport = new System.Windows.Forms.DateTimePicker();
            this.dateExpired = new System.Windows.Forms.DateTimePicker();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.pnlDataDetail = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnSearchProduct = new DrinkStore.GUI_component.SearchButton();
            this.btnAddSupplier = new DrinkStore.GUI_component.PlusButton();
            this.lineSeparator2 = new DrinkStore.Presentation.LineSeparator();
            this.lineSeparator1 = new DrinkStore.Presentation.LineSeparator();
            this.txtImportID = new System.Windows.Forms.TextBox();
            this.lblImportID = new System.Windows.Forms.Label();
            this.pnlDataImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.pnlDataDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(499, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 26);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlDataImport
            // 
            this.pnlDataImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDataImport.Controls.Add(this.dgvImport);
            this.pnlDataImport.Location = new System.Drawing.Point(21, 53);
            this.pnlDataImport.Name = "pnlDataImport";
            this.pnlDataImport.Size = new System.Drawing.Size(289, 206);
            this.pnlDataImport.TabIndex = 46;
            // 
            // dgvImport
            // 
            this.dgvImport.AutoGenerateColumns = false;
            this.dgvImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.importDateDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dgvImport.DataSource = this.importTBBindingSource;
            this.dgvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImport.Location = new System.Drawing.Point(0, 0);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.ReadOnly = true;
            this.dgvImport.RowHeadersVisible = false;
            this.dgvImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImport.Size = new System.Drawing.Size(289, 206);
            this.dgvImport.TabIndex = 0;
            this.dgvImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImport_CellClick);
            this.dgvImport.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvImport_DataError);
            // 
            // importIDDataGridViewTextBoxColumn
            // 
            this.importIDDataGridViewTextBoxColumn.DataPropertyName = "ImportID";
            this.importIDDataGridViewTextBoxColumn.HeaderText = "ID";
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
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DrinkStore.Entities.Supplier);
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
            // importTBBindingSource
            // 
            this.importTBBindingSource.DataSource = typeof(DrinkStore.Entities.Import);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(412, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(323, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importBindingSource, "TotalCost", true));
            this.txtTotalCost.Location = new System.Drawing.Point(418, 121);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(163, 20);
            this.txtTotalCost.TabIndex = 40;
            // 
            // importBindingSource
            // 
            this.importBindingSource.DataSource = typeof(DrinkStore.Entities.Import);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblCost.Location = new System.Drawing.Point(317, 122);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(85, 17);
            this.lblCost.TabIndex = 34;
            this.lblCost.Text = "Total cost:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 26);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Import";
            // 
            // cboSupplier
            // 
            this.cboSupplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.importBindingSource, "SupplierID", true));
            this.cboSupplier.DataSource = this.supplierBindingSource;
            this.cboSupplier.DisplayMember = "Name";
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(418, 75);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(136, 21);
            this.cboSupplier.TabIndex = 59;
            this.cboSupplier.ValueMember = "SupplierID";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblSupplier.Location = new System.Drawing.Point(317, 75);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(73, 17);
            this.lblSupplier.TabIndex = 60;
            this.lblSupplier.Text = "Supplier:";
            // 
            // lblImportDate
            // 
            this.lblImportDate.AutoSize = true;
            this.lblImportDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblImportDate.Location = new System.Drawing.Point(316, 167);
            this.lblImportDate.Name = "lblImportDate";
            this.lblImportDate.Size = new System.Drawing.Size(95, 17);
            this.lblImportDate.TabIndex = 61;
            this.lblImportDate.Text = "Import date:";
            // 
            // dateImport
            // 
            this.dateImport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importBindingSource, "ImportDate", true));
            this.dateImport.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.importBindingSource, "ImportDate", true));
            this.dateImport.Location = new System.Drawing.Point(418, 164);
            this.dateImport.Name = "dateImport";
            this.dateImport.Size = new System.Drawing.Size(163, 20);
            this.dateImport.TabIndex = 62;
            // 
            // dateExpired
            // 
            this.dateExpired.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindingSource, "ExpiredDate", true));
            this.dateExpired.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.detailBindingSource, "ExpiredDate", true));
            this.dateExpired.Location = new System.Drawing.Point(418, 461);
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.Size = new System.Drawing.Size(163, 20);
            this.dateExpired.TabIndex = 78;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataSource = typeof(DrinkStore.Entities.ImportDetail);
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblExpired.Location = new System.Drawing.Point(316, 464);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(67, 17);
            this.lblExpired.TabIndex = 77;
            this.lblExpired.Text = "Expired:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProduct.Location = new System.Drawing.Point(317, 340);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 17);
            this.lblProduct.TabIndex = 76;
            this.lblProduct.Text = "Product:";
            // 
            // cboProduct
            // 
            this.cboProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detailBindingSource, "ProductID", true));
            this.cboProduct.DataSource = this.productBindingSource;
            this.cboProduct.DisplayMember = "Name";
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(418, 336);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(136, 21);
            this.cboProduct.TabIndex = 75;
            this.cboProduct.ValueMember = "ProductID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DrinkStore.Entities.Product);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.BackColor = System.Drawing.Color.Red;
            this.btnDeleteDetail.FlatAppearance.BorderSize = 0;
            this.btnDeleteDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDeleteDetail.Location = new System.Drawing.Point(499, 507);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(80, 26);
            this.btnDeleteDetail.TabIndex = 74;
            this.btnDeleteDetail.Text = "Delete";
            this.btnDeleteDetail.UseVisualStyleBackColor = false;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // pnlDataDetail
            // 
            this.pnlDataDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDataDetail.Controls.Add(this.dgvDetail);
            this.pnlDataDetail.Location = new System.Drawing.Point(21, 289);
            this.pnlDataDetail.Name = "pnlDataDetail";
            this.pnlDataDetail.Size = new System.Drawing.Size(289, 254);
            this.pnlDataDetail.TabIndex = 73;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AutoGenerateColumns = false;
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.unitCostDataGridViewTextBoxColumn,
            this.expiredDateDataGridViewTextBoxColumn});
            this.dgvDetail.DataSource = this.detailTBBindingSource;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(289, 254);
            this.dgvDetail.TabIndex = 0;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            this.dgvDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDetail_DataError);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.productIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.productIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIDDataGridViewTextBoxColumn.ValueMember = "ProductID";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitCostDataGridViewTextBoxColumn
            // 
            this.unitCostDataGridViewTextBoxColumn.DataPropertyName = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.HeaderText = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.Name = "unitCostDataGridViewTextBoxColumn";
            this.unitCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiredDateDataGridViewTextBoxColumn
            // 
            this.expiredDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiredDate";
            this.expiredDateDataGridViewTextBoxColumn.HeaderText = "ExpiredDate";
            this.expiredDateDataGridViewTextBoxColumn.Name = "expiredDateDataGridViewTextBoxColumn";
            this.expiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailTBBindingSource
            // 
            this.detailTBBindingSource.DataSource = typeof(DrinkStore.Entities.ImportDetail);
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdateDetail.FlatAppearance.BorderSize = 0;
            this.btnUpdateDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdateDetail.Location = new System.Drawing.Point(412, 507);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(80, 26);
            this.btnUpdateDetail.TabIndex = 72;
            this.btnUpdateDetail.Text = "Update";
            this.btnUpdateDetail.UseVisualStyleBackColor = false;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAddDetail.FlatAppearance.BorderSize = 0;
            this.btnAddDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAddDetail.Location = new System.Drawing.Point(323, 507);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(80, 26);
            this.btnAddDetail.TabIndex = 71;
            this.btnAddDetail.Text = "Add";
            this.btnAddDetail.UseVisualStyleBackColor = false;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindingSource, "UnitCost", true));
            this.txtUnitCost.Location = new System.Drawing.Point(418, 419);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(163, 20);
            this.txtUnitCost.TabIndex = 70;
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblUnitCost.Location = new System.Drawing.Point(317, 420);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(77, 17);
            this.lblUnitCost.TabIndex = 69;
            this.lblUnitCost.Text = "Unit cost:";
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindingSource, "Amount", true));
            this.txtAmount.Location = new System.Drawing.Point(418, 378);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(163, 20);
            this.txtAmount.TabIndex = 80;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblAmount.Location = new System.Drawing.Point(317, 378);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 17);
            this.lblAmount.TabIndex = 79;
            this.lblAmount.Text = "Amount:";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(561, 337);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(20, 20);
            this.btnSearchProduct.TabIndex = 81;
            this.btnSearchProduct.ButtonClick += new System.EventHandler(this.btnSearchProduct_Click);
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(561, 75);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(20, 20);
            this.btnAddSupplier.TabIndex = 68;
            this.btnAddSupplier.ButtonClick += new System.EventHandler(this.btnAddSupplier_Click);
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator2.AutoSize = true;
            this.lineSeparator2.Location = new System.Drawing.Point(21, 272);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator2.TabIndex = 44;
            // 
            // lineSeparator1
            // 
            this.lineSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator1.AutoSize = true;
            this.lineSeparator1.Location = new System.Drawing.Point(21, 38);
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator1.TabIndex = 28;
            // 
            // txtImportID
            // 
            this.txtImportID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importBindingSource, "ImportID", true));
            this.txtImportID.Location = new System.Drawing.Point(418, 300);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.ReadOnly = true;
            this.txtImportID.Size = new System.Drawing.Size(163, 20);
            this.txtImportID.TabIndex = 83;
            // 
            // lblImportID
            // 
            this.lblImportID.AutoSize = true;
            this.lblImportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblImportID.Location = new System.Drawing.Point(317, 303);
            this.lblImportID.Name = "lblImportID";
            this.lblImportID.Size = new System.Drawing.Size(73, 17);
            this.lblImportID.TabIndex = 82;
            this.lblImportID.Text = "ImportID:";
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.txtImportID);
            this.Controls.Add(this.lblImportID);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dateExpired);
            this.Controls.Add(this.lblExpired);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.pnlDataDetail);
            this.Controls.Add(this.btnUpdateDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.dateImport);
            this.Controls.Add(this.lblImportDate);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlDataImport);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmImport_MouseClick);
            this.pnlDataImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.pnlDataDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlDataImport;
        private System.Windows.Forms.DataGridView dgvImport;
        private Presentation.LineSeparator lineSeparator2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblCost;
        private Presentation.LineSeparator lineSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource importBindingSource;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblImportDate;
        private System.Windows.Forms.DateTimePicker dateImport;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private GUI_component.PlusButton btnAddSupplier;
        private System.Windows.Forms.BindingSource importTBBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn importQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentUnitQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBoxQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholeCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateExpired;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.Panel pnlDataDetail;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private System.Windows.Forms.BindingSource detailTBBindingSource;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private GUI_component.SearchButton btnSearchProduct;
        private System.Windows.Forms.TextBox txtImportID;
        private System.Windows.Forms.Label lblImportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn importIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDateDataGridViewTextBoxColumn;
    }
}