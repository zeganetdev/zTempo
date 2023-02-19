using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            using (Mutex mutex = new Mutex(true, "z.zTempo", out createdNew))
            {
                if (createdNew)
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
            }
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

            services.AddTransient<IConfigurationService, ConfigurationService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IIssueService, IssueService>();
            services.AddTransient<IWorklogService, WorklogService>();
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