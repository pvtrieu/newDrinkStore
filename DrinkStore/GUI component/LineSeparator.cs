﻿using System.Drawing;
using System.Windows.Forms;

namespace DrinkStore.Presentation
{
    public partial class LineSeparator : UserControl
    {
        public LineSeparator()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(LineSeparator_Paint);
            this.MaximumSize = new Size(2000, 2);
            this.MinimumSize = new Size(0, 2);
            this.Width = 350;
        }
        private void LineSeparator_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.DarkGray, new Point(0, 0), new Point(this.Width, 0));
            g.DrawLine(Pens.DarkGray, new Point(0, 1), new Point(this.Width, 1));
        }
    }
}
