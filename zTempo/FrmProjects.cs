using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FrmProjects : MaterialForm
    {
        internal List<Project> Projects { get; set; } = new List<Project>();

        private readonly IProjectService projectService;

        public FrmProjects(IProjectService projectService)
        {
            InitializeComponent();
            ApplyTheme();
            this.projectService = projectService;
            InitializeData();
        }

        private void ApplyTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void InitializeData()
        {
            Projects = projectService.GetProjects();
            Projects.ForEach(x => lbProjects.Items.Add(new MaterialListBoxItem
            {
                Text = x.Name,
                SecondaryText = x.Key,
                Tag = x
            }));
            //lbProjects.Items.AddRange(Projects.ToArray());
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var selected = (Project)lbProjectsResult.SelectedItem?.Tag;
            if (selected != null)
            {
                if (Projects.Where(x => x.Id.Equals(selected.Id)).FirstOrDefault() == null)
                {
                    Projects.Add(selected);
                    lbProjects.Items.Add(new MaterialListBoxItem
                    {
                        Text = selected.Name,
                        SecondaryText = selected.Key,
                        Tag = selected
                    });
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbProjects.SelectedItem != null)
            {
                var project = lbProjects.SelectedItem;
                lbProjects.Items.Remove(project);
                Projects.Remove((Project)project.Tag);
            }
        }


        private async void tbFillter_TrailingIconClick(object sender, EventArgs e)
        {
            var projects = await projectService.GetProjectsByName(tbFillter.Text);
            lbProjectsResult.Items.Clear();
            foreach (var item in projects)
            {
                lbProjectsResult.Items.Add(new MaterialListBoxItem { 
                    Text = item.Name,
                    SecondaryText = item.Key,
                    Tag = item
                });
            }
        }

        private void tbFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbFillter_TrailingIconClick(sender, new EventArgs());
            }
        }

        private void FrmProjects_Activated(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
