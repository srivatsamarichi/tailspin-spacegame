using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TailSpin.SpaceGame.Web
{
    public class Program
    {
        public static string ClientSecret = "80c8627f4a4eb83709f501e8228e86204b9c5b8f";
        public static string Password = "sri@123";
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
