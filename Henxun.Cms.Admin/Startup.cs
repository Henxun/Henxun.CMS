using FluentValidation.AspNetCore;
using Henxun.Cms.Admin.Filter;
using Henxun.Cms.Admin.Validations;
using Henxun.Cms.Core.Options;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using Henxun.Cms.Quartz;
using Autofac;
using Henxun.Cms.Repository.SqlServer;
using Microsoft.Extensions.Logging;
using Henxun.Cms.Services;
using System.IO;

namespace Henxun.Cms.Admin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ManagerRoleRepository).Assembly)
                           .Where(t => t.Name.EndsWith("Repository"))
                           .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(ManagerRoleService).Assembly)
                 .Where(t => t.Name.EndsWith("Service"))
                 .AsImplementedInterfaces();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<DbOption>("HenxunCms", Configuration.GetSection("DbOpion"));


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddCors(option =>
            {
                option.AddPolicy("111", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyHeader();
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                });
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
           .AddCookie(options =>
           {
               options.LoginPath = "/Account/Index";
               options.LogoutPath = "/Account/Logout";
               options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
           });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(15);
                options.Cookie.HttpOnly = true;
            });
            services.AddAntiforgery(options =>
            {
                // Set Cookie properties using CookieBuilder properties†.
                options.FormFieldName = "AntiforgeryKey_yilezhu";
                options.HeaderName = "X-CSRF-TOKEN-yilezhu";
                options.SuppressXFrameOptionsHeader = false;
            });
            services.AddMvc(option =>
            {
                option.Filters.Add(new GlobalExceptionFilter());
                option.EnableEndpointRouting = false;
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
            .AddControllersAsServices()
            .AddFluentValidation(fv =>
            {
                //程序集方式引入
                fv.RegisterValidatorsFromAssemblyContaining<ManagerRoleValidation>();
                //去掉其他的验证，只使用FluentValidation的验证规则
                fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
            }); 
            //DI了AutoMapper中需要用到的服务，其中包括AutoMapper的配置类 Profile
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSingleton<ScheduleCenter>();
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "HenxunCms", Version = "v1" });
            });

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseRouting();

            app.UseCors("111");

            app.UseAuthorization();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Account}/{action=Index}/{id?}");
            });

            app.UseSwagger();

            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("v1/swagger.json", "HenxunCmsApi");
            });

        }
    }
}
