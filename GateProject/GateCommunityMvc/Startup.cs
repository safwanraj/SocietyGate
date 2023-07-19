using GateCommunityMvc.Data;
using GateCommunityMvc.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GateCommunityMvc
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
					options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

			services.AddIdentity<ApplicationUser, IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();


			
			services.Configure<SmtpSettings>(Configuration.GetSection("SmtpSettings"));
			services.AddTransient<IEmailService, EmailService>();
            services.AddSignalR();



            services.AddControllersWithViews();


		
			//services.ConfigureApplicationCookie(options =>
			//{
			//	options.Cookie.HttpOnly = true;
			//	options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
			//	options.LoginPath = "/Account/Login";
			//	options.AccessDeniedPath = "/Account/AccessDenied";
			//	options.SlidingExpiration = true;
			//});


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
			}
			app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "Uploads")),
                RequestPath = "/Uploads"
            });
           

            app.UseRouting();
			app.UseAuthentication();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<VisitorHub>("/visitorHub");
            });
		}
	}
}
