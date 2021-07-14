using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Sms.Demo.Contacts
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
            var contactFileInfo = new FileInfo(
                Path.Combine(
                    AppContext.BaseDirectory, 
                    Configuration.GetSection(nameof(Contact))["FilePath"]));

            services
                .AddTransient<IContactRepository>(provider => new JsonContactRepository(contactFileInfo))
                .AddTransient<IContactService, ContactService>()

                .AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAppStaticFiles(env)
               .UseRouting()
               .UseEndpoints(endpoints =>
               {
                   endpoints.MapControllerRoute(
                       name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");
               });
        }
    }
}
