using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkStore.Presentation
{
    public partial class ExpandButton : UserControl
    {
        public ExpandButton()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.expand2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.expand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form myForm = ((Form)this.TopLevelControl);
            if (myForm.WindowState == FormWindowState.Maximized)
                myForm.WindowState = FormWindowState.Normal;
            else
                myForm.WindowState = FormWindowState.Maximized;
        }
    }
}
