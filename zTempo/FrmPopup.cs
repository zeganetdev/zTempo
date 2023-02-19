using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zTempo
{
    public partial class FrmPopup : Form
    {
        private int offsetX, offsetY;

        public FrmPopup()
        {
            InitializeComponent();
        }


        private void pbTimeIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentMousePos = Cursor.Position;
                this.Location = new Point(currentMousePos.X - offsetX, currentMousePos.Y - offsetY);
            }
        }

        private void pbTimeIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentMousePos = Cursor.Position;
                offsetX = currentMousePos.X - this.Location.X;
                offsetY = currentMousePos.Y - this.Location.Y;
            }
        }

    }
}
