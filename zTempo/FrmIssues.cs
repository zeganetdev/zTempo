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
using Message = zTempo.Helpers.Message;

namespace zTempo
{
    public partial class FrmIssues : Form
    {
        internal List<Issue> Issues { get; set; } = new List<Issue>();
        internal Project Project  { get; set; }

        private readonly FrmProjects frmProjects;
        private readonly IIssueService issueService;
        private readonly IProjectService projectService;
        public FrmIssues(FrmProjects frmProjects, IIssueService issueService, IProjectService projectService)
        {
            InitializeComponent();
            this.frmProjects = frmProjects;
            this.issueService = issueService;
            this.projectService = projectService;
        }
        public void InitializeData(Project project)
        {
            cbProjects.Items.Clear();
            var projects = projectService.GetProjects();
            cbProjects.Items.AddRange(projects.ToArray());
            if (project != null)
            {
                Project = project;
                cbProjects.SelectedIndex = cbProjects.FindString(Project.ToString());
                cbProjects.Refresh();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btProjectManager_Click(object sender, EventArgs e)
        {
            if (frmProjects.ShowDialog(this) == DialogResult.OK)
            {
                cbProjects.Items.Clear();
                cbProjects.Items.AddRange(frmProjects.Projects.ToArray());
                projectService.Save(frmProjects.Projects);
            }
        }

        private async void btSearch_Click(object sender, EventArgs e)
        {
            Project = (Project)cbProjects.SelectedItem;
            if (Project == null) { Message.Information("Seleccione primero el proyecto"); return; }
            if (string.IsNullOrEmpty(tbFilter.Text)) { Message.Information("Debe ingresar un filtro"); return; }


            var issues = await issueService.GetIssuesByName(Project.Key, tbFilter.Text);
            lbIssuesResult.Items.Clear();
            foreach (var item in issues)
            {
                lbIssuesResult.Items.Add(item);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var selected = (Issue)lbIssuesResult.SelectedItem;
            if (lbIssuesResult.SelectedItem != null)
            {
                if (Issues.Where(x => x.Id.Equals(selected.Id)).FirstOrDefault() == null)
                {
                    selected.ProjectId = Project.Id;
                    Issues.Add(selected);
                    lbIssues.Items.Add(selected);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbIssues.SelectedItem != null)
            {
                var issue = (Issue)lbIssues.SelectedItem;
                lbIssues.Items.Remove(issue);
                Issues.Remove(issue);
            }
        }

        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project = cbProjects.SelectedItem as Project;
            lbIssuesResult.Items.Clear();
            lbIssues.Items.Clear();
            Issues.Clear();
            if (Project == null) return;
            var issues = issueService.GetIssues(Project.Id);
            lbIssues.Items.AddRange(issues.ToArray());
            Issues.AddRange(issues.ToArray());
        }

        private void FrmIssues_Activated(object sender, EventArgs e)
        {
            

        }
    }
}
