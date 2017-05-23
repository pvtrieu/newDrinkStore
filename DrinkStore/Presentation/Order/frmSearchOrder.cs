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
    public partial class frmSearchOrder : Form
    {
        private Order _order;
        public frmSearchOrder()
        {
            InitializeComponent();
        }

        private void frmSerchOrder_Load(object sender, EventArgs e)
        {
            _order = new Order();
            orderTBBindingSource.DataSource = OrderBUS.getAll(frmMain._Pstaff);
            orderBindingSource.DataSource = new Order();
            
            
        }

      

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderBindingSource.DataSource = orderTBBindingSource.Current;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            DateTime? _after = dateAfter.Value;
            DateTime? _before = dateBefore.Value;


            orderTBBindingSource.DataSource = OrderBUS.search(_after, _before);
        }

        private void frmSearchOrder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                orderTBBindingSource.DataSource = OrderBUS.getAll(frmMain._Pstaff);
                orderBindingSource.DataSource = new Order();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _order = orderBindingSource.DataSource as Order;
            this.Close();
        }

        public Order getOrder()
        {
            return _order;
        }

        

        private void dgvCategory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
