using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
using zTempo.Application;
using zTempo.CrossCutting.Agents.JiraProxy;
using zTempo.CrossCutting.Agents.TempoProxy;
using zTempo.CrossCutting.Extensions;
using zTempo.CrossCutting.RestService;
using zTempo.Models;
using zTempo.Persistence.Repositories;
using zTempo.Persistence.SeedWork;
using App = System.Windows.Forms.Application;
using ZMessage = zTempo.Helpers.ZMessage;


namespace zTempo
{
    internal static class Program
    {

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IntPtr hWnd = FindWindow(null, "Tempo");

            if (hWnd != IntPtr.Zero)
            {
                SendMessageW(hWnd, 0x0400 + 33, IntPtr.Zero, IntPtr.Zero);
            }
            else
            {
                ConfigAutoRun();
                NewInstance();
            }

        }

        private static void NewInstance()
        {
            IHost host = Host.CreateDefaultBuilder().ConfigureServices(ConfigureServices).Build();
            App.EnableVisualStyles();
            App.SetCompatibleTextRenderingDefault(false);
            App.SetHighDpiMode(HighDpiMode.SystemAware);

            App.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //FrmPopup mainView = host.Services.GetRequiredService<FrmPopup>();
            FrmTempo mainView = host.Services.GetRequiredService<FrmTempo>();

            App.Run(mainView);
        }

        private static void ConfigAutoRun()
        {
            RegistryKey clave = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            clave.SetValue("zTempo", App.ExecutablePath);

        }

        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddSingleton<FrmPopup>();
            services.AddSingleton<FrmTempo>();
            services.AddSingleton<FrmProjects>();
            services.AddSingleton<FrmIssues>();
            services.AddSingleton<FrmConfiguration>();

            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IIssueRepository, IssueRepository>();
            services.AddTransient<IConfigurationRepository, ConfigurationRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IConfigurationService, ConfigurationService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IIssueService, IssueService>();
            services.AddTransient<IWorklogService, WorklogService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProxyJira, ProxyJira>();
            services.AddTransient<IProxyTempo, ProxyTempo>();
            services.AddTransient<IRestService, RestService>();

            services.AddAutoMapper(typeof(Program));
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ZMessage.Error($"Se ha producido un error: {e.Exception.Message}");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ZMessage.Error($"Se ha producido un error: {(e.ExceptionObject as Exception)?.Message}");
        }
    }
}