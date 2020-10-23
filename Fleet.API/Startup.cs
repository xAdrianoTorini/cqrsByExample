using Customer.Data.IRepositories;
using Customer.Service.Dxos;
using Customer.Service.Services;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;

namespace Customer.API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddSwaggerGen(s =>
            {
                s.DescribeAllParametersInCamelCase();
            });

            services.AddScoped<IBusMapper, BusMapper>();
            services.AddScoped<IBusRepository, BusRepository>();

            services.AddMediatR(typeof(CreateBusHandler));//Not Scan unecessary things.
            services.AddMediatR(typeof(GetBusHandler));//Not Scan unecessary things.


            services.AddLogging();
            services.AddMemoryCache();

            services.AddMvc();


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Fleet API V1"); });
            app.UseRouting();
            app.UseEndpoints(config =>
            {
                config.MapControllers();
            });
        }
    }
}