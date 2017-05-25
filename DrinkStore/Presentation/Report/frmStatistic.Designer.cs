namespace DrinkStore.Presentation
{
    partial class frmStatistic
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lblTitle = new System.Windows.Forms.Label();
            this.reportImport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.lineSeparator3 = new DrinkStore.Presentation.LineSeparator();
            this.lineSeparator2 = new DrinkStore.Presentation.LineSeparator();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineSeparator1 = new DrinkStore.Presentation.LineSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBindingSource)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(74, 26);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Import";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // reportImport
            // 
            this.reportImport.BackColor = System.Drawing.SystemColors.Control;
            reportDataSource1.Name = "ImportDataSet";
            reportDataSource1.Value = this.ImportBindingSource;
            this.reportImport.LocalReport.DataSources.Add(reportDataSource1);
            this.reportImport.LocalReport.ReportEmbeddedResource = "DrinkStore.Presentation.Report.ImportReport.rdlc";
            this.reportImport.Location = new System.Drawing.Point(21, 46);
            this.reportImport.Name = "reportImport";
            this.reportImport.Size = new System.Drawing.Size(560, 218);
            this.reportImport.TabIndex = 4;
            // 
            // reportOrder
            // 
            this.reportOrder.BackColor = System.Drawing.SystemColors.Control;
            reportDataSource2.Name = "OrderDataSet";
            reportDataSource2.Value = this.OrderBindingSource;
            this.reportOrder.LocalReport.DataSources.Add(reportDataSource2);
            this.reportOrder.LocalReport.ReportEmbeddedResource = "DrinkStore.Presentation.Report.OrderReport.rdlc";
            this.reportOrder.Location = new System.Drawing.Point(21, 354);
            this.reportOrder.Name = "reportOrder";
            this.reportOrder.Size = new System.Drawing.Size(560, 234);
            this.reportOrder.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(16, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order";
            // 
            // lineSeparator3
            // 
            this.lineSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator3.AutoSize = true;
            this.lineSeparator3.Location = new System.Drawing.Point(21, 292);
            this.lineSeparator3.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator3.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator3.Name = "lineSeparator3";
            this.lineSeparator3.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator3.TabIndex = 8;
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator2.AutoSize = true;
            this.lineSeparator2.Location = new System.Drawing.Point(21, 346);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator2.TabIndex = 7;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(DrinkStore.Entities.Order);
            // 
            // ImportBindingSource
            // 
            this.ImportBindingSource.DataSource = typeof(DrinkStore.Entities.Import);
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
            this.lineSeparator1.TabIndex = 3;
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.lineSeparator3);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportOrder);
            this.Controls.Add(this.reportImport);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Presentation.LineSeparator lineSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource ImportBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportImport;
        private Microsoft.Reporting.WinForms.ReportViewer reportOrder;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private LineSeparator lineSeparator2;
        private System.Windows.Forms.Label label1;
        private LineSeparator lineSeparator3;
    }
}