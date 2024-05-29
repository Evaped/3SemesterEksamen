using Microsoft.EntityFrameworkCore;
using Rally.Server.Data;

namespace Rally.Server;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();

        // Configure DbContext
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<SqlDbContext>(options =>
            options.UseSqlServer(connectionString));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();
        app.MapControllers();
        app.MapBlazorHub();
        app.MapFallbackToFile("index.html");

        app.Run();
    }
}