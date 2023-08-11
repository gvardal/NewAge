using Dupus.Repository.Contracts.IRepositoryManagers;
using Dupus.Repository.EFCore.RepositoryManagers;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace Dupus.UI.Extensions
{
    public static class ApiService
    {
        public static string BaseUrl { get; private set; } = string.Empty;
        public static HttpClient HttpClient { get; } = new();

        public static void ConfigureApiUrl(this IServiceCollection services, IConfiguration configuration)
        {
            BaseUrl = configuration.GetSection("ApiBaseHost").Value;

            HttpClient.BaseAddress = new Uri(BaseUrl);

            //services.AddHttpClient();
            services.AddScoped<HttpClient>();

        }

        public static string GetHttpClient() { return HttpClient.BaseAddress.AbsoluteUri; }
    }
}
