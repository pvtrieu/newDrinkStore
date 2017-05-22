﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinkStore.Entities;
using DrinkStore.BUS;

namespace DrinkStore.Presentation
{
    public partial class frmImport : Form
    {
        //Current import
        Import _import = new Import();

        public frmImport()
        {
            InitializeComponent();
        }


        //*******************************************************************//
        //             Import part                                           //
        //*******************************************************************//

        // Load database to view, reset form
        private void onLoad()
        {
            importTBBindingSource.DataSource = ImportBUS.getAll();       
            importBindingSource.DataSource = new Import();

            productBindingSource.DataSource = ProductBUS.getAll();
            supplierBindingSource.DataSource = SupplierBUS.getAll();

            detailBindingSource.DataSource = new ImportDetail();
            detailTBBindingSource.DataSource = new ImportDetail();

            dgvImport.ClearSelection();
            dgvDetail.ClearSelection();
        }
        private void frmImport_Load(object sender, EventArgs e)
        {
            onLoad();
        }

        //Load import from datagridview to current form    
        private void dgvImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            importBindingSource.DataSource = importTBBindingSource.Current;
            _import = importTBBindingSource.Current as Import;
            detailTBBindingSource.DataSource = ImportDetailBUS.getAll(_import);
            txtImportID.Text = _import.ImportID.ToString();
        }

        //Add new import
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ImportBUS.add(importBindingSource.Current as Import);
            importTBBindingSource.DataSource = ImportBUS.getAll();

            //Select latest import
            int nRowIndex = dgvImport.Rows.Count - 2;
            dgvImport.CurrentCell = dgvImport.Rows[nRowIndex].Cells[0];
            dgvImport_CellClick(this.dgvImport, new DataGridViewCellEventArgs(nRowIndex, 0));
        }

        //Update import
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ImportBUS.update(importBindingSource.Current as Import);
            onLoad();
        }

        //Delete import
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ImportBUS.delete(importBindingSource.Current as Import);
            onLoad();
        }

      
        //Right click to reset form
        private void frmImport_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                onLoad();
        }

        //Open supplier form
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier _frmSupplier = new frmSupplier();
            if (_frmSupplier.ShowDialog() == DialogResult.Cancel)
            {
                supplierBindingSource.DataSource = SupplierBUS.getAll();
            }
        }

        //*******************************************************************//
        //             Import detail part                                    //
        //*******************************************************************//

        //Reset detail form
        private void reLoad()
        {
            ImportBUS.sumImport(_import);
            txtTotalCost.Text = _import.TotalCost.ToString();
            detailTBBindingSource.DataSource = ImportDetailBUS.getAll(_import);
            detailBindingSource.DataSource = new ImportDetail();
            productBindingSource.DataSource = ProductBUS.getAll();

        }

        //Add new import detail
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            ImportDetail _detail = detailBindingSource.Current as ImportDetail;
            _detail.ImportID = _import.ImportID;
            ImportDetailBUS.add(_detail);
            reLoad();
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detailBindingSource.DataSource = detailTBBindingSource.Current;
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            ImportDetailBUS.update(detailBindingSource.DataSource as ImportDetail);
            reLoad();
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            ImportDetailBUS.delete(detailBindingSource.DataSource as ImportDetail);
            reLoad();
        }



        //Pass combobox error in datagridview
        private void dgvImport_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            frmSearchProduct _frmSearch = new frmSearchProduct();
            _frmSearch.ShowDialog();
            productBindingSource.DataSource = _frmSearch.getProduct();
        }
    }
}