using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sava_Razvan_Cristian_Lab2.Data;
namespace Sava_Razvan_Cristian_Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Sava_Razvan_Cristian_Lab2Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Sava_Razvan_Cristian_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Sava_Razvan_Cristian_Lab2Context' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
