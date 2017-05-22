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
    public partial class frmUnit : Form
    {
        public frmUnit()
        {
            InitializeComponent();
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {
            unitTBBindingSource.DataSource = UnitBUS.getAll();
            unitBindingSource.DataSource = new Unit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UnitBUS.insert(unitBindingSource.Current as Unit);
            unitTBBindingSource.DataSource = UnitBUS.getAll();
            unitBindingSource.DataSource = new Unit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UnitBUS.update(unitBindingSource.Current as Unit);
            unitTBBindingSource.DataSource = UnitBUS.getAll();
            unitBindingSource.DataSource = new Unit();
        }

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            unitBindingSource.DataSource = unitTBBindingSource.Current;
        }
    }
}
