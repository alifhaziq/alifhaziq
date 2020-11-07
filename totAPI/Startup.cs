using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using totAPI.Data;
using totAPI.Models;
using totAPI.Models.Dtos;

namespace totAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.CustomeDbContext(Configuration)
                    .CustomeSwagger(Configuration)
                    .CustomeAutoMapper(Configuration);

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/Department/swagger.json", "Department");
                options.RoutePrefix = "";
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }     
    }

    static class ExtensionMethod
    {
        public static IServiceCollection CustomeAutoMapper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(options =>
            {
                options.CreateMap<Department, CreateDepartmentDto>().ReverseMap();
            });

            return services;
        }

        public static IServiceCollection CustomeDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

        public static IServiceCollection CustomeSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("Department", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Department API",
                    Version = "V1",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Email = "mhmmdhrth99@gmail.com",
                        Name = "Muhammad Harith",
                    }
                });
            });

            return services;
        }
    }
}
