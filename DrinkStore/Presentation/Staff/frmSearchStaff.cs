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
    public partial class frmSearchStaff : Form
    {
        private Staff _staff;
        public frmSearchStaff()
        {
            InitializeComponent();
        }

        private void frmSerchStaff_Load(object sender, EventArgs e)
        {
            _staff = new Staff();
            staffTBBindingSource.DataSource = StaffBUS.getAll();
            staffBindingSource.DataSource = new Staff();
            positionBindingSource.DataSource = PositionBUS.getAll();
            
        }

      

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            staffBindingSource.DataSource = staffTBBindingSource.Current;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string _name = txtName.Text;
            string _position = (staffBindingSource.Current as Staff).PositionCode;

            staffTBBindingSource.DataSource = StaffBUS.search(_name, _position);
        }

        private void frmSearchStaff_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                staffTBBindingSource.DataSource = StaffBUS.getAll();
                staffBindingSource.DataSource = new Staff();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _staff = staffBindingSource.DataSource as Staff;
            this.Close();
        }

        public Staff getStaff()
        {
            return _staff;
        }

        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
