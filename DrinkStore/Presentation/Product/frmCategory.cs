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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            categoryTBBindingSource.DataSource = CategoryBUS.getAll();
            categoryBindingSource.DataSource = new Category();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryBUS.insert(categoryBindingSource.Current as Category);
            categoryTBBindingSource.DataSource = CategoryBUS.getAll();
            categoryBindingSource.DataSource = new Category();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CategoryBUS.update(categoryBindingSource.Current as Category);
            categoryTBBindingSource.DataSource = CategoryBUS.getAll();
            categoryBindingSource.DataSource = new Category();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryBindingSource.DataSource = categoryTBBindingSource.Current;
        }
    }
}
