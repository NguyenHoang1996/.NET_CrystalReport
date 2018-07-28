using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private bool dragging = false; // cho biet co dang move hay k
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
