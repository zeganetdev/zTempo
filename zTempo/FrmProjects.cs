using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zTempo.Application;
using zTempo.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace zTempo
{
    public partial class FrmProjects : Form
    {
        internal List<Project> Projects { get; set; } = new List<Project>();

        private readonly IProjectService projectService;

        public FrmProjects(IProjectService projectService)
        {
            InitializeComponent();
            this.projectService = projectService;
            InitializeData();


        }

        private void InitializeData()
        {
            Projects = projectService.GetProjects();
            lbProjects.Items.AddRange(Projects.ToArray());
        }


        private async void btSearch_Click(object sender, EventArgs e)
        {
            var projects = await projectService.GetProjectsByName(tbFillter.Text);
            lbProjectsResult.Items.Clear();
            foreach (var item in projects)
            {
                lbProjectsResult.Items.Add(item);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var selected = (Project)lbProjectsResult.SelectedItem;
            if (lbProjectsResult.SelectedItem != null)
            {
                if (Projects.Where(x => x.Id.Equals(selected.Id)).FirstOrDefault() == null)
                {
                    Projects.Add(selected);
                    lbProjects.Items.Add(selected);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbProjects.SelectedItem != null)
            {
                var project = (Project)lbProjects.SelectedItem;
                lbProjects.Items.Remove(project);
                Projects.Remove(project);
            }
        }
    }
}
