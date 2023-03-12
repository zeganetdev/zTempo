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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace zTempo
{
    public partial class FrmTempo : MaterialForm
    {
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

        public FrmTempo(FrmConfiguration frmConfiguration,
                        FrmPopup frmPopup,
                        IProjectService projectService,
                        IIssueService issueService,
                        IWorklogService worklogService,
                        IUserService userService)
        {
            InitializeComponent();
            ApplyTheme();

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
            ZThemes.ThemeMultiplicaGreen(this);
            dataGridView1.DefaultCellStyle.SelectionBackColor = ZThemes.COLOR_DARK_PRIMARY;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        #region Tempo

        private void InitializeData()
        {
            cbProjects.Items.Clear();
            cbProjects.SelectedItem = null;
            var projects = projectService.GetProjects();
            if (projects == null)
            {
                return;
            }
            cbProjects.Items.AddRange(projectService.GetProjects().ToArray());
            lbIssues.Items.Clear();
            lbIssues.SelectedItem = null;
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
            if (project == null) { ZMessage.Information(this, "Seleccione una proyecto"); return; };

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

        private async void FrmTempo_Activated(object sender, EventArgs e)
        {
            DrawerShowIconsWhenHidden = true;
            await Task.Delay(1000);
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

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                InitializeData();
            }
            else if (e.TabPageIndex == 1)
            {
                ProjectsInitializeData();
            }
            else if (e.TabPageIndex == 2)
            {
                IssuesInitializeData();
            }
            else if (e.TabPageIndex == 3)
            {
                HistoryInitializeData();
            }
        }

        #endregion

        #region Projects


        private void ProjectsInitializeData()
        {
            var projects = projectService.GetProjects();
            if (projects == null) return;
            lbProjects.Items.Clear();
            projects.ForEach(x => lbProjects.Items.Add(new MaterialListBoxItem
            {
                Text = x.Name,
                SecondaryText = x.Key,
                Tag = x
            }));
        }
        private void btProjectAdd_Click(object sender, EventArgs e)
        {
            var selected = (Project)lbProjectsResult.SelectedItem?.Tag;
            if (selected != null)
            {
                if (lbProjects.Items.Where(x => ((Project)x.Tag).Id.Equals(selected.Id)).FirstOrDefault() == null)
                {
                    lbProjects.Items.Add(new MaterialListBoxItem
                    {
                        Text = selected.Name,
                        SecondaryText = selected.Key,
                        Tag = selected
                    });
                    UpdateProjecs();
                }
                lbProjectsResult.SelectedItem = null;
            }
        }

        private void UpdateProjecs()
        {
            var projects = lbProjects.Items.Select(x =>
            {
                var p = (Project)x.Tag;
                return new Project
                {
                    Id = p.Id,
                    Key = p.Key,
                    Name = p.Name
                };
            }).ToList();
            projectService.Save(projects);
        }

        private void btProjectDelete_Click(object sender, EventArgs e)
        {
            if (lbProjects.SelectedItem != null)
            {
                var project = lbProjects.SelectedItem;
                lbProjects.Items.Remove(project);
                UpdateProjecs();
                lbProjects.SelectedItem = null;
            }
        }
        private async void tbProjectFillter_TrailingIconClick(object sender, EventArgs e)
        {
            using (var zLoading = new ZLoading(this))
            {
                var projects = await projectService.GetProjectsByName(tbProjectFillter.Text);
                lbProjectsResult.Items.Clear();
                foreach (var item in projects)
                {
                    lbProjectsResult.Items.Add(new MaterialListBoxItem
                    {
                        Text = item.Name,
                        SecondaryText = item.Key,
                        Tag = item
                    });
                }
            }
        }
        private void tbProjectFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbProjectFillter_TrailingIconClick(sender, new EventArgs());
            }
        }


        #endregion

        #region Issues

        public void IssuesInitializeData()
        {
            cbIssuesProjects.Items.Clear();
            cbIssuesProjects.SelectedItem = null;
            var projects = projectService.GetProjects();
            if (projects == null) return;
            cbIssuesProjects.Items.AddRange(projects.ToArray());
        }

        private void cbIssuesProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var project = cbIssuesProjects.SelectedItem as Project;
            lbIssuesResult.Items.Clear();
            lbIssuesResult.SelectedItem = null;
            lbIssuesIssues.Items.Clear();
            lbIssuesIssues.SelectedItem = null;
            if (project == null) return;
            var issues = issueService.GetIssues(project.Id);
            issues.ForEach(x => lbIssuesIssues.Items.Add(new MaterialListBoxItem
            {
                Text = x.Fields.Summary,
                SecondaryText = x.Key,
                Tag = x
            }));
        }
        private void tbIssuesFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbIssuesFilter_TrailingIconClick(sender, new EventArgs());
            }
        }

        private async void tbIssuesFilter_TrailingIconClick(object sender, EventArgs e)
        {
            var project = (Project)cbIssuesProjects.SelectedItem;
            if (project == null) { ZMessage.Information(this, "Seleccione primero el proyecto"); return; }
            //if (string.IsNullOrEmpty(tbIssuesFilter.Text)) { ZMessage.Information(this, "Debe ingresar un filtro"); return; }

            using (var zLoading = new ZLoading(this))
            {
                var issues = await issueService.GetIssuesByName(project.Key, tbIssuesFilter.Text);
                lbIssuesResult.Items.Clear();
                lbIssuesResult.SelectedItem = null;
                foreach (var item in issues)
                {
                    item.ProjectId = project.Id;
                    lbIssuesResult.Items.Add(new MaterialListBoxItem
                    {
                        Text = item.Fields.Summary,
                        SecondaryText = item.Key,
                        Tag = item
                    });
                }
            }
        }
        private void btIssuesAdd_Click(object sender, EventArgs e)
        {
            var selected = (Issue)lbIssuesResult.SelectedItem?.Tag;
            if (selected != null)
            {
                if (lbIssuesIssues.Items.Where(x => ((Issue)x.Tag).Id.Equals(selected.Id)).FirstOrDefault() == null)
                {
                    lbIssuesIssues.Items.Add(new MaterialListBoxItem
                    {
                        Text = selected.Fields.Summary,
                        SecondaryText = selected.Key,
                        Tag = selected
                    });
                    UpdateIssues();
                }
                lbIssuesIssues.SelectedItem = null;
            }
        }

        private void UpdateIssues()
        {
            var issues = lbIssuesIssues.Items.Select(x =>
            {
                var p = (Issue)x.Tag;
                return new Issue
                {
                    Id = p.Id,
                    Key = p.Key,
                    ProjectId = p.ProjectId,
                    Fields = new Field
                    {
                        Summary = p.Fields.Summary
                    }
                };
            }).ToList();
            issueService.Save(issues);
        }
        private void btIssuesDelete_Click(object sender, EventArgs e)
        {
            if (lbIssuesIssues.SelectedItem != null)
            {
                var issue = lbIssuesIssues.SelectedItem;
                lbIssuesIssues.Items.Remove(issue);
                issueService.Remove((Issue)issue.Tag);
                lbIssuesIssues.SelectedItem = null;
            }
        }

        #endregion

        #region Histoy
        private void HistoryInitializeData()
        {
            //mcHistoryCalendar.TodayDate = DateTime.Now.AddDays(-1);
            mcHistoryCalendar.TodayDate = DateTime.Now;
            mcHistoryCalendar.SelectionStart = DateTime.Now; // new SelectionRange(DateTime.Now, DateTime.Now);
        }

        private void tbHistoryDate_TrailingIconClick(object sender, EventArgs e)
        {
            mcHistoryCalendar.BringToFront();
            mcHistoryCalendar.Visible = !mcHistoryCalendar.Visible;
        }
        private async void mcHistoryCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            tbHistoryDate.Text = e.Start.ToString("dd/MM/yyyy");
            mcHistoryCalendar.Visible = false;
            dataGridView1.Rows.Clear();

            var projects = projectService.GetProjects();
            var issues = issueService.GetIssues();

            using (var db = new ZLoading(this))
            {
                var history = await worklogService.GetListByDateAsync(userService.GetUser().AccountId, e.Start.ToString("yyyy-MM-dd"));
                history.ForEach(x =>
                {
                    var issue = issues.FirstOrDefault(y => y.Id == x.Issue.Id);
                    var project = projects.FirstOrDefault(y => y.Id == issue?.ProjectId);
                    AddItemHistoryTime($"{project?.Name ?? "-"}", $"[{issue?.Key ?? "-"}] {issue?.Fields?.Summary ?? ""}\n{x.Description}", TimeSpan.FromSeconds(x.TimeSpentSeconds).ToString("hh\\:mm"));
                });
                var totalTime = history?.Sum(x => x.TimeSpentSeconds) ?? 0;
                lbHistoryTotalHours.Text = $"Total horas del día: {TimeSpan.FromSeconds(totalTime).ToString("hh\\:mm")}";
            }

        }


        private void AddItemHistoryTime(string project, string issue, string time)
        {
            object[] rowValues = { project, issue, time };
            dataGridView1.Rows.Add(rowValues);
        }

        #endregion

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //        this.dataGridView1.DefaultCellStyle.WrapMode =
            //DataGridViewTriState.True;
            //        if (e.RowIndex >= 0 && (e.ColumnIndex >= 0 && e.ColumnIndex <= 1))
            //        {
            //            e.PaintBackground(e.CellBounds, true);
            //            string text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //            string[] lines = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            //            Graphics g = e.Graphics;
            //            Brush brush = new SolidBrush(Color.Black);
            //            Font font = dataGridView1.DefaultCellStyle.Font;

            //            SizeF size = g.MeasureString(lines[0], font);
            //            float x = e.CellBounds.Left + 5; // + (e.CellBounds.Width - size.Width) / 2;
            //            float y = e.CellBounds.Top + (e.CellBounds.Height - size.Height * 2) / 2;
            //            g.DrawString(lines[0], font, brush, x, y);
            //            y += size.Height;
            //            size = g.MeasureString(lines[1], font);
            //            x = e.CellBounds.Left + 5; //+ (e.CellBounds.Width - size.Width) / 2;

            //            g.DrawString(lines[1], font, brush, x, y);
            //            brush.Dispose();
            //            e.Handled = false;
            //        }
        }

    }
}