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
    public partial class frmSearchImport : Form
    {
        private Import _import;
        public frmSearchImport()
        {
            InitializeComponent();
        }

        private void frmSerchImport_Load(object sender, EventArgs e)
        {
            _import = new Import();
            importTBBindingSource.DataSource = ImportBUS.getAll(frmMain._Pstaff);
            importBindingSource.DataSource = new Import();
            supplierBindingSource.DataSource = SupplierBUS.getAll();
            
        }

      

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            importBindingSource.DataSource = importTBBindingSource.Current;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int? _supplierID = (int?)cboSupplier.SelectedValue;
            DateTime? _after = dateAfter.Value;
            DateTime? _before = dateBefore.Value;


            importTBBindingSource.DataSource = ImportBUS.search(_supplierID, _after, _before);
        }

        private void frmSearchImport_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                importTBBindingSource.DataSource = ImportBUS.getAll(frmMain._Pstaff);
                importBindingSource.DataSource = new Import();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _import = importBindingSource.DataSource as Import;
            this.Close();
        }

        public Import getImport()
        {
            return _import;
        }

        

        private void dgvCategory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
