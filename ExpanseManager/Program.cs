using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
                 NLogBuilder.ConfigureNLog("nlogpro.config");
            Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
 
                //logging.SetMinimumLevel(LogLevel.Trace);
                //logging.AddDebug();
                logging.AddConsole();
            })
            .UseNLog()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            }).Build().Run();
        }

    }
}
