using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DataLayer.Context;
using Core.Service;
using Core.Service.Interface;


namespace WebSite
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("WebSiteContext")));
           
            services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultUI()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            #region Dependency Injection
            services.AddTransient<IAboutService, AboutService>();
            services.AddTransient<IAboutSliderService, AboutSliderService>();
            services.AddTransient<IBanerSliderService, BanerSliderService>();
            services.AddTransient<IBlogService, BlogService>();
            services.AddTransient<IBlogSectionService, BlogSectionService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IContactSectionService, ContactSectionService>();
            services.AddTransient<IFooterPictureService, FooterPictureService>();
            services.AddTransient<IMenuItemService, MenuItemService>();
            services.AddTransient<IPortfolioService, PortfolioService>();
            services.AddTransient<IPortfolioSectionService, PortfolioSectionService>();
            services.AddTransient<IServiceService, ServiceService>();
            services.AddTransient<IServiceSectionService, ServiceSectionService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<ITeamSectionService, TeamSectionService>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
