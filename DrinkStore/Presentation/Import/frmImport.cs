using System;
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
            offBtn();
            _import = new Import();
            importTBBindingSource.DataSource = ImportBUS.getAll(frmMain._Pstaff);       
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
            onBtn();
            importBindingSource.DataSource = importTBBindingSource.Current;
            _import = importTBBindingSource.Current as Import;
            detailTBBindingSource.DataSource = ImportDetailBUS.getAll(_import);
            txtImportID.Text = _import.ImportID.ToString();
        }

        //Add new import
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _import = (importBindingSource.Current as Import);
            _import.StaffID = frmMain._Pstaff.StaffID;
            ImportBUS.add(_import);
            importTBBindingSource.DataSource = ImportBUS.getAll(frmMain._Pstaff);

            //Select latest import
            int nRowIndex = dgvImport.Rows.Count - 2;
            dgvImport.CurrentCell = dgvImport.Rows[nRowIndex].Cells[0];
            dgvImport_CellClick(this.dgvImport, new DataGridViewCellEventArgs(nRowIndex, 0));
        }

        //Update import
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ImportBUS.update(_import))
                MessageBox.Show("Please select import");
        }

        //Delete import
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Message", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!ImportBUS.delete(_import))
                    MessageBox.Show("Please select import");
            }

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

        //Toggle Detail button    
        private void offBtn()
        {
            btnAddDetail.Enabled = false;
            btnUpdateDetail.Enabled = false;
            btnDeleteDetail.Enabled = false;
        }
        private void onBtn()
        {
            btnAddDetail.Enabled = true;
            btnUpdateDetail.Enabled = true;
            btnDeleteDetail.Enabled = true;
        }


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
            ImportDetail _detail = detailBindingSource.Current as ImportDetail;
            if (!ImportDetailBUS.update(_detail))
                MessageBox.Show("Please select import");
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            ImportDetail _detail = detailBindingSource.Current as ImportDetail;
            if (MessageBox.Show("Message", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!ImportDetailBUS.delete(_detail))
                    MessageBox.Show("Please select import");
            }
                
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

        private void btnSearchImport_Click(object sender, EventArgs e)
        {
            frmSearchImport _frmSearch = new frmSearchImport();
            _frmSearch.ShowDialog();
            productBindingSource.DataSource = _frmSearch.getImport();
        }
    }
}
