using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RealMovieApi.Utils;
using RealMovieContext;
using Serilog;

namespace RealMovieApi
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
            _ = services.AddControllers();
            _ = services.AddDbContext<IdentityContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),x=>x.MigrationsAssembly("RealMovieContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            _= app.Use(async (context, next) =>
            {
                //TODO:serilog
                LogService.InsertLog(context.Request.Method,"",context.Request.Path);
                 await next.Invoke();
            });

            if (env.IsDevelopment())
            {
                _ = app.UseDeveloperExceptionPage();
            }

            _=app.UseHttpsRedirection();
            _=app.UseRouting();
            _=app.UseAuthorization();
            _ = app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });          

        }
    }
}
