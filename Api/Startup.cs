using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Data.Context;
using Autofac;
using System.Reflection;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public IContainer ConfigureAndBuild()
        {
            var builder = new ContainerBuilder();

            ConfigureServices(builder);

            return builder.Build();
        }

        public void ConfigureServices(ContainerBuilder builder)
        {
            builder.Register(c => {
                var opt = new DbContextOptionsBuilder<AppDbContext>();
                //opt.UseMySql(_configuration.GetConnectionString("MySQL"));

                return new AppDbContext(opt.Options, Configuration);
            }).AsSelf();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Api)))
                .Where(t => t.Namespace.Contains("Managers"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name.Equals("I" + t.Name)));

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Api)))
                .Where(t => t.Namespace.Contains("Services"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name.Equals("I" + t.Name)));

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Api)))
                .Where(t => t.Namespace.Contains("Controllers"))
                .AsSelf();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Api)))
                .Where(t => t.Namespace.Contains("Helpers"))
                .AsSelf();
        }
    }
}
