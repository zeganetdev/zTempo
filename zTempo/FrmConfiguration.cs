using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using zTempo.Application;
using zTempo.CrossCutting.Utilities;
using MaterialSkin.Controls;
using MaterialSkin;
using zTempo.Helpers;
using App = System.Windows.Forms.Application;

namespace zTempo
{
    public partial class FrmConfiguration : MaterialForm
    {
        const string urlLocal = "http://localhost:3693";

        private readonly IConfigurationService configurationService;
        private readonly IUserService userService;

        public FrmTempo FrmTempo { get; set; }

        public FrmConfiguration(IConfigurationService configurationService, IUserService userService)
        {
            InitializeComponent();
            ApplyTheme();
            this.configurationService = configurationService;
            this.userService = userService;
        }

        private void ApplyTheme()
        {
            ZThemes.ThemeMultiplicaGreen(this);
        }

        public void InitializeData()
        {
            var configurations = configurationService.GetConfigurations();
            tbTokenTempo.Text = configurations.FirstOrDefault(x => x.Field.Equals(Constants.TEMPO_TOKEN))?.Value;

            tbTokenJira.Text = configurations.FirstOrDefault(x => x.Field.Equals(Constants.JIRA_TOKEN))?.Value;
            tbEmail.Text = configurations.FirstOrDefault(x => x.Field.Equals(Constants.JIRA_EMAIL))?.Value;
        }

        private void lnkCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(urlLocal);
        }

        private void lnkConfigurationTempo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", $"{lnkConfigurationTempo.Text}");
        }

        private void btConnectTempo_Click(object sender, EventArgs e)
        {
            //var url = $"https://multiplica.atlassian.net/plugins/servlet/ac/io.tempo.jira/oauth-authorize/?client_id={tbClientId.Text}&redirect_uri={HttpUtility.UrlEncode(urlLocal)}";
            //Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            configurationService.Save(new Models.Configuration { Field = Constants.TEMPO_TOKEN, Value = tbTokenTempo.Text });
        }

        //public void InitializeServer()
        //{
        //    private HttpListener server;

        //    Thread thread = new Thread(() =>
        //    {
        //        server = new HttpListener();
        //        server.Prefixes.Add("http://localhost:3693/");
        //        server.Start();
        //        try
        //        {
        //            while (true)
        //            {
        //                HttpListenerContext context = server.GetContext();
        //                HttpListenerRequest request = context.Request;
        //                HttpListenerResponse response = context.Response;

        //                if (request.Url.LocalPath.Equals("/"))
        //                {
        //                    var code = request.QueryString["code"];
        //                    string responseString = "";

        //                    if (string.IsNullOrEmpty(code)) responseString = "No es posible conectar, no se puedo extraer el codigo de autenticacion";
        //                    else responseString = "Conectado!!!";

        //                    UpdateStatusTempo(responseString, code);

        //                    byte[] buffer = Encoding.UTF8.GetBytes(responseString);
        //                    response.ContentLength64 = buffer.Length;
        //                    Stream output = response.OutputStream;
        //                    output.Write(buffer, 0, buffer.Length);
        //                    output.Close();
        //                }
        //            }
        //        }
        //        catch { }

        //    });
        //    thread.Start();
        //}

        //private void UpdateStatusTempo(string message, string code)
        //{
        //    if (lbStatusTempo.InvokeRequired)
        //    {
        //        lbStatusTempo.Invoke((MethodInvoker)delegate {
        //            lbStatusTempo.Text = message;
        //        });
        //    }
        //    else
        //    {
        //        lbStatusTempo.Text = message;
        //    }

        //    if (!string.IsNullOrEmpty(code))
        //    {
        //        configurationService.Save(new Models.Configuration { Field = Constants.TEMPO_CLIENT_ID, Value = tbClientId.Text });
        //        configurationService.Save(new Models.Configuration { Field = Constants.TEMPO_TOKEN, Value = code });
        //    }
        //}

        private void btConnetJira_Click(object sender, EventArgs e)
        {
            configurationService.Save(new Models.Configuration { Field = Constants.JIRA_EMAIL, Value = tbEmail.Text });
            configurationService.Save(new Models.Configuration { Field = Constants.JIRA_TOKEN, Value = tbTokenJira.Text });
            materialExpansionPanel2.Collapse = false;
        }

        private void lnkConfigurationJira_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", $"{lnkConfigurationJira.Text}");
            
        }

        private async void btTest_Click(object sender, EventArgs e)
        {
            userService.ConfigurateJira();
            var user = await userService.GetUserAsync();
            ZMessage.Information(this, $"Esta conectado a: {user.DisplayName}", 5000);
            userService.Save(user);
        }

        public void btRestart_Click(object sender, EventArgs e)
        {
            ProcessStartInfo currentStartInfo = new ProcessStartInfo();
            currentStartInfo.FileName = App.ExecutablePath;
            FrmTempo.ApplicationExit = true;
            App.Exit();
            Process.Start(currentStartInfo);
        }
    }
}
