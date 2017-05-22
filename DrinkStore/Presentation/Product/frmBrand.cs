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
    public partial class frmBrand : Form
    {
        public frmBrand()
        {
            InitializeComponent();
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            brandTBBindingSource.DataSource = BrandBUS.getAll();
            brandBindingSource.DataSource = new Brand();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandBUS.insert(brandBindingSource.Current as Brand);
            brandTBBindingSource.DataSource = BrandBUS.getAll();
            brandBindingSource.DataSource = new Brand();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BrandBUS.update(brandBindingSource.Current as Brand);
            brandTBBindingSource.DataSource = BrandBUS.getAll();
            brandBindingSource.DataSource = new Brand();
        }

        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            brandBindingSource.DataSource = brandTBBindingSource.Current;
        }
    }
}
