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
    public partial class frmSearchProduct : Form
    {
        private Product _product;
        public frmSearchProduct()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            _product = new Product();
            productTBBindingSource.DataSource = ProductBUS.getAll();
            productBindingSource.DataSource = new Product();
            categoryBindingSource.DataSource = CategoryBUS.getAll();
            brandBindingSource.DataSource = BrandBUS.getAll();
        }

      

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productBindingSource.DataSource = productTBBindingSource.Current;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string _name = txtName.Text;
            int? _catID = (int?)cboCate.SelectedValue;
            int? _brandID = (int?)cboBrand.SelectedValue;
            productTBBindingSource.DataSource = ProductBUS.search(_name, _catID, _brandID);
        }

        private void frmSearchProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                productTBBindingSource.DataSource = ProductBUS.getAll();
                productBindingSource.DataSource = new Product();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _product = productBindingSource.DataSource as Product;
            this.Close();
        }

        public Product getProduct()
        {
            return _product;
        }
    }
}
