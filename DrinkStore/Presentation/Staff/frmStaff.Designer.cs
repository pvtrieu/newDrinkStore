namespace DrinkStore.Presentation
{
    partial class frmStaff
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
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.staffTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGender = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lineSeparator2 = new DrinkStore.Presentation.LineSeparator();
            this.lineSeparator1 = new DrinkStore.Presentation.LineSeparator();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.btnSearch = new DrinkStore.GUI_component.SearchButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlProductImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTBBindingSource)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(57, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Staff";
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
            this.picProImg.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.staffBindingSource, "Avatar", true));
            this.picProImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProImg.Location = new System.Drawing.Point(0, 0);
            this.picProImg.Name = "picProImg";
            this.picProImg.Size = new System.Drawing.Size(150, 150);
            this.picProImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProImg.TabIndex = 0;
            this.picProImg.TabStop = false;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(DrinkStore.Entities.Staff);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblName.Location = new System.Drawing.Point(196, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(302, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 20);
            this.txtName.TabIndex = 0;
            // 
            // staffTBBindingSource
            // 
            this.staffTBBindingSource.DataSource = typeof(DrinkStore.Entities.Staff);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(305, 306);
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
            this.btnUpdate.Location = new System.Drawing.Point(402, 306);
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
            this.btnImg.Location = new System.Drawing.Point(21, 225);
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
            this.pnlData.Controls.Add(this.dgvStaff);
            this.pnlData.Location = new System.Drawing.Point(21, 370);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(560, 218);
            this.pnlData.TabIndex = 23;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AutoGenerateColumns = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderIDDataGridViewTextBoxColumn,
            this.positionCodeDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn});
            this.dgvStaff.DataSource = this.staffTBBindingSource;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(560, 218);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            this.dgvStaff.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvStaff_DataError);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderIDDataGridViewTextBoxColumn
            // 
            this.genderIDDataGridViewTextBoxColumn.DataPropertyName = "GenderID";
            this.genderIDDataGridViewTextBoxColumn.DataSource = this.genderBindingSource;
            this.genderIDDataGridViewTextBoxColumn.DisplayMember = "GenderName";
            this.genderIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.genderIDDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderIDDataGridViewTextBoxColumn.Name = "genderIDDataGridViewTextBoxColumn";
            this.genderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genderIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genderIDDataGridViewTextBoxColumn.ValueMember = "GenderID";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(DrinkStore.Entities.Gender);
            // 
            // positionCodeDataGridViewTextBoxColumn
            // 
            this.positionCodeDataGridViewTextBoxColumn.DataPropertyName = "PositionCode";
            this.positionCodeDataGridViewTextBoxColumn.HeaderText = "PositionCode";
            this.positionCodeDataGridViewTextBoxColumn.Name = "positionCodeDataGridViewTextBoxColumn";
            this.positionCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            this.birthDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(DrinkStore.Entities.Position);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblGender.Location = new System.Drawing.Point(196, 159);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 17);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(501, 306);
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
            this.lineSeparator2.Location = new System.Drawing.Point(21, 348);
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
            // cboGender
            // 
            this.cboGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.staffBindingSource, "GenderID", true));
            this.cboGender.DataSource = this.genderBindingSource;
            this.cboGender.DisplayMember = "GenderName";
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(302, 158);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(63, 21);
            this.cboGender.TabIndex = 4;
            this.cboGender.ValueMember = "GenderID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(561, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.ButtonClick += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Username", true));
            this.txtUsername.Location = new System.Drawing.Point(302, 81);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(279, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblUsername.Location = new System.Drawing.Point(196, 82);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 17);
            this.lblUsername.TabIndex = 38;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(302, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(279, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblPassword.Location = new System.Drawing.Point(196, 108);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 17);
            this.lblPassword.TabIndex = 40;
            this.lblPassword.Text = "Password:";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(302, 212);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(279, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblPhone.Location = new System.Drawing.Point(196, 215);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 17);
            this.lblPhone.TabIndex = 42;
            this.lblPhone.Text = "Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Adress", true));
            this.txtAddress.Location = new System.Drawing.Point(302, 238);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(279, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblAddress.Location = new System.Drawing.Point(196, 239);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 17);
            this.lblAddress.TabIndex = 44;
            this.lblAddress.Text = "Address:";
            // 
            // txtSalary
            // 
            this.txtSalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Salary", true));
            this.txtSalary.Location = new System.Drawing.Point(302, 264);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(279, 20);
            this.txtSalary.TabIndex = 9;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblSalary.Location = new System.Drawing.Point(196, 265);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(59, 17);
            this.lblSalary.TabIndex = 46;
            this.lblSalary.Text = "Salary:";
            // 
            // cboPosition
            // 
            this.cboPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.staffBindingSource, "PositionCode", true));
            this.cboPosition.DataSource = this.positionBindingSource;
            this.cboPosition.DisplayMember = "PositionName";
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(466, 159);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(115, 21);
            this.cboPosition.TabIndex = 5;
            this.cboPosition.ValueMember = "PositionCode";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblPosition.Location = new System.Drawing.Point(389, 160);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(71, 17);
            this.lblPosition.TabIndex = 47;
            this.lblPosition.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(196, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "BirthDay:";
            // 
            // dateBirthDay
            // 
            this.dateBirthDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "BirthDay", true));
            this.dateBirthDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.staffBindingSource, "BirthDay", true));
            this.dateBirthDay.Location = new System.Drawing.Point(302, 186);
            this.dateBirthDay.Name = "dateBirthDay";
            this.dateBirthDay.Size = new System.Drawing.Size(279, 20);
            this.dateBirthDay.TabIndex = 6;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(302, 133);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(279, 20);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(196, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Confirm:";
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateBirthDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlProductImg);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaff";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmStaff_MouseClick);
            this.pnlProductImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTBBindingSource)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Presentation.LineSeparator lineSeparator1;
        private System.Windows.Forms.Panel pnlProductImg;
        private System.Windows.Forms.PictureBox picProImg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private Presentation.LineSeparator lineSeparator2;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource staffTBBindingSource;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private GUI_component.SearchButton btnSearch;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBirthDay;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
    }
}