/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：                                                    
*│　作    者：yilezhu                                             
*│　版    本：1.0                                                 
*│　创建时间：2018/12/25 10:14:14                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Henxun.Cms.Test                                   
*│　类    名： Common                                      
*└──────────────────────────────────────────────────────────────┘
*/
using Henxun.Cms.Core.CodeGenerator;
using Henxun.Cms.Core.Models;
using Henxun.Cms.Core.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Henxun.Cms.Test
{
    public class Common
    {
        /// <summary>
        /// 构造依赖注入容器，然后传入参数
        /// </summary>
        /// <returns></returns>
        public static IServiceProvider BuildServiceForSqlServer()
        {
            var services = new ServiceCollection();
            services.Configure<CodeGenerateOption>(options =>
            {
                options.ConnectionString = "Data Source=.;Initial Catalog=HenxunCms;User ID=sa;Password=xyz99901." +
                ";Persist Security Info=True;Max Pool Size=50;Min Pool Size=0;Connection Lifetime=300;";
                options.DbType = DataBaseType.SqlServer.ToString();//数据库类型是SqlServer,其他数据类型参照枚举DatabaseType
                options.Author = "yilezhu";//作者名称
                options.OutputPath = "C:\\HenxunCmsCodeGenerator";//模板代码生成的路径
                options.ModelsNamespace = "Henxun.Cms.Models";//实体命名空间
                options.IRepositoryNamespace = "Henxun.Cms.IRepository";//仓储接口命名空间
                options.RepositoryNamespace = "Henxun.Cms.Repository.SqlServer";//仓储命名空间
                options.IServicesNamespace = "Henxun.Cms.IServices";//服务接口命名空间
                options.ServicesNamespace = "Henxun.Cms.Services";//服务命名空间


            });
            //services.Configure<DbOption>("HenxunCms", GetConfiguration().GetSection("DbOpion"));
            //services.AddScoped<IArticleRepository, ArticleRepository>();
            //services.AddScoped<IArticleCategoryRepository, ArticleCategoryRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<CodeGenerator>();
            return services.BuildServiceProvider(); //构建服务提供程序
        }

        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddEnvironmentVariables();
            return builder.Build();
        }
    }
}
