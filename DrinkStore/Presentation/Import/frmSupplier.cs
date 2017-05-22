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
    public partial class frmSupplier: Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            supplierTBBindingSource.DataSource = SupplierBUS.getAll();
            supplierBindingSource.DataSource = new Supplier();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierBUS.insert(supplierBindingSource.Current as Supplier);
            supplierTBBindingSource.DataSource = SupplierBUS.getAll();
            supplierBindingSource.DataSource = new Supplier();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SupplierBUS.update(supplierBindingSource.Current as Supplier);
            supplierTBBindingSource.DataSource = SupplierBUS.getAll();
            supplierBindingSource.DataSource = new Supplier();
        }

       

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierBindingSource.DataSource = supplierTBBindingSource.Current;
        }
    }
}
