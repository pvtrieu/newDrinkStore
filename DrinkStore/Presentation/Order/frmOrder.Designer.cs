namespace DrinkStore.Presentation
{
    partial class frmOrder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.pnlOrderData = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDetailData = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.btnSearchProduct = new DrinkStore.GUI_component.SearchButton();
            this.lineSeparator2 = new DrinkStore.Presentation.LineSeparator();
            this.lineSeparator1 = new DrinkStore.Presentation.LineSeparator();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.pnlOrderData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBBindingSource)).BeginInit();
            this.pnlDetailData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(67, 26);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Order";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTotalCost.Location = new System.Drawing.Point(313, 58);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(87, 17);
            this.lblTotalCost.TabIndex = 80;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDeleteOrder.Location = new System.Drawing.Point(499, 238);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(80, 26);
            this.btnDeleteOrder.TabIndex = 83;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblDate.Location = new System.Drawing.Point(313, 142);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 17);
            this.lblDate.TabIndex = 84;
            this.lblDate.Text = "Date:";
            // 
            // dateOrder
            // 
            this.dateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderDate", true));
            this.dateOrder.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDate", true));
            this.dateOrder.Location = new System.Drawing.Point(423, 142);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(156, 20);
            this.dateOrder.TabIndex = 86;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DrinkStore.Entities.Order);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "TotalCost", true));
            this.txtTotalCost.Location = new System.Drawing.Point(423, 58);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(158, 20);
            this.txtTotalCost.TabIndex = 87;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAddOrder.Location = new System.Drawing.Point(316, 238);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(80, 26);
            this.btnAddOrder.TabIndex = 89;
            this.btnAddOrder.Text = "New";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // pnlOrderData
            // 
            this.pnlOrderData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrderData.Controls.Add(this.dgvOrder);
            this.pnlOrderData.Location = new System.Drawing.Point(21, 58);
            this.pnlOrderData.Name = "pnlOrderData";
            this.pnlOrderData.Size = new System.Drawing.Size(269, 206);
            this.pnlOrderData.TabIndex = 95;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.dgvOrder.DataSource = this.orderTBBindingSource;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(269, 206);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTBBindingSource
            // 
            this.orderTBBindingSource.DataSource = typeof(DrinkStore.Entities.Order);
            // 
            // pnlDetailData
            // 
            this.pnlDetailData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetailData.Controls.Add(this.dgvDetail);
            this.pnlDetailData.Location = new System.Drawing.Point(21, 308);
            this.pnlDetailData.Name = "pnlDetailData";
            this.pnlDetailData.Size = new System.Drawing.Size(269, 245);
            this.pnlDetailData.TabIndex = 105;
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
            this.unitCostDataGridViewTextBoxColumn});
            this.dgvDetail.DataSource = this.detailTBBindingSource;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(269, 245);
            this.dgvDetail.TabIndex = 0;
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DrinkStore.Entities.Product);
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
            // detailTBBindingSource
            // 
            this.detailTBBindingSource.DataSource = typeof(DrinkStore.Entities.OrderDetail);
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindingSource, "Amount", true));
            this.txtAmount.Location = new System.Drawing.Point(426, 442);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(158, 20);
            this.txtAmount.TabIndex = 104;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataSource = typeof(DrinkStore.Entities.OrderDetail);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblAmount.Location = new System.Drawing.Point(316, 442);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 17);
            this.lblAmount.TabIndex = 103;
            this.lblAmount.Text = "Amount:";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAddDetail.FlatAppearance.BorderSize = 0;
            this.btnAddDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAddDetail.Location = new System.Drawing.Point(316, 527);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(80, 26);
            this.btnAddDetail.TabIndex = 102;
            this.btnAddDetail.Text = "Add";
            this.btnAddDetail.UseVisualStyleBackColor = false;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderID", true));
            this.txtOrderID.Location = new System.Drawing.Point(426, 308);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(158, 20);
            this.txtOrderID.TabIndex = 101;
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDetail.BackColor = System.Drawing.Color.Red;
            this.btnDeleteDetail.FlatAppearance.BorderSize = 0;
            this.btnDeleteDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDeleteDetail.Location = new System.Drawing.Point(499, 527);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(80, 26);
            this.btnDeleteDetail.TabIndex = 98;
            this.btnDeleteDetail.Text = "Delete";
            this.btnDeleteDetail.UseVisualStyleBackColor = false;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdateDetail.FlatAppearance.BorderSize = 0;
            this.btnUpdateDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdateDetail.Location = new System.Drawing.Point(408, 527);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(80, 26);
            this.btnUpdateDetail.TabIndex = 97;
            this.btnUpdateDetail.Text = "Update";
            this.btnUpdateDetail.UseVisualStyleBackColor = false;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblOrderID.Location = new System.Drawing.Point(316, 308);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(65, 17);
            this.lblOrderID.TabIndex = 96;
            this.lblOrderID.Text = "OrderID";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindingSource, "UnitCost", true));
            this.txtUnitCost.Location = new System.Drawing.Point(426, 397);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.ReadOnly = true;
            this.txtUnitCost.Size = new System.Drawing.Size(158, 20);
            this.txtUnitCost.TabIndex = 107;
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblUnitCost.Location = new System.Drawing.Point(316, 397);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(79, 17);
            this.lblUnitCost.TabIndex = 106;
            this.lblUnitCost.Text = "Unit Cost:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProduct.Location = new System.Drawing.Point(316, 353);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 17);
            this.lblProduct.TabIndex = 109;
            this.lblProduct.Text = "Product:";
            // 
            // cboProduct
            // 
            this.cboProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detailBindingSource, "ProductID", true));
            this.cboProduct.DataSource = this.productBindingSource;
            this.cboProduct.DisplayMember = "Name";
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(426, 352);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(136, 21);
            this.cboProduct.TabIndex = 108;
            this.cboProduct.ValueMember = "ProductID";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(565, 353);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(20, 20);
            this.btnSearchProduct.TabIndex = 110;
            this.btnSearchProduct.ButtonClick += new System.EventHandler(this.btnSearchProduct_Click);
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator2.AutoSize = true;
            this.lineSeparator2.Location = new System.Drawing.Point(21, 281);
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
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdateOrder.FlatAppearance.BorderSize = 0;
            this.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdateOrder.Location = new System.Drawing.Point(408, 238);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(80, 26);
            this.btnUpdateOrder.TabIndex = 111;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.pnlDetailData);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.btnUpdateDetail);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.pnlOrderData);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lblTotalCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.pnlOrderData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBBindingSource)).EndInit();
            this.pnlDetailData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Presentation.LineSeparator lineSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnAddOrder;
        private LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel pnlOrderData;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderTBBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource detailTBBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlDetailData;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label lblUnitCost;
        private GUI_component.SearchButton btnSearchProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdateOrder;
    }
}