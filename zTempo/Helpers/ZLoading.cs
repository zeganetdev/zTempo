using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTempo.Helpers
{
    internal class ZLoading : IDisposable
    {
        private Form formOverlay;
        public ZLoading(Form parent)
        {
            parent.TopMost = false;
            formOverlay = new Form
            {
                BackColor = Color.Black,
                Opacity = 0.5,
                MinimizeBox = false,
                MaximizeBox = false,
                Text = "",
                ShowIcon = false,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.None,
                Size = new Size(parent.Width, parent.Height),
                ShowInTaskbar = false,
                Owner = parent,
                Visible = true,
                Location = new Point(parent.Location.X, parent.Location.Y),
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
            };

            var pictureBox1 = new PictureBox();
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.loading_black;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            formOverlay.Controls.Add(pictureBox1);
        }

        

        public void Dispose()
        {
            formOverlay.Visible = false;
            formOverlay.Close();
            formOverlay.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
