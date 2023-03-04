using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using zTempo.Application;
using zTempo.Helpers;
using zTempo.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using ZMessage = zTempo.Helpers.ZMessage;
using App = System.Windows.Forms.Application;

namespace zTempo
{
    public partial class FrmTempo : MaterialForm
    {
        private readonly FrmProjects frmProjects;
        private readonly FrmIssues frmIssues;
        private readonly FrmConfiguration frmConfiguration;
        private readonly FrmPopup frmPopup;
        private readonly IProjectService projectService;
        private readonly IIssueService issueService;
        private readonly IWorklogService worklogService;
        private readonly IUserService userService;

        public bool ApplicationExit { get; set; } = false;

        private int buzz = 20;

        private const int WM_USER = 0x0400;
        private const int WM_MYMESSAGE = WM_USER + 33;

        public FrmTempo(FrmProjects frmProjects, 
                        FrmIssues frmIssues, 
                        FrmConfiguration frmConfiguration, 
                        FrmPopup frmPopup,
                        IProjectService projectService, 
                        IIssueService issueService, 
                        IWorklogService worklogService, IUserService userService)
        {
            InitializeComponent();
            ApplyTheme();

            this.frmProjects = frmProjects;
            this.frmIssues = frmIssues;
            this.frmConfiguration = frmConfiguration;
            this.frmPopup = frmPopup;
            this.projectService = projectService;
            this.issueService = issueService;
            this.worklogService = worklogService;
            this.userService = userService;
            
            InitializeData();
        }

        private void ApplyTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Green200,
            //                                                  Primary.Green900,
            //                                                  Primary.Green500,
            //                                                  Accent.Blue100,
            //                                                  TextShade.WHITE);
        }

        private void InitializeData()
        {
            cbProjects.Items.Clear();
            cbProjects.SelectedItem = null;
            var projects = projectService.GetProjects();
            if (projects == null) {
                return; 
            }
            cbProjects.Items.AddRange(projectService.GetProjects().ToArray());
        }

        private void InitializeValueDefault()
        {
            tbTime.Text = DateTime.Now.ToString("HH:mm");
            dpDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tbDuration.Text = "01:00";
            chBillable.CheckState = CheckState.Checked;
            //tbDetail.Text = string.Empty;
        }

        private void InitializeBuzz()
        {
            tiZumdido.Tag = Location;
            tiZumdido.Enabled = !tiZumdido.Enabled;
            if (tiZumdido.Enabled)
            {
                buzz = 24;
                tiZumdido.Interval = 30;
            }
        }

        private void btProjectManager_Click(object sender, EventArgs e)
        {

        }

        private void FormTempo_Load(object sender, EventArgs e)
        {
            InitializeValueDefault();
            niTempo.Visible = true;
            frmPopup.FrmTempo = this;
        }


        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var project = cbProjects.SelectedItem as Project;
            lbIssues.Items.Clear();
            lbIssues.SelectedItem = null;
            if (project != null)
                issueService.GetIssues(project.Id).ForEach(x => lbIssues.Items.Add(new MaterialListBoxItem { Text = x.Fields.Summary, SecondaryText = x.Key, Tag = x })); 
            //lbIssues.Items.AddRange(issueService.GetIssues(project.Id).ToArray());

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
                        if (tsConfigurationMeet.Checked) frmPopup.Show(); else Show();
                        InitializeValueDefault();
                        InitializeBuzz();
                    }
                }
            }
        }

        private void FormTempo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ApplicationExit)
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

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MYMESSAGE)
            {
                tsOpen_Click(null, new EventArgs());
            }
            base.WndProc(ref m);
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            ApplicationExit = true;
            System.Windows.Forms.Application.Exit();
        }

        private void tsConfiguration_Click(object sender, EventArgs e)
        {

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
            if (buzz == 0)
            {
                tiZumdido.Enabled = false;
                Location = (Point)tiZumdido.Tag;
            }

            buzz -= 1;
        }

        private void tsConfigurationConnect_Click(object sender, EventArgs e)
        {
            if (!frmConfiguration.Created)
            {
                frmConfiguration.FrmTempo = this;
                frmConfiguration.InitializeData();
                frmConfiguration.ShowDialog();
            }
        }

        private async void btRegister_Click(object sender, EventArgs e)
        {

      
            var date = DateTime.ParseExact(dpDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            var time = tbTime.Text;
            var duration = TimeOnly.Parse(tbDuration.Text);
            var project = (Project)cbProjects.SelectedItem;
            if (project == null) { ZMessage.Information(this, "Seleccione una projecto"); return; };

            var issue = (Issue)lbIssues.SelectedItem?.Tag;
            if (issue == null) { ZMessage.Information(this, "Seleccione una tarea"); return; }

            //if (chBillable.CheckState == CheckState.Indeterminate) { ZMessage.Information(this, "Debe elegir si la tarea es facturable"); return; }

            var billable = chBillable.Checked ? "Billable" : "NonBillable";
            var timeSpentSeconds = (duration.Hour * 3600) + (duration.Minute * 60);

            using (var zLoading = new ZLoading(this))
            {
                //for (int i = 0; i < 20; i++)
                //{
                //    System.Windows.Forms.Application.DoEvents();
                //    Thread.Sleep(50);
                //}
                await worklogService.SaveAsync(new Worklog
                {
                    Attributes = new List<WorklogAttribute> { new WorklogAttribute { Key = "_Billable_", Value = billable } },
                    //BillableSeconds = chBillable.Checked ? timeSpentSeconds : 0,
                    Description = tbDetail.Text,
                    StartDate = date,
                    StartTime = $"{time}:00",
                    TimeSpentSeconds = timeSpentSeconds,
                    IssueId = int.Parse(issue.Id),
                    AuthorAccountId = userService.GetUser().AccountId //Sandy 60e5cd97e7b4fd006a756888 // Edgard 6126724bd7cac600696d6281
                });
            }
            ZMessage.InformationModal(this, "Registrado con exito");

            tbDetail.Text = string.Empty;
            chBillable.CheckState = CheckState.Checked;
            lbIssues.SelectedItem = null;

        }

        private void gestionarProyectosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (frmProjects.ShowDialog(this) == DialogResult.OK)
            {
                cbProjects.Items.Clear();
                cbProjects.SelectedItem = null;
                cbProjects.Items.AddRange(frmProjects.Projects.ToArray());
                projectService.Save(frmProjects.Projects);
            }
        }

        private void gestionarTareasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmIssues.InitializeData((Project)cbProjects.SelectedItem);
            if (frmIssues.ShowDialog(this) == DialogResult.OK)
            {
                lbIssues.Items.Clear();
                lbIssues.SelectedItem = null;
                frmIssues.Issues.ForEach(x => lbIssues.Items.Add(new MaterialListBoxItem { Text = x.Fields.Summary, SecondaryText = x.Key, Tag = x }));
                //lbIssues.Items.Add(frmIssues.Issues.ToArray());
                issueService.Save(frmIssues.Issues);
                InitializeData();
                cbProjects.SelectedIndex = cbProjects.FindStringExact(frmIssues.Project?.ToString());
            }
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            cmOptions.Show(pbMenu, new Point(pbMenu.Width, pbMenu.Height), ToolStripDropDownDirection.Left);

        }

        private void FrmTempo_Activated(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void FrmTempo_Shown(object sender, EventArgs e)
        {
            var configurated = projectService.IsConfigurated();
            if (!configurated)
            {
                Hide();
                tsConfigurationConnect_Click(null, new EventArgs());
                configurated = projectService.IsConfigurated();
                if (configurated)
                {
                    ProcessStartInfo currentStartInfo = new ProcessStartInfo();
                    currentStartInfo.FileName = App.ExecutablePath;
                    ApplicationExit = true;
                    App.Exit();
                    Process.Start(currentStartInfo);
                }
                else
                {
                    ApplicationExit = true;
                    App.Exit();
                }
            }
        }
    }
}