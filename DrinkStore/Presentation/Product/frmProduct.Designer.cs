namespace DrinkStore.Presentation
{
    partial class frmProduct
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
            this.pnlProductImg = new System.Windows.Forms.Panel();
            this.picProImg = new System.Windows.Forms.PictureBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.productTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProCat = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lineSeparator2 = new DrinkStore.Presentation.LineSeparator();
            this.lineSeparator1 = new DrinkStore.Presentation.LineSeparator();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.plusButton2 = new DrinkStore.GUI_component.PlusButton();
            this.btnAddCate = new DrinkStore.GUI_component.PlusButton();
            this.btnAddBrand = new DrinkStore.GUI_component.PlusButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddUnit = new DrinkStore.GUI_component.PlusButton();
            this.btnSearch = new DrinkStore.GUI_component.SearchButton();
            this.pnlProductImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBBindingSource)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(87, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product";
            // 
            // pnlProductImg
            // 
            this.pnlProductImg.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlProductImg.Controls.Add(this.picProImg);
            this.pnlProductImg.Location = new System.Drawing.Point(20, 55);
            this.pnlProductImg.Name = "pnlProductImg";
            this.pnlProductImg.Size = new System.Drawing.Size(150, 150);
            this.pnlProductImg.TabIndex = 2;
            // 
            // picProImg
            // 
            this.picProImg.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "Avatar", true));
            this.picProImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProImg.Location = new System.Drawing.Point(0, 0);
            this.picProImg.Name = "picProImg";
            this.picProImg.Size = new System.Drawing.Size(150, 150);
            this.picProImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProImg.TabIndex = 0;
            this.picProImg.TabStop = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DrinkStore.Entities.Product);
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProName.Location = new System.Drawing.Point(190, 55);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(54, 17);
            this.lblProName.TabIndex = 3;
            this.lblProName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(302, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 20);
            this.txtName.TabIndex = 0;
            // 
            // productTBBindingSource
            // 
            this.productTBBindingSource.DataSource = typeof(DrinkStore.Entities.Product);
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProPrice.Location = new System.Drawing.Point(192, 189);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(84, 17);
            this.lblProPrice.TabIndex = 8;
            this.lblProPrice.Text = "Unit Price:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "UnitPrice", true));
            this.txtUnitPrice.Location = new System.Drawing.Point(304, 184);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(142, 20);
            this.txtUnitPrice.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(302, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(399, 226);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.Red;
            this.btnImg.FlatAppearance.BorderSize = 0;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnImg.Location = new System.Drawing.Point(21, 226);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(149, 26);
            this.btnImg.TabIndex = 22;
            this.btnImg.Text = "Add Image";
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.Controls.Add(this.dgvProduct);
            this.pnlData.Location = new System.Drawing.Point(21, 288);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(560, 300);
            this.pnlData.TabIndex = 23;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.BrandID,
            this.categoryIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.UnitID});
            this.dgvProduct.DataSource = this.productTBBindingSource;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(560, 300);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProduct_DataError);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BrandID
            // 
            this.BrandID.DataPropertyName = "BrandID";
            this.BrandID.DataSource = this.brandBindingSource;
            this.BrandID.DisplayMember = "BrandName";
            this.BrandID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.BrandID.HeaderText = "BrandID";
            this.BrandID.Name = "BrandID";
            this.BrandID.ReadOnly = true;
            this.BrandID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BrandID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BrandID.ValueMember = "BrandID";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(DrinkStore.Entities.Brand);
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.DataSource = this.categoryBindingSource;
            this.categoryIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.categoryIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryIDDataGridViewTextBoxColumn.ValueMember = "CategoryID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DrinkStore.Entities.Category);
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.DataSource = this.unitBindingSource;
            this.UnitID.DisplayMember = "Name";
            this.UnitID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UnitID.HeaderText = "Unit";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            this.UnitID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitID.ValueMember = "UnitID";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(DrinkStore.Entities.Unit);
            // 
            // lblProCat
            // 
            this.lblProCat.AutoSize = true;
            this.lblProCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProCat.Location = new System.Drawing.Point(194, 99);
            this.lblProCat.Name = "lblProCat";
            this.lblProCat.Size = new System.Drawing.Size(78, 17);
            this.lblProCat.TabIndex = 24;
            this.lblProCat.Text = "Category:";
            // 
            // cboBrand
            // 
            this.cboBrand.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "BrandID", true));
            this.cboBrand.DataSource = this.brandBindingSource;
            this.cboBrand.DisplayMember = "BrandName";
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(304, 144);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(237, 21);
            this.cboBrand.TabIndex = 25;
            this.cboBrand.ValueMember = "BrandID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(498, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 26);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator2.AutoSize = true;
            this.lineSeparator2.Location = new System.Drawing.Point(21, 270);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator2.TabIndex = 20;
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
            this.lineSeparator1.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBrand.Location = new System.Drawing.Point(194, 148);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 17);
            this.lblBrand.TabIndex = 27;
            this.lblBrand.Text = "Brand:";
            // 
            // cboCate
            // 
            this.cboCate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryID", true));
            this.cboCate.DataSource = this.categoryBindingSource;
            this.cboCate.DisplayMember = "Name";
            this.cboCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(304, 98);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(237, 21);
            this.cboCate.TabIndex = 28;
            this.cboCate.ValueMember = "CategoryID";
            // 
            // plusButton2
            // 
            this.plusButton2.Location = new System.Drawing.Point(-15, -15);
            this.plusButton2.Margin = new System.Windows.Forms.Padding(0);
            this.plusButton2.Name = "plusButton2";
            this.plusButton2.Size = new System.Drawing.Size(20, 20);
            this.plusButton2.TabIndex = 30;
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(557, 99);
            this.btnAddCate.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(20, 20);
            this.btnAddCate.TabIndex = 31;
            this.btnAddCate.ButtonClick += new System.EventHandler(this.btnAddCate_Click);
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(557, 144);
            this.btnAddBrand.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(20, 20);
            this.btnAddBrand.TabIndex = 32;
            this.btnAddBrand.ButtonClick += new System.EventHandler(this.btnAddBrand_Click);
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "UnitID", true));
            this.comboBox1.DataSource = this.unitBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(452, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.ValueMember = "UnitID";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(557, 184);
            this.btnAddUnit.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(20, 20);
            this.btnAddUnit.TabIndex = 35;
            this.btnAddUnit.ButtonClick += new System.EventHandler(this.btnAddUnit_Click);
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(557, 55);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.ButtonClick += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.btnAddCate);
            this.Controls.Add(this.plusButton2);
            this.Controls.Add(this.cboCate);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.lblProCat);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.pnlProductImg);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmProduct_MouseClick);
            this.pnlProductImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBBindingSource)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Presentation.LineSeparator lineSeparator1;
        private System.Windows.Forms.Panel pnlProductImg;
        private System.Windows.Forms.PictureBox picProImg;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private Presentation.LineSeparator lineSeparator2;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblProCat;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource productTBBindingSource;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholeSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailSaleDataGridViewTextBoxColumn;
        private GUI_component.PlusButton plusButton2;
        private GUI_component.PlusButton btnAddCate;
        private GUI_component.PlusButton btnAddBrand;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private GUI_component.PlusButton btnAddUnit;
        private GUI_component.SearchButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitID;
    }
}