namespace zTempo
{
    partial class FrmIssues
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
            this.cbProjects = new MaterialSkin.Controls.MaterialComboBox();
            this.pbProjects = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btOk = new MaterialSkin.Controls.MaterialButton();
            this.btDelete = new MaterialSkin.Controls.MaterialButton();
            this.btAdd = new MaterialSkin.Controls.MaterialButton();
            this.lbIssues = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbIssuesResult = new MaterialSkin.Controls.MaterialListBox();
            this.tbFilter = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjects)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProjects
            // 
            this.cbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProjects.AutoResize = false;
            this.cbProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbProjects.Depth = 0;
            this.cbProjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProjects.DropDownHeight = 174;
            this.cbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjects.DropDownWidth = 121;
            this.cbProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Hint = "Lista de proyectos";
            this.cbProjects.IntegralHeight = false;
            this.cbProjects.ItemHeight = 43;
            this.cbProjects.Location = new System.Drawing.Point(17, 75);
            this.cbProjects.MaxDropDownItems = 4;
            this.cbProjects.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(640, 49);
            this.cbProjects.StartIndex = 0;
            this.cbProjects.TabIndex = 15;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // pbProjects
            // 
            this.pbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProjects.BackColor = System.Drawing.Color.Transparent;
            this.pbProjects.Image = global::zTempo.Properties.Resources.menu2;
            this.pbProjects.Location = new System.Drawing.Point(615, 86);
            this.pbProjects.Name = "pbProjects";
            this.pbProjects.Size = new System.Drawing.Size(32, 28);
            this.pbProjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProjects.TabIndex = 23;
            this.pbProjects.TabStop = false;
            this.pbProjects.Click += new System.EventHandler(this.pbProjects_Click);
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
            this.materialCard1.Controls.Add(this.lbIssues);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.lbIssuesResult);
            this.materialCard1.Controls.Add(this.tbFilter);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 141);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(640, 570);
            this.materialCard1.TabIndex = 24;
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
            this.btOk.Location = new System.Drawing.Point(558, 517);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btOk.Name = "btOk";
            this.btOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btOk.Size = new System.Drawing.Size(64, 36);
            this.btOk.TabIndex = 29;
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
            this.btDelete.Location = new System.Drawing.Point(533, 315);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDelete.Name = "btDelete";
            this.btDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btDelete.Size = new System.Drawing.Size(88, 36);
            this.btDelete.TabIndex = 28;
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
            this.btAdd.Location = new System.Drawing.Point(437, 315);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdd.Name = "btAdd";
            this.btAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAdd.Size = new System.Drawing.Size(88, 36);
            this.btAdd.TabIndex = 27;
            this.btAdd.Text = "Agregar";
            this.btAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAdd.UseAccentColor = true;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbIssues
            // 
            this.lbIssues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIssues.BackColor = System.Drawing.Color.White;
            this.lbIssues.BorderColor = System.Drawing.Color.LightGray;
            this.lbIssues.Depth = 0;
            this.lbIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbIssues.Location = new System.Drawing.Point(17, 361);
            this.lbIssues.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIssues.Name = "lbIssues";
            this.lbIssues.SelectedIndex = -1;
            this.lbIssues.SelectedItem = null;
            this.lbIssues.Size = new System.Drawing.Size(605, 147);
            this.lbIssues.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbIssues.TabIndex = 26;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 325);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(184, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Lista de tareas en marcha";
            // 
            // lbIssuesResult
            // 
            this.lbIssuesResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIssuesResult.BackColor = System.Drawing.Color.White;
            this.lbIssuesResult.BorderColor = System.Drawing.Color.LightGray;
            this.lbIssuesResult.Depth = 0;
            this.lbIssuesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbIssuesResult.Location = new System.Drawing.Point(17, 71);
            this.lbIssuesResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIssuesResult.Name = "lbIssuesResult";
            this.lbIssuesResult.SelectedIndex = -1;
            this.lbIssuesResult.SelectedItem = null;
            this.lbIssuesResult.Size = new System.Drawing.Size(604, 235);
            this.lbIssuesResult.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbIssuesResult.TabIndex = 24;
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.AnimateReadOnly = false;
            this.tbFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbFilter.Depth = 0;
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFilter.HideSelection = true;
            this.tbFilter.Hint = "Filtrar tareas";
            this.tbFilter.LeadingIcon = null;
            this.tbFilter.Location = new System.Drawing.Point(17, 17);
            this.tbFilter.MaxLength = 32767;
            this.tbFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PasswordChar = '\0';
            this.tbFilter.PrefixSuffixText = null;
            this.tbFilter.ReadOnly = false;
            this.tbFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFilter.SelectedText = "";
            this.tbFilter.SelectionLength = 0;
            this.tbFilter.SelectionStart = 0;
            this.tbFilter.ShortcutsEnabled = true;
            this.tbFilter.Size = new System.Drawing.Size(604, 48);
            this.tbFilter.TabIndex = 23;
            this.tbFilter.TabStop = false;
            this.tbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFilter.TrailingIcon = global::zTempo.Properties.Resources.seach_icon;
            this.tbFilter.UseSystemPasswordChar = false;
            this.tbFilter.TrailingIconClick += new System.EventHandler(this.btSearch_Click);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // FrmIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 728);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.pbProjects);
            this.Controls.Add(this.cbProjects);
            this.Name = "FrmIssues";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmIssues_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pbProjects)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cbProjects;
        private PictureBox pbProjects;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btOk;
        private MaterialSkin.Controls.MaterialButton btDelete;
        private MaterialSkin.Controls.MaterialButton btAdd;
        private MaterialSkin.Controls.MaterialListBox lbIssues;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListBox lbIssuesResult;
        private MaterialSkin.Controls.MaterialTextBox2 tbFilter;
    }
}