using MeetUP.Data;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;

namespace MeetUP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF5cXmRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWXhfcHRWR2ZfUEJ0Vko=");
            builder.Services.AddScoped<SfDialogService>();
            builder.Services.AddSyncfusionBlazor();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}