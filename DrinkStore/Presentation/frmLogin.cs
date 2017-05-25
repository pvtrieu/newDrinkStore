using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinkStore.BUS;
using DrinkStore.Entities;

namespace DrinkStore.Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check empty username
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter username", "Message", MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }


            //Authorize account
            if (StaffBUS.valid(txtUsername.Text, txtPassword.Text))
            {                
                Staff staff = StaffBUS.getByUsername(txtUsername.Text);                
                frmMain _frmMain = new frmMain(staff);
                this.Hide();
                _frmMain.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Incorrect account/password. Please enter again", "Message", MessageBoxButtons.OK);
            }
                
        }
    }
}
