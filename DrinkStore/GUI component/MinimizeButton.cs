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
    public partial class MinimizeButton : UserControl
    {
        public MinimizeButton()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.minus2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.minus;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).WindowState = FormWindowState.Minimized;
        }
    }
}
