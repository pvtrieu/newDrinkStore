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
using System.IO;

namespace DrinkStore.Presentation
{
    public partial class frmProduct : Form
    {
        
        public frmProduct()
        {
            InitializeComponent();
            productBindingSource.DataSource = new Product();
        }
        
        // Load database to view
        private void initLoad()
        {
            productTBBindingSource.DataSource = ProductBUS.getAll();
            categoryBindingSource.DataSource = CategoryBUS.getAll();
            brandBindingSource.DataSource = BrandBUS.getAll();
            productBindingSource.DataSource = new Product();
            dgvProduct.ClearSelection();
        }

        // Load datbase to view without change in category and brand
        private void onLoad()
        {
            productTBBindingSource.DataSource = ProductBUS.getAll();
            productBindingSource.DataSource = new Product();
            dgvProduct.ClearSelection();
        }


        private void frmProduct_Load(object sender, EventArgs e)
        {
            initLoad();
                      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ProductBUS.add(productBindingSource.Current as Product))
                onLoad();
            else
                MessageBox.Show("Invalid input");
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productBindingSource.DataSource = productTBBindingSource.Current;           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ProductBUS.update(productBindingSource.Current as Product))
                onLoad();
            else
                MessageBox.Show("Cannot Update!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Message", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProductBUS.delete(productBindingSource.Current as Product);
                onLoad();
            };
            
           
        }

        //Pass the error on datagridview combobox
        private void dgvProduct_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //Convert image to byte for saving purpose
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        //convert byte to image for viewing
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        //Open image dialog and save image to database
        private void btnImg_Click(object sender, EventArgs e)
        {
            Product product = productBindingSource.Current as Product;
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                product.Avatar = imageToByteArray(Image.FromFile(dialog.FileName));
                picProImg.Image = byteArrayToImage(product.Avatar);
            }
            productBindingSource.DataSource = product;
        }

        //Open category form
        private void btnAddCate_Click(object sender, EventArgs e)
        {
            frmCategory _frmCate = new frmCategory();
            if (_frmCate.ShowDialog() == DialogResult.Cancel)
            {
                categoryBindingSource.DataSource = CategoryBUS.getAll();
            }
        }

        
        //Open brand form
        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            frmBrand _frmBrand = new frmBrand();
            if (_frmBrand.ShowDialog() == DialogResult.Cancel)
            {
                brandBindingSource.DataSource = BrandBUS.getAll();
            }
        }

      
       

       

        //Reload form if right click
        private void frmProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                onLoad();
        }

        
       
        //Open product search form
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchProduct _frmSearch = new frmSearchProduct();
            _frmSearch.ShowDialog();
            productBindingSource.DataSource = _frmSearch.getProduct();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            frmUnit _frmUnit = new frmUnit();
            if (_frmUnit.ShowDialog() == DialogResult.Cancel)
            {
                unitBindingSource.DataSource = UnitBUS.getAll();
            }
        }

       
    }
}
