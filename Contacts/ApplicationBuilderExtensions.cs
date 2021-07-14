using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;

namespace Sms.Demo.Contacts
{
        public static class ApplicationBuilderExtensions
        {
            #region Public methods

            /// <summary>
            /// Использовать статические файлы приложения
            /// </summary>
            /// <param name="builder">Строитель приложения</param>
            /// <param name="environmentProvider">Cреда приложения</param>
            /// <returns></returns>
            public static IApplicationBuilder UseAppStaticFiles(
                this IApplicationBuilder builder,
                IHostEnvironment env)
            {
            return builder
               .UseDefaultFiles(new DefaultFilesOptions
               {
                   FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, Path.Join("App", "src"))),
                   RequestPath = String.Empty
               })
               .UseStaticFiles(new StaticFileOptions
               {
                   FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, Path.Join("App", "src"))),
                   RequestPath = String.Empty
               })
               .UseStaticFiles(new StaticFileOptions
               {
                   FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, Path.Join("App", "libs"))),
                   RequestPath = "/libs"
               })
               .UseStaticFiles(new StaticFileOptions
               {
                   FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, Path.Join("App", "assets"))),
                   RequestPath = "/assets"
               });
            }

            #endregion
        }
}
