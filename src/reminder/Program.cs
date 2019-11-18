using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booker.Reminder.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Booker.Reminder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddScoped<INotifierClient, NotifierClient>();
                    services.AddScoped<IVisitWatchdog, VisitWatchdog>();

                    services.AddHostedService<TimedHostedService>();
                });
    }
}
