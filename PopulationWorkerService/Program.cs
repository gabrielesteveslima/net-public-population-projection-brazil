using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PopulationWorkerService
{
    internal static class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();
        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSystemd()
                .ConfigureServices((hostContext, services) => { services.AddHostedService<Worker>(); });
    }
}