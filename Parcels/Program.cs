using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Parcels.Models;
using System;

public class Program
{
    static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        WebApplication app = builder.Build();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controlller=Home}/{action=Index}/{id?}"
        );

        app.Run();



    }    
}