using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkStore.GUI_component
{
    public partial class MovePanel : UserControl
    {
        public MovePanel()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            Form myForm = ((Form)this.TopLevelControl);
            dragCursorPoint = Cursor.Position;
            dragFormPoint = myForm.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Form myForm = ((Form)this.TopLevelControl);
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                myForm.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
