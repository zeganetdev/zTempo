namespace zTempo
{
    partial class FrmPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbTimeIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTimeIcon
            // 
            this.pbTimeIcon.Image = global::zTempo.Properties.Resources.timeGreen3;
            this.pbTimeIcon.Location = new System.Drawing.Point(23, 24);
            this.pbTimeIcon.Name = "pbTimeIcon";
            this.pbTimeIcon.Size = new System.Drawing.Size(76, 67);
            this.pbTimeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTimeIcon.TabIndex = 0;
            this.pbTimeIcon.TabStop = false;
            this.pbTimeIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbTimeIcon_MouseDown);
            this.pbTimeIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbTimeIcon_MouseMove);
            // 
            // FrmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(125, 115);
            this.ControlBox = false;
            this.Controls.Add(this.pbTimeIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmPopup";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbTimeIcon;
    }
}