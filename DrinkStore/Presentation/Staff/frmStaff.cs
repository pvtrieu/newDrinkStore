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
    public partial class frmStaff : Form
    {
        
        public frmStaff()
        {
            InitializeComponent();
            staffBindingSource.DataSource = new Staff();
        }
        
        // Load database to view
        private void initLoad()
        {
            staffTBBindingSource.DataSource = StaffBUS.getAll();
            genderBindingSource.DataSource = GenderBUS.getAll();
            positionBindingSource.DataSource = PositionBUS.getAll();
            staffBindingSource.DataSource = new Staff();
            dgvStaff.ClearSelection();
        }

        // Load datbase to view without change in category and brand
        private void onLoad()
        {
            staffTBBindingSource.DataSource = StaffBUS.getAll();
            staffBindingSource.DataSource = new Staff();
            txtConfirm.Text = "";
            dgvStaff.ClearSelection();
        }


        private void frmStaff_Load(object sender, EventArgs e)
        {
            initLoad();
                      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Confirm password is not the same as password");
                return;
            }
            if (StaffBUS.add(staffBindingSource.Current as Staff))
                onLoad();
            else
                MessageBox.Show("Invalid input");
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            staffBindingSource.DataSource = staffTBBindingSource.Current;           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Confirm password is not the same as password");
                return;
            }
            if (StaffBUS.update(staffBindingSource.Current as Staff))
                onLoad();
            else
                MessageBox.Show("Cannot Update, invalid input!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Message", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StaffBUS.delete(staffBindingSource.Current as Staff);
                onLoad();
            };
            
           
        }

        //Pass the error on datagridview combobox
        private void dgvStaff_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
            Staff _staff = staffBindingSource.Current as Staff;
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _staff.Avatar = imageToByteArray(Image.FromFile(dialog.FileName));
                picProImg.Image = byteArrayToImage(_staff.Avatar);
            }
            staffBindingSource.DataSource = _staff;
        }

        

      
       

       

        //Reload form if right click
        private void frmStaff_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                onLoad();
        }

        
       
        //Open staff search form
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchStaff _frmSearch = new frmSearchStaff();
            _frmSearch.ShowDialog();
            staffBindingSource.DataSource = _frmSearch.getStaff();
        }

       

       
    }
}
