using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CurrencyExchangeNet5MVC.Utilities;
using IO.Swagger.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CurrencyExchangeNet5MVC
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
            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
            services.AddScoped<ICurrencyApi, CurrencyApi>();
            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            
            RequestLocalizationOptions requestLocalizationOptions = new RequestLocalizationOptions();
            var supportedCultures = new CultureInfo[] {
                  new CultureInfo("en"),
                  new CultureInfo("es"),
                  new CultureInfo("ur"),
                  new CultureInfo("fr"),
                  new CultureInfo("ar"),
                  new CultureInfo("pt"),
                  new CultureInfo("tr")

              }.ToList();

            requestLocalizationOptions.SupportedCultures = requestLocalizationOptions.SupportedUICultures = supportedCultures;


            requestLocalizationOptions.SetDefaultCulture("en");
            requestLocalizationOptions.RequestCultureProviders.Insert(0, new RouteValueRequestCultureProvider() { Options = requestLocalizationOptions });

            app.UseRequestLocalization(requestLocalizationOptions);

            //var supportedCultures = new[] { "en", "es", "fr", "ur", "ar", "pt" };
            //var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
            //    .AddSupportedCultures(supportedCultures)
            //    .AddSupportedUICultures(supportedCultures);

            //app.UseRequestLocalization(localizationOptions);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{culture=en}/{controller=Home}/{action=Index}/{id?}",
                    defaults: new {culture= "en", controller = "Home", action = "Index" });
                    
            });
        }
    }
}
