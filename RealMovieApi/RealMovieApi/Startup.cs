using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MovieStore.Services;
using RealMovieApi.Utils;
using RealMovieContext;
using RealMovieContext.Models;
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
            _= services.AddMemoryCache();
            _ = services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            });
            _ = services.AddControllers();
            _ = services.AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),x=>x.MigrationsAssembly("RealMovieContext")));
            _= services.AddIdentity<ApplicationUser, IdentityRole>()
                  .AddEntityFrameworkStores<ApplicationDbContext>()
                  .AddDefaultTokenProviders();

           _= services.AddScoped<SignInManager<ApplicationUser>>();
           _= services.AddScoped<UserManager<ApplicationUser>>();         
            _ = services.AddScoped<ShowService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            _= app.UseCors("AllowOrigin");

            _ = app.Use(async (context, next) =>
            {
              
                await next.Invoke();
                LogService.InsertHttpLog(context);
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
                _= endpoints.MapControllers();
            });          

        }
    }
}
