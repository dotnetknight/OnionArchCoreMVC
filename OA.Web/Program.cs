using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace OA.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();


        //public class Startup
        //{
        //    public void ConfigureServices(IServiceCollection services)
        //        => services.AddDbContext<ApplicationDbContext>();
        //}

        //public class ApplicationDbContext : DbContext
        //{
        //    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //        : base(options)
        //    {
        //    }
        //}
    }
}
