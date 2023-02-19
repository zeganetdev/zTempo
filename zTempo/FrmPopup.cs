using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zTempo.Helpers;

namespace zTempo
{
    public partial class FrmPopup : PerPixelAlphaForm
    {
        private int offsetX, offsetY;
        public FrmTempo FrmTempo { get; set; }
        public FrmPopup()
        {
            InitializeComponent();
            SelectBitmap(Properties.Resources.tempo_circle, 255);

            SetPosition();
        }

        private void SetPosition()
        {
            var width = Screen.GetBounds(this).Width;
            var height = Screen.GetBounds(this).Height;
            Left = width / 2 + (width / 3);
            Top = height / 2 - (height / 3);
        }


        private void pbTimeIcon_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pbTimeIcon_Click(object sender, EventArgs e)
        {

        }

        private void FrmPopup_Load(object sender, EventArgs e)
        {

        }

        private void FrmPopup_Paint(object sender, PaintEventArgs e)
        {
            SetPosition();
        }

        private void FrmPopup_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentMousePos = Cursor.Position;
                offsetX = currentMousePos.X - this.Location.X;
                offsetY = currentMousePos.Y - this.Location.Y;
            }
        }

        private void FrmPopup_DoubleClick(object sender, EventArgs e)
        {
            Hide();
            FrmTempo.Show();
        }

        private void FrmPopup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentMousePos = Cursor.Position;
                this.Location = new Point(currentMousePos.X - offsetX, currentMousePos.Y - offsetY);
            }
        }

    }
}
