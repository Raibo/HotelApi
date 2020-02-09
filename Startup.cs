using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyTravelTest.Dependencies;
using HappyTravelTest.Dependencies.Repositories;
using HappyTravelTest.Models;
using HappyTravelTest.Services;
using HappyTravelTest.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HappyTravelTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<INetstormingClient, NetstormingClient>();
            services.AddScoped<INetstormingRepository, NetstormingRepository>();
            services.AddScoped<INetstormingService, NetstormingService>();
            services.Configure<NetstormingClientSettings>(Configuration.GetSection("NetstormingClientSettings"));
            services.AddDbContext<netstormingContext>(options => options.UseNpgsql(Configuration.GetConnectionString("NetstormingDatabase")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
