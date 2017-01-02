using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using SocialNetwork.Data.Infrastructure;
using SocialNetwork.Security.Contracts.Entities;
using SocialNetwork.Security.Infrastructure;
using System;

namespace SocialNetwork.Infrastructure
{
    public class Startup
    {
        public Startup(IHostingEnvironment environment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration
        {
            get;
            private set;
        }

        public IContainer ApplicationContainer
        {
            get;
            private set;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IConfigurationRoot>(Configuration);

            services
                .AddEntityFramework()
                .AddDbContext<SocialNetworkDatabaseContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:SocialNetworkConnection"]))
                .AddDbContext<SecurityDatabaseContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:SecurityConnection"]));

            services
                .AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<SecurityDatabaseContext>();

            services
                .AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());

            services
                .AddAutofac(container => ApplicationContainer = container);

            return ApplicationContainer.Resolve<IServiceProvider>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IApplicationLifetime appLifetime)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseIdentity();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            appLifetime.ApplicationStopped.Register(() => ApplicationContainer.Dispose());
        }
    }
}
