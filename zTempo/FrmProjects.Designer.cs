namespace zTempo
{
    partial class FrmProjects
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btOk = new MaterialSkin.Controls.MaterialButton();
            this.btDelete = new MaterialSkin.Controls.MaterialButton();
            this.btAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbProjects = new MaterialSkin.Controls.MaterialListBox();
            this.lbProjectsResult = new MaterialSkin.Controls.MaterialListBox();
            this.tbFillter = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btOk);
            this.materialCard1.Controls.Add(this.btDelete);
            this.materialCard1.Controls.Add(this.btAdd);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.lbProjects);
            this.materialCard1.Controls.Add(this.lbProjectsResult);
            this.materialCard1.Controls.Add(this.tbFillter);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(575, 596);
            this.materialCard1.TabIndex = 14;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btOk.Depth = 0;
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.HighEmphasis = true;
            this.btOk.Icon = null;
            this.btOk.Location = new System.Drawing.Point(493, 540);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btOk.Name = "btOk";
            this.btOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btOk.Size = new System.Drawing.Size(64, 36);
            this.btOk.TabIndex = 20;
            this.btOk.Text = "Listo";
            this.btOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btOk.UseAccentColor = false;
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btDelete.Depth = 0;
            this.btDelete.HighEmphasis = false;
            this.btDelete.Icon = null;
            this.btDelete.Location = new System.Drawing.Point(467, 271);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDelete.Name = "btDelete";
            this.btDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btDelete.Size = new System.Drawing.Size(88, 36);
            this.btDelete.TabIndex = 19;
            this.btDelete.Text = "Eliminar";
            this.btDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btDelete.UseAccentColor = true;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAdd.Depth = 0;
            this.btAdd.HighEmphasis = true;
            this.btAdd.Icon = null;
            this.btAdd.Location = new System.Drawing.Point(371, 271);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdd.Name = "btAdd";
            this.btAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAdd.Size = new System.Drawing.Size(88, 36);
            this.btAdd.TabIndex = 18;
            this.btAdd.Text = "Agregar";
            this.btAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAdd.UseAccentColor = true;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(21, 281);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(209, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Lista de proyectos en marcha";
            // 
            // lbProjects
            // 
            this.lbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProjects.BackColor = System.Drawing.Color.White;
            this.lbProjects.BorderColor = System.Drawing.Color.LightGray;
            this.lbProjects.Depth = 0;
            this.lbProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbProjects.Location = new System.Drawing.Point(21, 316);
            this.lbProjects.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbProjects.Name = "lbProjects";
            this.lbProjects.SelectedIndex = -1;
            this.lbProjects.SelectedItem = null;
            this.lbProjects.Size = new System.Drawing.Size(534, 213);
            this.lbProjects.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbProjects.TabIndex = 16;
            // 
            // lbProjectsResult
            // 
            this.lbProjectsResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProjectsResult.BackColor = System.Drawing.Color.White;
            this.lbProjectsResult.BorderColor = System.Drawing.Color.LightGray;
            this.lbProjectsResult.Depth = 0;
            this.lbProjectsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbProjectsResult.Location = new System.Drawing.Point(21, 76);
            this.lbProjectsResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbProjectsResult.Name = "lbProjectsResult";
            this.lbProjectsResult.SelectedIndex = -1;
            this.lbProjectsResult.SelectedItem = null;
            this.lbProjectsResult.Size = new System.Drawing.Size(534, 186);
            this.lbProjectsResult.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbProjectsResult.TabIndex = 15;
            // 
            // tbFillter
            // 
            this.tbFillter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFillter.AnimateReadOnly = false;
            this.tbFillter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbFillter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbFillter.Depth = 0;
            this.tbFillter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFillter.HideSelection = true;
            this.tbFillter.Hint = "Filtrar proyectos";
            this.tbFillter.LeadingIcon = null;
            this.tbFillter.Location = new System.Drawing.Point(21, 22);
            this.tbFillter.MaxLength = 32767;
            this.tbFillter.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFillter.Name = "tbFillter";
            this.tbFillter.PasswordChar = '\0';
            this.tbFillter.PrefixSuffixText = null;
            this.tbFillter.ReadOnly = false;
            this.tbFillter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFillter.SelectedText = "";
            this.tbFillter.SelectionLength = 0;
            this.tbFillter.SelectionStart = 0;
            this.tbFillter.ShortcutsEnabled = true;
            this.tbFillter.Size = new System.Drawing.Size(534, 48);
            this.tbFillter.TabIndex = 14;
            this.tbFillter.TabStop = false;
            this.tbFillter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFillter.TrailingIcon = global::zTempo.Properties.Resources.seach_icon;
            this.tbFillter.UseSystemPasswordChar = false;
            this.tbFillter.TrailingIconClick += new System.EventHandler(this.tbFillter_TrailingIconClick);
            this.tbFillter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFillter_KeyPress);
            // 
            // FrmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 691);
            this.Controls.Add(this.materialCard1);
            this.MinimizeBox = false;
            this.Name = "FrmProjects";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmProjects_Activated);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btOk;
        private MaterialSkin.Controls.MaterialButton btDelete;
        private MaterialSkin.Controls.MaterialButton btAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListBox lbProjects;
        private MaterialSkin.Controls.MaterialListBox lbProjectsResult;
        private MaterialSkin.Controls.MaterialTextBox2 tbFillter;
    }
}