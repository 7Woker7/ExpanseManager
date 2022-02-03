using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ExpanseManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
//NLogBuilder.ConfigureNLog("nlogpro.config");
//           Host.CreateDefaultBuilder(args)
//            .ConfigureLogging(logging =>
//            {
//                logging.ClearProviders();

//                //logging.SetMinimumLevel(LogLevel.Trace);
//                //logging.AddDebug();
//               logging.AddConsole();
//          })
//            .UseNLog();
