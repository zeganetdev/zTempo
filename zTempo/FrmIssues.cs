using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zTempo.Application;
using zTempo.Models;
using zTempo.Helpers;
using ZMessage = zTempo.Helpers.ZMessage;
using MaterialSkin.Controls;
using MaterialSkin;

namespace zTempo
{
    public partial class FrmIssues : MaterialForm
    {
        internal List<Issue> Issues { get; set; } = new List<Issue>();
        internal Project Project  { get; set; }

        private readonly FrmProjects frmProjects;
        private readonly IIssueService issueService;
        private readonly IProjectService projectService;
        public FrmIssues(FrmProjects frmProjects, IIssueService issueService, IProjectService projectService)
        {
            InitializeComponent();
            ApplyTheme();
            this.frmProjects = frmProjects;
            this.issueService = issueService;
            this.projectService = projectService;
        }

        private void ApplyTheme()
        {
            ZThemes.ThemeMultiplicaGreen(this);
        }

        public void InitializeData(Project project)
        {
            cbProjects.Items.Clear();
            cbProjects.SelectedItem = null;
            var projects = projectService.GetProjects();
            if (projects == null) return;
            cbProjects.Items.AddRange(projects.ToArray());
            if (project != null)
            {
                Project = project;
                cbProjects.SelectedIndex = cbProjects.FindString(Project.ToString());
                cbProjects.Refresh();
            }
        }

        private async void btSearch_Click(object sender, EventArgs e)
        {
            Project = (Project)cbProjects.SelectedItem;
            if (Project == null) { ZMessage.Information(this, "Seleccione primero el proyecto"); return; }
            if (string.IsNullOrEmpty(tbFilter.Text)) { ZMessage.Information(this, "Debe ingresar un filtro"); return; }

            using (var zLoading = new ZLoading(this))
            {
                var issues = await issueService.GetIssuesByName(Project.Key, tbFilter.Text);
                lbIssuesResult.Items.Clear();
                lbIssuesResult.SelectedItem = null;
                foreach (var item in issues)
                {
                    lbIssuesResult.Items.Add(new MaterialSkin.MaterialListBoxItem
                    {
                        Text = item.Fields.Summary,
                        SecondaryText = item.Key,
                        Tag = item
                    });
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var selected = lbIssuesResult.SelectedItem;
            if (selected != null)
            {
                if (Issues.Where(x => x.Id.Equals(((Issue)selected.Tag).Id)).FirstOrDefault() == null)
                {
                    ((Issue) selected.Tag).ProjectId = Project.Id;
                    Issues.Add((Issue)selected.Tag);
                    lbIssues.Items.Add(selected);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbIssues.SelectedItem != null)
            {
                var issue = lbIssues.SelectedItem;
                lbIssues.Items.Remove(issue);
                Issues.Remove((Issue)issue.Tag);
            }
        }

        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project = cbProjects.SelectedItem as Project;
            lbIssuesResult.Items.Clear();
            lbIssuesResult.SelectedItem = null;
            lbIssues.Items.Clear();
            lbIssues.SelectedItem = null;
            Issues.Clear();
            if (Project == null) return;
            var issues = issueService.GetIssues(Project.Id);
            issues.ForEach(x => lbIssues.Items.Add(new MaterialSkin.MaterialListBoxItem
            {
                Text = x.Fields.Summary,
                SecondaryText = x.Key,
                Tag = x
            }));
            //lbIssues.Items.AddRange(issues.ToArray());
            Issues.AddRange(issues.ToArray());
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btSearch_Click(sender, new EventArgs());
            }
        }

        private void pbProjects_Click(object sender, EventArgs e)
        {
            if (frmProjects.ShowDialog(this) == DialogResult.OK)
            {
                cbProjects.Items.Clear();
                cbProjects.SelectedItem = null;
                cbProjects.Items.AddRange(frmProjects.Projects.ToArray());
                projectService.Save(frmProjects.Projects);
            }
        }

        private void FrmIssues_Activated(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {

        }
    }
}
