using Microsoft.AspNetCore.Mvc.ViewFeatures;
using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfMvcCore
{
    public static class Section1
    {
        public static void Run()
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
            
            // Register IRazorViewRenderer here
            builder.Services.AddSingleton<IRazorViewRenderer, RazorViewRenderer>();
            
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