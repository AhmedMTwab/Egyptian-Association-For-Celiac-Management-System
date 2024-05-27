using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.EntityFrameworkCore;
using TestCoreApp.Repository;

namespace Egyptian_association_of_cieliac_patients
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var CS = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<EgyptianAssociationOfCieliacPatientsContext>(options =>
            {
                options.UseLazyLoadingProxies().UseSqlServer(CS);
            });
            builder.Services.AddScoped<ICRUDRepo<Patient>,MainRepository<Patient>>();
            builder.Services.AddScoped<ICRUDRepo<AssosiationBranch>,MainRepository<AssosiationBranch>>();
            builder.Services.AddScoped<ICRUDRepo<Dises>, MainRepository<Dises>>();
            builder.Services.AddScoped<ICRUDRepo<Doctor>, MainRepository<Doctor>>();
			builder.Services.AddScoped<ICRUDRepo<Clinic>, MainRepository<Clinic>>();
            builder.Services.AddScoped<ICRUDRepo<HealthInsurance>, MainRepository<HealthInsurance>>();
            builder.Services.AddScoped<ICRUDRepo<Pharmacy>, MainRepository<Pharmacy>>();
            builder.Services.AddScoped<ICRUDRepo<Lab>, MainRepository<Lab>>();
            builder.Services.AddScoped<ICRUDRepo<Hospital>, MainRepository<Hospital>>();
            builder.Services.AddScoped<ICRUDRepo<Product>, MainRepository<Product>>();
            builder.Services.AddScoped<ICRUDRepo<RawMaterial>, MainRepository<RawMaterial>>();


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
