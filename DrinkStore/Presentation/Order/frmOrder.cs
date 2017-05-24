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
    public partial class frmOrder : Form
    {
        Order _order = new Order();
        public frmOrder()
        {
            InitializeComponent();
        }

        //*******************************************************************//
        //                           ORDER                                   //
        //*******************************************************************//

        private void initLoad()
        {
            offBtn();
            orderBindingSource.DataSource = new Order();
            orderTBBindingSource.DataSource = OrderBUS.getAll(frmMain._Pstaff);
            productBindingSource.DataSource = ProductBUS.getAll();
            detailBindingSource.DataSource = new OrderDetail();
            detailTBBindingSource.DataSource = new OrderDetail();
            dgvOrder.ClearSelection();
            dgvDetail.ClearSelection();
        }

  
        private void frmOrder_Load(object sender, EventArgs e)
        {
            initLoad();
        }

        
        

       

        private void dgvOrderDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //Select order form datagridview
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            onBtn();
            orderBindingSource.DataSource = orderTBBindingSource.Current;
            _order = orderTBBindingSource.Current as Order;
            detailTBBindingSource.DataSource = OrderDetailBUS.getAll(_order);
            txtOrderID.Text = _order.OrderID.ToString();
        }
        
        //Add new order
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderBUS.add(orderBindingSource.Current as Order);
            orderTBBindingSource.DataSource = OrderBUS.getAll(frmMain._Pstaff);

            //Select latest import
            int nRowIndex = dgvOrder.Rows.Count - 2;
            dgvOrder.CurrentCell = dgvOrder.Rows[nRowIndex].Cells[0];
            dgvOrder_CellClick(this.dgvOrder, new DataGridViewCellEventArgs(nRowIndex, 0));
        }

        //Update order
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            OrderBUS.update(orderBindingSource.DataSource as Order);
            initLoad();
        }

        //Delete order
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            OrderBUS.delete(orderBindingSource.DataSource as Order);
            initLoad();
        }

        //Reset the order detail form
        private void reLoad()
        {
            detailTBBindingSource.DataSource = OrderDetailBUS.getAll(_order);
            detailBindingSource.DataSource = new OrderDetail();
            productBindingSource.DataSource = ProductBUS.getAll();
            OrderBUS.sumOrder(_order);
            orderBindingSource.DataSource = _order;
        }


        //Toggle Detail button    
        private void offBtn()
        {
            btnAddDetail.Enabled = false;
            btnUpdateDetail.Enabled = false;
            btnDeleteDetail.Enabled = false;
        }
        private void onBtn()
        {
            btnAddDetail.Enabled = true;
            btnUpdateDetail.Enabled = true;
            btnDeleteDetail.Enabled = true;
        }

        //Add new order detail
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            OrderDetail _detail = detailBindingSource.Current as OrderDetail;
            _detail.OrderID = _order.OrderID;
            if(ProductBUS.available(_detail.ProductID, _detail.Amount))
            {
                OrderDetailBUS.add(_detail);
                reLoad();
            }
            else
            {
                MessageBox.Show("Out of stock!");
            }
            
        }
      

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            OrderDetailBUS.update(detailBindingSource.Current as OrderDetail);
            reLoad();
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            OrderDetailBUS.delete(detailBindingSource.Current as OrderDetail);
            reLoad();
        }

        private void dgvDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            frmSearchProduct _frmSearch = new frmSearchProduct();
            _frmSearch.ShowDialog();
            productBindingSource.DataSource = _frmSearch.getProduct();
        }

        private void cboProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            (detailBindingSource.Current as OrderDetail).UnitCost = ProductBUS.getByID((int)cboProduct.SelectedValue).UnitPrice;
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detailBindingSource.DataSource = detailTBBindingSource.Current;
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            frmSearchOrder _frmSearch = new frmSearchOrder();
            _frmSearch.ShowDialog();
            orderBindingSource.DataSource = _frmSearch.getOrder();
        }
    }
}
