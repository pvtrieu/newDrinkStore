
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

namespace DrinkStore.Presentation
{
    public partial class frmMain : Form
    {
        static Staff _staff;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(Staff staff)
        {
            InitializeComponent();
            _staff = staff;
        }

        // Load another form to body panel
        private void addForm (Form currForm)
        {
            pnlBody.Controls.Clear();
            currForm.TopLevel = false;
            currForm.AutoScroll = false;
            currForm.Dock = DockStyle.Fill;
            currForm.AutoSize = false;
            this.pnlBody.Controls.Add(currForm);
            currForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmProduct _form = new frmProduct();
            addForm(_form);
            SelectBtn(btnProduct);
        }

        // Form border movable
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }



        //Envent for sidebar button

        //Highlight selected button
        Button preBtn = new Button();                  
        private void SelectBtn (Button currBtn)
        {
            Color notSelectColor = Color.FromArgb(41, 53, 65);
            Color isSelectColor= Color.FromArgb(34, 42, 53);

            preBtn.BackColor = notSelectColor;
            currBtn.BackColor = isSelectColor;
            preBtn = currBtn;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SelectBtn(btnProduct);
            frmProduct _form = new frmProduct();
            addForm(_form);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            SelectBtn(btnOrder);
            frmOrder _form = new frmOrder();
            addForm(_form);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            SelectBtn(btnImport);
            frmImport _form = new frmImport();
            addForm(_form);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            SelectBtn(btnStatistic);
            frmStatistic _form = new frmStatistic();
            addForm(_form);
        }

       
    }
}
