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
            this.lbIssuesResult = new System.Windows.Forms.ListBox();
            this.btProjectManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIssues = new System.Windows.Forms.ListBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIssuesResult
            // 
            this.lbIssuesResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIssuesResult.FormattingEnabled = true;
            this.lbIssuesResult.HorizontalScrollbar = true;
            this.lbIssuesResult.ItemHeight = 15;
            this.lbIssuesResult.Location = new System.Drawing.Point(12, 115);
            this.lbIssuesResult.Name = "lbIssuesResult";
            this.lbIssuesResult.Size = new System.Drawing.Size(537, 139);
            this.lbIssuesResult.TabIndex = 0;
            // 
            // btProjectManager
            // 
            this.btProjectManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProjectManager.Location = new System.Drawing.Point(424, 8);
            this.btProjectManager.Name = "btProjectManager";
            this.btProjectManager.Size = new System.Drawing.Size(125, 23);
            this.btProjectManager.TabIndex = 6;
            this.btProjectManager.Text = "Gestionar proyectos";
            this.btProjectManager.UseVisualStyleBackColor = true;
            this.btProjectManager.Click += new System.EventHandler(this.btProjectManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de proyectos";
            // 
            // cbProjects
            // 
            this.cbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(12, 37);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(537, 23);
            this.cbProjects.TabIndex = 4;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtrar tareas";
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Location = new System.Drawing.Point(12, 86);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(456, 23);
            this.tbFilter.TabIndex = 8;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(393, 272);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Agregar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Location = new System.Drawing.Point(474, 272);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista de proyectos en marcha";
            // 
            // lbIssues
            // 
            this.lbIssues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIssues.FormattingEnabled = true;
            this.lbIssues.HorizontalScrollbar = true;
            this.lbIssues.ItemHeight = 15;
            this.lbIssues.Location = new System.Drawing.Point(12, 301);
            this.lbIssues.Name = "lbIssues";
            this.lbIssues.Size = new System.Drawing.Size(537, 124);
            this.lbIssues.TabIndex = 9;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(474, 86);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 13;
            this.btSearch.Text = "Buscar";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(474, 438);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 14;
            this.btOk.Text = "Listo";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // FrmIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 473);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbIssues);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btProjectManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProjects);
            this.Controls.Add(this.lbIssuesResult);
            this.Name = "FrmIssues";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmIssues_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbIssuesResult;
        private Button btProjectManager;
        private Label label1;
        private ComboBox cbProjects;
        private Label label2;
        private TextBox tbFilter;
        private Button btAdd;
        private Button btDelete;
        private Label label3;
        private ListBox lbIssues;
        private Button btSearch;
        private Button btOk;
    }
}