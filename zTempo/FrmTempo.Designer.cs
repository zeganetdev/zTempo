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
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem4 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem5 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem6 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem7 = new MaterialSkin.MaterialListBoxItem();
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
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btProjectDelete = new MaterialSkin.Controls.MaterialButton();
            this.btProjectAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbProjects = new MaterialSkin.Controls.MaterialListBox();
            this.lbProjectsResult = new MaterialSkin.Controls.MaterialListBox();
            this.tbProjectFillter = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btIssuesDelete = new MaterialSkin.Controls.MaterialButton();
            this.btIssuesAdd = new MaterialSkin.Controls.MaterialButton();
            this.lbIssuesIssues = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbIssuesResult = new MaterialSkin.Controls.MaterialListBox();
            this.tbIssuesFilter = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbIssuesProjects = new MaterialSkin.Controls.MaterialComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmTempo.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard3.SuspendLayout();
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
            this.tiZumdido.Interval = 10;
            this.tiZumdido.Tick += new System.EventHandler(this.tiZumdido_Tick);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 63);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(657, 598);
            this.materialTabControl1.TabIndex = 39;
            this.materialTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.materialTabControl1_Selected);
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
            this.tabPage1.ImageKey = "ico_time.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(649, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar hora";
            // 
            // btRegister
            // 
            this.btRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRegister.BackgroundImage = global::zTempo.Properties.Resources.tempo_circle;
            this.btRegister.Depth = 0;
            this.btRegister.Icon = global::zTempo.Properties.Resources.tempo;
            this.btRegister.Image = global::zTempo.Properties.Resources.tempo_circle;
            this.btRegister.Location = new System.Drawing.Point(573, 494);
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
            this.tbDuration.Location = new System.Drawing.Point(200, 496);
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
            this.tbDuration.UseAccent = false;
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
            this.tbTime.Location = new System.Drawing.Point(125, 496);
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
            this.tbTime.UseAccent = false;
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
            this.dpDate.Location = new System.Drawing.Point(10, 496);
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
            this.dpDate.UseAccent = false;
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
            this.materialCard1.Size = new System.Drawing.Size(629, 413);
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
            materialListBoxItem1.SecondaryText = "dfgd";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "ListBoxItem";
            materialListBoxItem2.SecondaryText = "dfg";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "ListBoxItem";
            materialListBoxItem3.SecondaryText = "fdgdfgfdg";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "ListBoxItem";
            materialListBoxItem4.SecondaryText = "dfgdfg";
            materialListBoxItem4.Tag = null;
            materialListBoxItem4.Text = "ListBoxItem";
            materialListBoxItem5.SecondaryText = "dfgdfg";
            materialListBoxItem5.Tag = null;
            materialListBoxItem5.Text = "ListBoxItem";
            materialListBoxItem6.SecondaryText = "dfgdfg";
            materialListBoxItem6.Tag = null;
            materialListBoxItem6.Text = "ListBoxItem";
            materialListBoxItem7.SecondaryText = "sdf";
            materialListBoxItem7.Tag = null;
            materialListBoxItem7.Text = "ListBoxItem2";
            this.lbIssues.Items.Add(materialListBoxItem1);
            this.lbIssues.Items.Add(materialListBoxItem2);
            this.lbIssues.Items.Add(materialListBoxItem3);
            this.lbIssues.Items.Add(materialListBoxItem4);
            this.lbIssues.Items.Add(materialListBoxItem5);
            this.lbIssues.Items.Add(materialListBoxItem6);
            this.lbIssues.Items.Add(materialListBoxItem7);
            this.lbIssues.Location = new System.Drawing.Point(18, 17);
            this.lbIssues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbIssues.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIssues.Name = "lbIssues";
            this.lbIssues.SelectedIndex = -1;
            this.lbIssues.SelectedItem = null;
            this.lbIssues.Size = new System.Drawing.Size(595, 262);
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
            this.tbDetail.Location = new System.Drawing.Point(18, 285);
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
            this.tbDetail.Size = new System.Drawing.Size(595, 111);
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
            this.chBillable.Location = new System.Drawing.Point(313, 502);
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
            this.cbProjects.Size = new System.Drawing.Size(629, 49);
            this.cbProjects.StartIndex = 0;
            this.cbProjects.TabIndex = 37;
            this.cbProjects.UseAccent = false;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.ImageKey = "ico_project.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(649, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proyectos";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btProjectDelete);
            this.materialCard2.Controls.Add(this.btProjectAdd);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.lbProjects);
            this.materialCard2.Controls.Add(this.lbProjectsResult);
            this.materialCard2.Controls.Add(this.tbProjectFillter);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(10, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(634, 546);
            this.materialCard2.TabIndex = 0;
            // 
            // btProjectDelete
            // 
            this.btProjectDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btProjectDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btProjectDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btProjectDelete.Depth = 0;
            this.btProjectDelete.HighEmphasis = false;
            this.btProjectDelete.Icon = null;
            this.btProjectDelete.Location = new System.Drawing.Point(529, 265);
            this.btProjectDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btProjectDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btProjectDelete.Name = "btProjectDelete";
            this.btProjectDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btProjectDelete.Size = new System.Drawing.Size(88, 36);
            this.btProjectDelete.TabIndex = 25;
            this.btProjectDelete.Text = "Eliminar";
            this.btProjectDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btProjectDelete.UseAccentColor = true;
            this.btProjectDelete.UseVisualStyleBackColor = true;
            this.btProjectDelete.Click += new System.EventHandler(this.btProjectDelete_Click);
            // 
            // btProjectAdd
            // 
            this.btProjectAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btProjectAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btProjectAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btProjectAdd.Depth = 0;
            this.btProjectAdd.HighEmphasis = true;
            this.btProjectAdd.Icon = null;
            this.btProjectAdd.Location = new System.Drawing.Point(433, 265);
            this.btProjectAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btProjectAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btProjectAdd.Name = "btProjectAdd";
            this.btProjectAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btProjectAdd.Size = new System.Drawing.Size(88, 36);
            this.btProjectAdd.TabIndex = 24;
            this.btProjectAdd.Text = "Agregar";
            this.btProjectAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btProjectAdd.UseAccentColor = true;
            this.btProjectAdd.UseVisualStyleBackColor = true;
            this.btProjectAdd.Click += new System.EventHandler(this.btProjectAdd_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 275);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(209, 19);
            this.materialLabel1.TabIndex = 23;
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
            this.lbProjects.Location = new System.Drawing.Point(17, 310);
            this.lbProjects.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbProjects.Name = "lbProjects";
            this.lbProjects.SelectedIndex = -1;
            this.lbProjects.SelectedItem = null;
            this.lbProjects.Size = new System.Drawing.Size(600, 219);
            this.lbProjects.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbProjects.TabIndex = 22;
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
            this.lbProjectsResult.Location = new System.Drawing.Point(17, 69);
            this.lbProjectsResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbProjectsResult.Name = "lbProjectsResult";
            this.lbProjectsResult.SelectedIndex = -1;
            this.lbProjectsResult.SelectedItem = null;
            this.lbProjectsResult.Size = new System.Drawing.Size(600, 187);
            this.lbProjectsResult.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbProjectsResult.TabIndex = 21;
            // 
            // tbProjectFillter
            // 
            this.tbProjectFillter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProjectFillter.AnimateReadOnly = false;
            this.tbProjectFillter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbProjectFillter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbProjectFillter.Depth = 0;
            this.tbProjectFillter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbProjectFillter.HideSelection = true;
            this.tbProjectFillter.Hint = "Filtrar proyectos";
            this.tbProjectFillter.LeadingIcon = null;
            this.tbProjectFillter.Location = new System.Drawing.Point(17, 15);
            this.tbProjectFillter.MaxLength = 32767;
            this.tbProjectFillter.MouseState = MaterialSkin.MouseState.OUT;
            this.tbProjectFillter.Name = "tbProjectFillter";
            this.tbProjectFillter.PasswordChar = '\0';
            this.tbProjectFillter.PrefixSuffixText = null;
            this.tbProjectFillter.ReadOnly = false;
            this.tbProjectFillter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbProjectFillter.SelectedText = "";
            this.tbProjectFillter.SelectionLength = 0;
            this.tbProjectFillter.SelectionStart = 0;
            this.tbProjectFillter.ShortcutsEnabled = true;
            this.tbProjectFillter.Size = new System.Drawing.Size(600, 48);
            this.tbProjectFillter.TabIndex = 20;
            this.tbProjectFillter.TabStop = false;
            this.tbProjectFillter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbProjectFillter.TrailingIcon = global::zTempo.Properties.Resources.seach_icon;
            this.tbProjectFillter.UseAccent = false;
            this.tbProjectFillter.UseSystemPasswordChar = false;
            this.tbProjectFillter.TrailingIconClick += new System.EventHandler(this.tbProjectFillter_TrailingIconClick);
            this.tbProjectFillter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProjectFillter_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialCard3);
            this.tabPage3.ImageKey = "ico_issue.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(649, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tareas";
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btIssuesDelete);
            this.materialCard3.Controls.Add(this.btIssuesAdd);
            this.materialCard3.Controls.Add(this.lbIssuesIssues);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.lbIssuesResult);
            this.materialCard3.Controls.Add(this.tbIssuesFilter);
            this.materialCard3.Controls.Add(this.cbIssuesProjects);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(10, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(634, 546);
            this.materialCard3.TabIndex = 0;
            // 
            // btIssuesDelete
            // 
            this.btIssuesDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIssuesDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btIssuesDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btIssuesDelete.Depth = 0;
            this.btIssuesDelete.HighEmphasis = false;
            this.btIssuesDelete.Icon = null;
            this.btIssuesDelete.Location = new System.Drawing.Point(528, 308);
            this.btIssuesDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btIssuesDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btIssuesDelete.Name = "btIssuesDelete";
            this.btIssuesDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btIssuesDelete.Size = new System.Drawing.Size(88, 36);
            this.btIssuesDelete.TabIndex = 34;
            this.btIssuesDelete.Text = "Eliminar";
            this.btIssuesDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btIssuesDelete.UseAccentColor = true;
            this.btIssuesDelete.UseVisualStyleBackColor = true;
            this.btIssuesDelete.Click += new System.EventHandler(this.btIssuesDelete_Click);
            // 
            // btIssuesAdd
            // 
            this.btIssuesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIssuesAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btIssuesAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btIssuesAdd.Depth = 0;
            this.btIssuesAdd.HighEmphasis = true;
            this.btIssuesAdd.Icon = null;
            this.btIssuesAdd.Location = new System.Drawing.Point(426, 308);
            this.btIssuesAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btIssuesAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btIssuesAdd.Name = "btIssuesAdd";
            this.btIssuesAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btIssuesAdd.Size = new System.Drawing.Size(88, 36);
            this.btIssuesAdd.TabIndex = 33;
            this.btIssuesAdd.Text = "Agregar";
            this.btIssuesAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btIssuesAdd.UseAccentColor = true;
            this.btIssuesAdd.UseVisualStyleBackColor = true;
            this.btIssuesAdd.Click += new System.EventHandler(this.btIssuesAdd_Click);
            // 
            // lbIssuesIssues
            // 
            this.lbIssuesIssues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIssuesIssues.BackColor = System.Drawing.Color.White;
            this.lbIssuesIssues.BorderColor = System.Drawing.Color.LightGray;
            this.lbIssuesIssues.Depth = 0;
            this.lbIssuesIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbIssuesIssues.Location = new System.Drawing.Point(17, 353);
            this.lbIssuesIssues.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIssuesIssues.Name = "lbIssuesIssues";
            this.lbIssuesIssues.SelectedIndex = -1;
            this.lbIssuesIssues.SelectedItem = null;
            this.lbIssuesIssues.Size = new System.Drawing.Size(600, 176);
            this.lbIssuesIssues.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbIssuesIssues.TabIndex = 32;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 317);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(184, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Lista de tareas en marcha";
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
            this.lbIssuesResult.Location = new System.Drawing.Point(17, 130);
            this.lbIssuesResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIssuesResult.Name = "lbIssuesResult";
            this.lbIssuesResult.SelectedIndex = -1;
            this.lbIssuesResult.SelectedItem = null;
            this.lbIssuesResult.Size = new System.Drawing.Size(600, 168);
            this.lbIssuesResult.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.lbIssuesResult.TabIndex = 30;
            // 
            // tbIssuesFilter
            // 
            this.tbIssuesFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIssuesFilter.AnimateReadOnly = false;
            this.tbIssuesFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbIssuesFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbIssuesFilter.Depth = 0;
            this.tbIssuesFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbIssuesFilter.HideSelection = true;
            this.tbIssuesFilter.Hint = "Filtrar tareas";
            this.tbIssuesFilter.LeadingIcon = null;
            this.tbIssuesFilter.Location = new System.Drawing.Point(17, 76);
            this.tbIssuesFilter.MaxLength = 32767;
            this.tbIssuesFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.tbIssuesFilter.Name = "tbIssuesFilter";
            this.tbIssuesFilter.PasswordChar = '\0';
            this.tbIssuesFilter.PrefixSuffixText = null;
            this.tbIssuesFilter.ReadOnly = false;
            this.tbIssuesFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIssuesFilter.SelectedText = "";
            this.tbIssuesFilter.SelectionLength = 0;
            this.tbIssuesFilter.SelectionStart = 0;
            this.tbIssuesFilter.ShortcutsEnabled = true;
            this.tbIssuesFilter.Size = new System.Drawing.Size(600, 48);
            this.tbIssuesFilter.TabIndex = 29;
            this.tbIssuesFilter.TabStop = false;
            this.tbIssuesFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbIssuesFilter.TrailingIcon = global::zTempo.Properties.Resources.seach_icon;
            this.tbIssuesFilter.UseAccent = false;
            this.tbIssuesFilter.UseSystemPasswordChar = false;
            this.tbIssuesFilter.TrailingIconClick += new System.EventHandler(this.tbIssuesFilter_TrailingIconClick);
            this.tbIssuesFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIssuesFilter_KeyPress);
            // 
            // cbIssuesProjects
            // 
            this.cbIssuesProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIssuesProjects.AutoResize = false;
            this.cbIssuesProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbIssuesProjects.Depth = 0;
            this.cbIssuesProjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbIssuesProjects.DropDownHeight = 174;
            this.cbIssuesProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIssuesProjects.DropDownWidth = 121;
            this.cbIssuesProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbIssuesProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIssuesProjects.FormattingEnabled = true;
            this.cbIssuesProjects.Hint = "Lista de proyectos";
            this.cbIssuesProjects.IntegralHeight = false;
            this.cbIssuesProjects.ItemHeight = 43;
            this.cbIssuesProjects.Location = new System.Drawing.Point(17, 17);
            this.cbIssuesProjects.MaxDropDownItems = 4;
            this.cbIssuesProjects.MouseState = MaterialSkin.MouseState.OUT;
            this.cbIssuesProjects.Name = "cbIssuesProjects";
            this.cbIssuesProjects.Size = new System.Drawing.Size(600, 49);
            this.cbIssuesProjects.StartIndex = 0;
            this.cbIssuesProjects.TabIndex = 25;
            this.cbIssuesProjects.UseAccent = false;
            this.cbIssuesProjects.SelectedIndexChanged += new System.EventHandler(this.cbIssuesProjects_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ico_project.png");
            this.imageList1.Images.SetKeyName(1, "ico_time.png");
            this.imageList1.Images.SetKeyName(2, "ico_issue.png");
            // 
            // FrmTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 664);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "FrmTempo";
            this.Padding = new System.Windows.Forms.Padding(0, 63, 4, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo";
            this.Activated += new System.EventHandler(this.FrmTempo_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTempo_FormClosing);
            this.Load += new System.EventHandler(this.FormTempo_Load);
            this.Shown += new System.EventHandler(this.FrmTempo_Shown);
            this.cmTempo.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
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
        private MaterialCard materialCard2;
        private MaterialButton btProjectDelete;
        private MaterialButton btProjectAdd;
        private MaterialLabel materialLabel1;
        private MaterialListBox lbProjects;
        private MaterialListBox lbProjectsResult;
        private MaterialTextBox2 tbProjectFillter;
        private TabPage tabPage3;
        private MaterialCard materialCard3;
        private MaterialComboBox cbIssuesProjects;
        private MaterialButton btIssuesDelete;
        private MaterialButton btIssuesAdd;
        private MaterialListBox lbIssuesIssues;
        private MaterialLabel materialLabel2;
        private MaterialListBox lbIssuesResult;
        private MaterialTextBox2 tbIssuesFilter;
        private ImageList imageList1;
    }
}