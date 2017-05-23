namespace DrinkStore.Presentation
{
    partial class frmSearchStaff
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
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.closeButton1 = new DrinkStore.Presentation.CloseButton();
            this.pnlTop = new DrinkStore.GUI_component.MovePanel();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProName = new System.Windows.Forms.Label();
            this.pnlProductImg = new System.Windows.Forms.Panel();
            this.picProImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.pnlProductImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).BeginInit();
            this.SuspendLayout();
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(DrinkStore.Entities.Staff);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderIDDataGridViewTextBoxColumn,
            this.positionCodeDataGridViewTextBoxColumn});
            this.dgvCategory.DataSource = this.staffTBBindingSource;
            this.dgvCategory.Location = new System.Drawing.Point(18, 239);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(418, 249);
            this.dgvCategory.TabIndex = 61;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
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
            // genderIDDataGridViewTextBoxColumn
            // 
            this.genderIDDataGridViewTextBoxColumn.DataPropertyName = "GenderID";
            this.genderIDDataGridViewTextBoxColumn.HeaderText = "GenderID";
            this.genderIDDataGridViewTextBoxColumn.Name = "genderIDDataGridViewTextBoxColumn";
            this.genderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionCodeDataGridViewTextBoxColumn
            // 
            this.positionCodeDataGridViewTextBoxColumn.DataPropertyName = "PositionCode";
            this.positionCodeDataGridViewTextBoxColumn.HeaderText = "PositionCode";
            this.positionCodeDataGridViewTextBoxColumn.Name = "positionCodeDataGridViewTextBoxColumn";
            this.positionCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffTBBindingSource
            // 
            this.staffTBBindingSource.DataSource = typeof(DrinkStore.Entities.Staff);
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(DrinkStore.Entities.Position);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnSelect.Location = new System.Drawing.Point(356, 183);
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
            this.btnSearch.Location = new System.Drawing.Point(274, 183);
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
            this.lblLogo.Size = new System.Drawing.Size(150, 25);
            this.lblLogo.TabIndex = 66;
            this.lblLogo.Text = "Search staff";
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.closeButton1.Location = new System.Drawing.Point(412, 7);
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
            this.pnlTop.Size = new System.Drawing.Size(450, 39);
            this.pnlTop.TabIndex = 64;
            // 
            // cboPosition
            // 
            this.cboPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.staffBindingSource, "PositionCode", true));
            this.cboPosition.DataSource = this.positionBindingSource;
            this.cboPosition.DisplayMember = "PositionName";
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(274, 102);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(162, 21);
            this.cboPosition.TabIndex = 72;
            this.cboPosition.ValueMember = "PositionCode";
            this.cboPosition.SelectedIndexChanged += new System.EventHandler(this.cboCate_SelectedIndexChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblPosition.Location = new System.Drawing.Point(190, 106);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(71, 17);
            this.lblPosition.TabIndex = 69;
            this.lblPosition.Text = "Position:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(274, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 20);
            this.txtName.TabIndex = 67;
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProName.Location = new System.Drawing.Point(190, 62);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(54, 17);
            this.lblProName.TabIndex = 68;
            this.lblProName.Text = "Name:";
            // 
            // pnlProductImg
            // 
            this.pnlProductImg.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlProductImg.Controls.Add(this.picProImg);
            this.pnlProductImg.Location = new System.Drawing.Point(18, 59);
            this.pnlProductImg.Name = "pnlProductImg";
            this.pnlProductImg.Size = new System.Drawing.Size(150, 150);
            this.pnlProductImg.TabIndex = 73;
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
            // frmSearchStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.pnlProductImg);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.frmSerchStaff_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmSearchStaff_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.pnlProductImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.BindingSource staffTBBindingSource;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private GUI_component.MovePanel pnlTop;
        private CloseButton closeButton1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.Panel pnlProductImg;
        private System.Windows.Forms.PictureBox picProImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionCodeDataGridViewTextBoxColumn;
    }
}