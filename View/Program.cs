using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Api;
using System.Reflection;

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
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Bootstrap();
            //using (var scope = container.BeginLifetimeScope())
            //{
            //    Application.Run(container.Resolve<MainForm>());
            //}
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Api.Helpers.QRLabelGenerator lab = new Api.Helpers.QRLabelGenerator();
            lab.MakeLabel("text.pdf", "xDDD", null);

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
