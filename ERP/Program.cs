using DbController.MySql;
using ERP.Core.Services;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Reflection;

namespace ERP
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor()
                .AddCircuitOptions(options =>
                {
                    options.DetailedErrors = true;
                });

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, configureOptions =>
                {
                });

            builder.Services.AddScoped<DbProviderService>();
            builder.Services.AddScoped<PermissionService>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<ArticleService>();
            builder.Services.AddScoped<WarehouseService>();
            builder.Services.AddScoped<SectionService>();
            builder.Services.AddScoped<RowService>();
            builder.Services.AddScoped<RackService>();
            builder.Services.AddScoped<CompartmentService>();
            builder.Configuration.AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json"), false, true);

#if DEBUG

            builder.Configuration.AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.development.json"), true, true);
#endif

#if DEBUGKLEIN
            builder.Configuration.AddJsonFile(Path.Combine("D:\\", "formularportal.klein.json"), false, true);
#endif


            // FluentValidation
            builder.Services.AddValidatorsFromAssembly(Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ERP.Core.Validators.dll")));
            var app = builder.Build();
            using var serviceScope = app.Services.CreateScope();

            var services = serviceScope.ServiceProvider;
            var dbProviderService = services.GetRequiredService<DbProviderService>()!;

            await AppdatenService.InitAsync(builder.Configuration, dbProviderService);

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }

        public static string GetVersion()
        {
            return Assembly.GetEntryAssembly()!.GetName()!.Version!.ToString(3);
        }
    }
}