using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using DemoAPI_RESTFul_Core_Omar.Contexts;   //** Para utilizar el AppDbContext en los servicios
using Microsoft.EntityFrameworkCore;        //** Instalar desde Manage NuGet Packages: Microsoft.EntityFrameworkCore.SqlServer

namespace DemoAPI_RESTFul_Core_Omar
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

            //** Registrar el Contexto de la base de datos, importando las clases -- Para options.UseSqlServer instalar Microsoft.EntityFrameworkCore.SqlServer
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionStrings")));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
