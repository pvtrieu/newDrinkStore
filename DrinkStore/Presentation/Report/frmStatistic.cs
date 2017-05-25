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
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
        }

        private void frmStatistic_Load(object sender, EventArgs e)
        {

            
            ImportBindingSource.DataSource = ImportBUS.getAll(frmMain._Pstaff);
            OrderBindingSource.DataSource = OrderBUS.getAll(frmMain._Pstaff);
            this.reportImport.RefreshReport();
            this.reportOrder.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
