namespace WebApp
{
    using System;
    using System.IO;
    using Microsoft.AspNetCore.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "WebApp";
            
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseUrls("http://localhost:8888")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
