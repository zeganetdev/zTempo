using System.Diagnostics.Metrics;
using zTempo.Application;
using zTempo.Helpers;
using zTempo.Models;
using Message = zTempo.Helpers.Message;

namespace zTempo
{
    public partial class FrmTempo : Form
    {
        private readonly FrmProjects frmProjects;
        private readonly FrmIssues frmIssues;
        private readonly FrmConfiguration frmConfiguration;
        private readonly IProjectService projectService;
        private readonly IIssueService issueService;
        private readonly IWorklogService worklogService;
        private bool applicationExit = false;

        private int buzz = 20;

        public FrmTempo(FrmProjects frmProjects, FrmIssues frmIssues, FrmConfiguration frmConfiguration, IProjectService projectService, IIssueService issueService, IWorklogService worklogService)
        {
            InitializeComponent();
            this.frmProjects = frmProjects;
            this.frmIssues = frmIssues;
            this.frmConfiguration = frmConfiguration;
            this.projectService = projectService;
            this.issueService = issueService;
            this.worklogService = worklogService;
            InitializeData();
        }

        private void InitializeData()
        {
            cbProjects.Items.Clear();
            cbProjects.Items.AddRange(projectService.GetProjects().ToArray());
        }

        private void InitializeValueDefault()
        {
            tbTime.Text = DateTime.Now.ToString("HH:mm");
            dpDate.Value = DateTime.Now;
            tbDuration.Text = "01:00";
            chBillable.CheckState = CheckState.Indeterminate;
            //tbDetail.Text = string.Empty;
        }

        private void btProjectManager_Click(object sender, EventArgs e)
        {
            if (frmProjects.ShowDialog(this)== DialogResult.OK)
            {
                cbProjects.Items.Clear();
                cbProjects.Items.AddRange(frmProjects.Projects.ToArray());
                projectService.Save(frmProjects.Projects);
            }
        }

        private void FormTempo_Load(object sender, EventArgs e)
        {
            InitializeValueDefault();
            niTempo.Visible = true;
        }

        private void btTaskManager_Click(object sender, EventArgs e)
        {
            frmIssues.InitializeData((Project)cbProjects.SelectedItem);
            if (frmIssues.ShowDialog(this) == DialogResult.OK)
            {
                lbIssues.Items.Clear();
                lbIssues.Items.AddRange(frmIssues.Issues.ToArray());
                issueService.Save(frmIssues.Issues);
                var index = cbProjects.FindStringExact(frmIssues.Project.ToString());
                if (index == -1) InitializeData();
                cbProjects.SelectedIndex = cbProjects.FindStringExact(frmIssues.Project.ToString());
            }
        }

        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var project = cbProjects.SelectedItem as Project;
            lbIssues.Items.Clear();
            if (project != null) lbIssues.Items.AddRange(issueService.GetIssues(project.Id).ToArray());

        }

        private async void btRegister_Click(object sender, EventArgs e)
        {
            //tiZumdido.Enabled = !tiZumdido.Enabled;
            //if (tiZumdido.Enabled) zumdido = 20;


            var date = dpDate.Value.ToString("yyyy-MM-dd");
            var time = tbTime.Text;
            var duration = TimeOnly.Parse(tbDuration.Text);
            var project = (Project)cbProjects.SelectedItem;
            if (project == null) { Message.Information("Seleccione una projecto"); return; };

            var issue = (Issue)lbIssues.SelectedItem;
            if (issue == null) { Message.Information("Seleccione una tarea"); return; }

            if (chBillable.CheckState == CheckState.Indeterminate) { Message.Information("Debe elegir si la tarea es facturable"); return; }

            var billable = chBillable.Checked ? "Billable" : "NonBillable";
            var timeSpentSeconds = (duration.Hour * 3600) + (duration.Minute * 60);

            await worklogService.SaveAsync(new Worklog
            {
                Attributes = new List<WorklogAttribute> { new WorklogAttribute { Key = "_Billable_", Value = billable } },
                //BillableSeconds = chBillable.Checked ? timeSpentSeconds : 0,
                Description = tbDetail.Text,
                StartDate = date,
                StartTime = $"{time}:00",
                TimeSpentSeconds = timeSpentSeconds,
                IssueId = int.Parse(issue.Id),
                AuthorAccountId = "6126724bd7cac600696d6281"
            });

            Message.Information("Registrado con exito");

            tbDetail.Text = string.Empty;
            chBillable.CheckState = CheckState.Indeterminate;
        }

        private void tiTempo_Tick(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;  
            if (!(dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday))
            {
                if (dateTime.Hour >= 9 && dateTime.Hour <= 18)
                {
                    if (dateTime.Minute == 0)
                    {
                        Show();
                        InitializeValueDefault();
                    }
                }
            }
        }

        private void FormTempo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!applicationExit)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void tsOpen_Click(object sender, EventArgs e)
        {
            Show();
            InitializeValueDefault();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            applicationExit = true;
            System.Windows.Forms.Application.Exit();
        }

        private void tsConfiguration_Click(object sender, EventArgs e)
        {
            if (!frmConfiguration.Created) {
                frmConfiguration.InitializeData();
                frmConfiguration.ShowDialog();
            }
        }

        private void tiZumdido_Tick(object sender, EventArgs e)
        {
            if ((buzz % 2) == 0)
            {
                Left -= buzz;
                Top += buzz;
            }
            else
            {
                Left += buzz;
                Top -= buzz;
            }
            if (buzz == 0) tiZumdido.Enabled = false;
            buzz -= 1;
        }

    }
}