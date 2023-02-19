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
            this.btRegister = new System.Windows.Forms.Button();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btProjectManager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDetail = new System.Windows.Forms.TextBox();
            this.lbIssues = new System.Windows.Forms.ListBox();
            this.btTaskManager = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.MaskedTextBox();
            this.chBillable = new System.Windows.Forms.CheckBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.tbDuration = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tiTempo = new System.Windows.Forms.Timer(this.components);
            this.niTempo = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmTempo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tiZumdido = new System.Windows.Forms.Timer(this.components);
            this.cmTempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRegister
            // 
            this.btRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegister.Location = new System.Drawing.Point(467, 397);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(88, 29);
            this.btRegister.TabIndex = 0;
            this.btRegister.Text = "Registrar";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // cbProjects
            // 
            this.cbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(120, 6);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(396, 23);
            this.cbProjects.TabIndex = 1;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de proyectos";
            // 
            // btProjectManager
            // 
            this.btProjectManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProjectManager.Location = new System.Drawing.Point(522, 6);
            this.btProjectManager.Name = "btProjectManager";
            this.btProjectManager.Size = new System.Drawing.Size(33, 23);
            this.btProjectManager.TabIndex = 3;
            this.btProjectManager.Text = "...";
            this.btProjectManager.UseVisualStyleBackColor = true;
            this.btProjectManager.Click += new System.EventHandler(this.btProjectManager_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de tareas";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Detalle";
            // 
            // tbDetail
            // 
            this.tbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDetail.Location = new System.Drawing.Point(12, 285);
            this.tbDetail.Multiline = true;
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.PlaceholderText = "Ingrese el detalle de la actividad";
            this.tbDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDetail.Size = new System.Drawing.Size(543, 85);
            this.tbDetail.TabIndex = 7;
            // 
            // lbIssues
            // 
            this.lbIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIssues.FormattingEnabled = true;
            this.lbIssues.HorizontalScrollbar = true;
            this.lbIssues.ItemHeight = 15;
            this.lbIssues.Location = new System.Drawing.Point(12, 65);
            this.lbIssues.Name = "lbIssues";
            this.lbIssues.Size = new System.Drawing.Size(543, 184);
            this.lbIssues.TabIndex = 8;
            // 
            // btTaskManager
            // 
            this.btTaskManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTaskManager.Location = new System.Drawing.Point(456, 39);
            this.btTaskManager.Name = "btTaskManager";
            this.btTaskManager.Size = new System.Drawing.Size(99, 23);
            this.btTaskManager.TabIndex = 9;
            this.btTaskManager.Text = "Gestionar tareas";
            this.btTaskManager.UseVisualStyleBackColor = true;
            this.btTaskManager.Click += new System.EventHandler(this.btTaskManager_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha:";
            // 
            // tbTime
            // 
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTime.Location = new System.Drawing.Point(266, 403);
            this.tbTime.Mask = "00:00";
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(62, 23);
            this.tbTime.TabIndex = 14;
            this.tbTime.Text = "0000";
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTime.ValidatingType = typeof(System.DateTime);
            // 
            // chBillable
            // 
            this.chBillable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chBillable.AutoSize = true;
            this.chBillable.Checked = true;
            this.chBillable.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chBillable.Location = new System.Drawing.Point(16, 404);
            this.chBillable.Name = "chBillable";
            this.chBillable.Size = new System.Drawing.Size(86, 19);
            this.chBillable.TabIndex = 15;
            this.chBillable.Text = "Facturable?";
            this.chBillable.UseVisualStyleBackColor = true;
            // 
            // dpDate
            // 
            this.dpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dpDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate.Location = new System.Drawing.Point(155, 403);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(105, 23);
            this.dpDate.TabIndex = 16;
            // 
            // tbDuration
            // 
            this.tbDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDuration.Location = new System.Drawing.Point(360, 403);
            this.tbDuration.Mask = "00:00";
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(62, 23);
            this.tbDuration.TabIndex = 17;
            this.tbDuration.Text = "0000";
            this.tbDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDuration.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Duración:";
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
            this.tsConfiguration.Name = "tsConfiguration";
            this.tsConfiguration.Size = new System.Drawing.Size(150, 22);
            this.tsConfiguration.Text = "Configuración";
            this.tsConfiguration.Click += new System.EventHandler(this.tsConfiguration_Click);
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
            // FormTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.chBillable);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btTaskManager);
            this.Controls.Add(this.lbIssues);
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btProjectManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProjects);
            this.Controls.Add(this.btRegister);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTempo_FormClosing);
            this.Load += new System.EventHandler(this.FormTempo_Load);
            this.cmTempo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btRegister;
        private ComboBox cbProjects;
        private Label label1;
        private Button btProjectManager;
        private Label label2;
        private Label label3;
        private TextBox tbDetail;
        private ListBox lbIssues;
        private Button btTaskManager;
        private Label label4;
        private MaskedTextBox tbTime;
        private CheckBox chBillable;
        private DateTimePicker dpDate;
        private MaskedTextBox tbDuration;
        private Label label5;
        private System.Windows.Forms.Timer tiTempo;
        private NotifyIcon niTempo;
        private ContextMenuStrip cmTempo;
        private ToolStripMenuItem tsOpen;
        private ToolStripSeparator tsSeparator;
        private ToolStripMenuItem tsExit;
        private ToolStripMenuItem tsConfiguration;
        private System.Windows.Forms.Timer tiZumdido;
    }
}