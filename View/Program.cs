using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Api;
using System.Reflection;
using System.Text;

using Model.Models;

namespace View
{
    static class Program
    {
        private static IContainer container;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //That is important shit for QR Label generator - please, don't remove
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            using (var scope = container.BeginLifetimeScope())
            {
                Application.Run(container.Resolve<MainForm>());
            }
        }

        private static void Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(View)))
                .Where(t => t.Name.EndsWith("Form"))
                .AsSelf();

            var apiStartup = new Startup();
            apiStartup.ConfigureServices(builder);

            container = builder.Build();
        }
    }
}
