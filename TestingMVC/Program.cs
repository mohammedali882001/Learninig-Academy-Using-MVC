using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TestingMVC.Models;
using TestingMVC.Repo;

namespace TestingMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

            /////
            ///
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
                    options=>
                    {
                        options.Password.RequireNonAlphanumeric = false;
                        options.Password.RequiredLength = 4;
                    }
                )
            .AddEntityFrameworkStores<Context>();
    //.AddDefaultTokenProviders();

            ////
            builder.Services.AddDbContext<Context>(optionBiulder =>
            {
                // optionBiulder.UseSqlServer(@"Data Source=.\MSSQLSERVER1;Initial Catalog=MvcCrsTesting;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
                optionBiulder.UseSqlServer(
                        builder.Configuration.GetConnectionString("CS")
                    ); ;
            }
                
                );
            builder.Services.AddScoped<ICourseRepo, CourseRepo>();//register
            builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();//register
            builder.Services.AddScoped<IInstructorRepo, InstructorRepo>();//register


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
