using MaterialSkin.Controls;

namespace zTempo
{
    partial class FrmTempo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTempo));
            this.tiTempo = new System.Windows.Forms.Timer(this.components);
            this.niTempo = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmTempo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConfigurationConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConfigurationMeet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tiZumdido = new System.Windows.Forms.Timer(this.components);
            this.cmOptions = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.gestionarProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer2 = new MaterialSkin.Controls.MaterialDrawer();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btRegister = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.tbDuration = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.tbTime = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dpDate = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbIssues = new MaterialSkin.Controls.MaterialListBox();
            this.tbDetail = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.chBillable = new MaterialSkin.Controls.MaterialSwitch();
            this.cbProjects = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmTempo.SuspendLayout();
            this.cmOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tiTempo
            // 
            this.tiTempo.Enabled = true;
            this.tiTempo.Interval = 50000;
            this.tiTempo.Tick += new System.EventHandler(this.tiTempo_Tick);
            // 
            // niTempo
            // 
            this.niTempo.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niTempo.BalloonTipTitle = "zTempo";
            this.niTempo.ContextMenuStrip = this.cmTempo;
            this.niTempo.Icon = ((System.Drawing.Icon)(resources.GetObject("niTempo.Icon")));
            this.niTempo.Text = "Tempo";
            this.niTempo.Visible = true;
            // 
            // cmTempo
            // 
            this.cmTempo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpen,
            this.tsConfiguration,
            this.tsSeparator,
            this.tsExit});
            this.cmTempo.Name = "cmTempo";
            this.cmTempo.Size = new System.Drawing.Size(151, 76);
            // 
            // tsOpen
            // 
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(150, 22);
            this.tsOpen.Text = "Abrir";
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // tsConfiguration
            // 
            this.tsConfiguration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConfigurationConnect,
            this.tsConfigurationMeet});
            this.tsConfiguration.Name = "tsConfiguration";
            this.tsConfiguration.Size = new System.Drawing.Size(150, 22);
            this.tsConfiguration.Text = "Configuración";
            this.tsConfiguration.Click += new System.EventHandler(this.tsConfiguration_Click);
            // 
            // tsConfigurationConnect
            // 
            this.tsConfigurationConnect.Name = "tsConfigurationConnect";
            this.tsConfigurationConnect.Size = new System.Drawing.Size(153, 22);
            this.tsConfigurationConnect.Text = "Conexión";
            this.tsConfigurationConnect.Click += new System.EventHandler(this.tsConfigurationConnect_Click);
            // 
            // tsConfigurationMeet
            // 
            this.tsConfigurationMeet.CheckOnClick = true;
            this.tsConfigurationMeet.Name = "tsConfigurationMeet";
            this.tsConfigurationMeet.Size = new System.Drawing.Size(153, 22);
            this.tsConfigurationMeet.Text = "Modo Reunión";
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(147, 6);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(150, 22);
            this.tsExit.Text = "Salir";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tiZumdido
            // 
            this.tiZumdido.Interval = 20;
            this.tiZumdido.Tick += new System.EventHandler(this.tiZumdido_Tick);
            // 
            // cmOptions
            // 
            this.cmOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmOptions.Depth = 0;
            this.cmOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProyectosToolStripMenuItem,
            this.gestionarTareasToolStripMenuItem});
            this.cmOptions.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.cmOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmOptions.Name = "cmOptions";
            this.cmOptions.Size = new System.Drawing.Size(145, 68);
            // 
            // gestionarProyectosToolStripMenuItem
            // 
            this.gestionarProyectosToolStripMenuItem.Name = "gestionarProyectosToolStripMenuItem";
            this.gestionarProyectosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6);
            this.gestionarProyectosToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.gestionarProyectosToolStripMenuItem.Text = "Proyectos";
            this.gestionarProyectosToolStripMenuItem.Click += new System.EventHandler(this.gestionarProyectosToolStripMenuItem_Click_1);
            // 
            // gestionarTareasToolStripMenuItem
            // 
            this.gestionarTareasToolStripMenuItem.Name = "gestionarTareasToolStripMenuItem";
            this.gestionarTareasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6);
            this.gestionarTareasToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.gestionarTareasToolStripMenuItem.Text = "Tareas";
            this.gestionarTareasToolStripMenuItem.Click += new System.EventHandler(this.gestionarTareasToolStripMenuItem_Click_1);
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 91);
            this.materialDrawer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 29;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // materialDrawer2
            // 
            this.materialDrawer2.AutoHide = false;
            this.materialDrawer2.AutoShow = false;
            this.materialDrawer2.BackgroundWithAccent = false;
            this.materialDrawer2.BaseTabControl = null;
            this.materialDrawer2.Depth = 0;
            this.materialDrawer2.HighlightWithAccent = true;
            this.materialDrawer2.IndicatorWidth = 0;
            this.materialDrawer2.IsOpen = false;
            this.materialDrawer2.Location = new System.Drawing.Point(-250, 195);
            this.materialDrawer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialDrawer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer2.Name = "materialDrawer2";
            this.materialDrawer2.ShowIconsWhenHidden = false;
            this.materialDrawer2.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer2.TabIndex = 33;
            this.materialDrawer2.Text = "materialDrawer2";
            this.materialDrawer2.UseColors = false;
            // 
            // pbMenu
            // 
            this.pbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbMenu.Image = global::zTempo.Properties.Resources.menu;
            this.pbMenu.Location = new System.Drawing.Point(567, 30);
            this.pbMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(29, 27);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 38;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 63);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(600, 641);
            this.materialTabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btRegister);
            this.tabPage1.Controls.Add(this.tbDuration);
            this.tabPage1.Controls.Add(this.tbTime);
            this.tabPage1.Controls.Add(this.dpDate);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.chBillable);
            this.tabPage1.Controls.Add(this.cbProjects);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(592, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btRegister
            // 
            this.btRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRegister.BackgroundImage = global::zTempo.Properties.Resources.tempo_circle;
            this.btRegister.Depth = 0;
            this.btRegister.Icon = global::zTempo.Properties.Resources.tempo;
            this.btRegister.Image = global::zTempo.Properties.Resources.tempo_circle;
            this.btRegister.Location = new System.Drawing.Point(518, 537);
            this.btRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(62, 62);
            this.btRegister.TabIndex = 39;
            this.btRegister.Text = "A";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // tbDuration
            // 
            this.tbDuration.AllowPromptAsInput = true;
            this.tbDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDuration.AnimateReadOnly = false;
            this.tbDuration.AsciiOnly = false;
            this.tbDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDuration.BeepOnError = false;
            this.tbDuration.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbDuration.Depth = 0;
            this.tbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDuration.HidePromptOnLeave = false;
            this.tbDuration.HideSelection = true;
            this.tbDuration.Hint = "Tiempo";
            this.tbDuration.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tbDuration.LeadingIcon = null;
            this.tbDuration.Location = new System.Drawing.Point(200, 539);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDuration.Mask = "##:##";
            this.tbDuration.MaxLength = 32767;
            this.tbDuration.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.PasswordChar = '\0';
            this.tbDuration.PrefixSuffixText = null;
            this.tbDuration.PromptChar = '_';
            this.tbDuration.ReadOnly = false;
            this.tbDuration.RejectInputOnFirstFailure = false;
            this.tbDuration.ResetOnPrompt = true;
            this.tbDuration.ResetOnSpace = true;
            this.tbDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDuration.SelectedText = "";
            this.tbDuration.SelectionLength = 0;
            this.tbDuration.SelectionStart = 0;
            this.tbDuration.ShortcutsEnabled = true;
            this.tbDuration.Size = new System.Drawing.Size(80, 48);
            this.tbDuration.SkipLiterals = true;
            this.tbDuration.TabIndex = 43;
            this.tbDuration.TabStop = false;
            this.tbDuration.Text = "  :";
            this.tbDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDuration.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbDuration.TrailingIcon = null;
            this.tbDuration.UseSystemPasswordChar = false;
            this.tbDuration.ValidatingType = null;
            // 
            // tbTime
            // 
            this.tbTime.AllowPromptAsInput = true;
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTime.AnimateReadOnly = false;
            this.tbTime.AsciiOnly = false;
            this.tbTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbTime.BeepOnError = false;
            this.tbTime.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbTime.Depth = 0;
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTime.HidePromptOnLeave = false;
            this.tbTime.HideSelection = true;
            this.tbTime.Hint = "Hora";
            this.tbTime.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tbTime.LeadingIcon = null;
            this.tbTime.Location = new System.Drawing.Point(125, 539);
            this.tbTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTime.Mask = "##:##";
            this.tbTime.MaxLength = 32767;
            this.tbTime.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTime.Name = "tbTime";
            this.tbTime.PasswordChar = '\0';
            this.tbTime.PrefixSuffixText = null;
            this.tbTime.PromptChar = '_';
            this.tbTime.ReadOnly = false;
            this.tbTime.RejectInputOnFirstFailure = false;
            this.tbTime.ResetOnPrompt = true;
            this.tbTime.ResetOnSpace = true;
            this.tbTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTime.SelectedText = "";
            this.tbTime.SelectionLength = 0;
            this.tbTime.SelectionStart = 0;
            this.tbTime.ShortcutsEnabled = true;
            this.tbTime.Size = new System.Drawing.Size(75, 48);
            this.tbTime.SkipLiterals = true;
            this.tbTime.TabIndex = 42;
            this.tbTime.TabStop = false;
            this.tbTime.Text = "  :";
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTime.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbTime.TrailingIcon = null;
            this.tbTime.UseSystemPasswordChar = false;
            this.tbTime.ValidatingType = null;
            // 
            // dpDate
            // 
            this.dpDate.AllowPromptAsInput = true;
            this.dpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dpDate.AnimateReadOnly = false;
            this.dpDate.AsciiOnly = false;
            this.dpDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dpDate.BeepOnError = false;
            this.dpDate.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dpDate.Depth = 0;
            this.dpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dpDate.HidePromptOnLeave = false;
            this.dpDate.HideSelection = true;
            this.dpDate.Hint = "Fecha";
            this.dpDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.dpDate.LeadingIcon = null;
            this.dpDate.Location = new System.Drawing.Point(10, 539);
            this.dpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dpDate.Mask = "##/##/####";
            this.dpDate.MaxLength = 32767;
            this.dpDate.MouseState = MaterialSkin.MouseState.OUT;
            this.dpDate.Name = "dpDate";
            this.dpDate.PasswordChar = '\0';
            this.dpDate.PrefixSuffixText = null;
            this.dpDate.PromptChar = '_';
            this.dpDate.ReadOnly = false;
            this.dpDate.RejectInputOnFirstFailure = false;
            this.dpDate.ResetOnPrompt = true;
            this.dpDate.ResetOnSpace = true;
            this.dpDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpDate.SelectedText = "";
            this.dpDate.SelectionLength = 0;
            this.dpDate.SelectionStart = 0;
            this.dpDate.ShortcutsEnabled = true;
            this.dpDate.Size = new System.Drawing.Size(115, 48);
            this.dpDate.SkipLiterals = true;
            this.dpDate.TabIndex = 41;
            this.dpDate.TabStop = false;
            this.dpDate.Text = "  /  /";
            this.dpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dpDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dpDate.TrailingIcon = null;
            this.dpDate.UseSystemPasswordChar = false;
            this.dpDate.ValidatingType = null;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbIssues);
            this.materialCard1.Controls.Add(this.tbDetail);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 63);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(574, 456);
            this.materialCard1.TabIndex = 40;
            // 
            // lbIssues
            // 
            this.lbIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIssues.BackColor = System.Drawing.Color.White;
            this.lbIssues.BorderColor = System.Drawing.Color.LightGray;
            this.lbIssues.Depth = 0;
            this.lbIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbIssues.Location = new System.Drawing.Point(18, 17);
            this.lbIssues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbIssues.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIssues.Name = "lbIssues";
            this.lbIssues.SelectedIndex = -1;
            this.lbIssues.SelectedItem = null;
            this.lbIssues.Size = new System.Drawing.Size(540, 305);
            this.lbIssues.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbIssues.TabIndex = 21;
            // 
            // tbDetail
            // 
            this.tbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDetail.AnimateReadOnly = true;
            this.tbDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDetail.Depth = 0;
            this.tbDetail.HideSelection = true;
            this.tbDetail.Hint = "Detalle de la tarea";
            this.tbDetail.Location = new System.Drawing.Point(18, 328);
            this.tbDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDetail.MaxLength = 32767;
            this.tbDetail.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.PasswordChar = '\0';
            this.tbDetail.ReadOnly = false;
            this.tbDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDetail.SelectedText = "";
            this.tbDetail.SelectionLength = 0;
            this.tbDetail.SelectionStart = 0;
            this.tbDetail.ShortcutsEnabled = true;
            this.tbDetail.Size = new System.Drawing.Size(540, 111);
            this.tbDetail.TabIndex = 25;
            this.tbDetail.TabStop = false;
            this.tbDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDetail.UseSystemPasswordChar = false;
            // 
            // chBillable
            // 
            this.chBillable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chBillable.AutoSize = true;
            this.chBillable.Depth = 0;
            this.chBillable.Location = new System.Drawing.Point(313, 545);
            this.chBillable.Margin = new System.Windows.Forms.Padding(0);
            this.chBillable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chBillable.MouseState = MaterialSkin.MouseState.HOVER;
            this.chBillable.Name = "chBillable";
            this.chBillable.Ripple = true;
            this.chBillable.Size = new System.Drawing.Size(133, 37);
            this.chBillable.TabIndex = 39;
            this.chBillable.Text = "Facturable";
            this.chBillable.UseVisualStyleBackColor = true;
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
            this.cbProjects.Location = new System.Drawing.Point(10, 6);
            this.cbProjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbProjects.MaxDropDownItems = 4;
            this.cbProjects.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(574, 49);
            this.cbProjects.StartIndex = 0;
            this.cbProjects.TabIndex = 37;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(592, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 707);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.materialDrawer2);
            this.Controls.Add(this.materialDrawer1);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmTempo";
            this.Padding = new System.Windows.Forms.Padding(0, 63, 4, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmTempo_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTempo_FormClosing);
            this.Load += new System.EventHandler(this.FormTempo_Load);
            this.cmTempo.ResumeLayout(false);
            this.cmOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tiTempo;
        private NotifyIcon niTempo;
        private ContextMenuStrip cmTempo;
        private ToolStripMenuItem tsOpen;
        private ToolStripSeparator tsSeparator;
        private ToolStripMenuItem tsExit;
        private ToolStripMenuItem tsConfiguration;
        private System.Windows.Forms.Timer tiZumdido;
        private ToolStripMenuItem tsConfigurationConnect;
        private ToolStripMenuItem tsConfigurationMeet;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer2;
        private MaterialContextMenuStrip cmOptions;
        private ToolStripMenuItem gestionarProyectosToolStripMenuItem;
        private ToolStripMenuItem gestionarTareasToolStripMenuItem;
        private PictureBox pbMenu;
        private MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialMaskedTextBox tbDuration;
        private MaterialMaskedTextBox tbTime;
        private MaterialMaskedTextBox dpDate;
        private MaterialCard materialCard1;
        private MaterialMultiLineTextBox2 tbDetail;
        private MaterialListBox lbIssues;
        private MaterialSwitch chBillable;
        private MaterialComboBox cbProjects;
        private MaterialFloatingActionButton btRegister;
    }
}