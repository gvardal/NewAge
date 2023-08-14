using Dupus.API.Controllers;
using Dupus.Repository.Contracts.IRepositoryManagers;
using Dupus.Repository.EFCore.RepositoryManagers;
using Microsoft.AspNetCore.Components;
using Microsoft.IdentityModel.Tokens;
using Models.Entities.Dupus.Entity.Dtos;
using System.Net.Http;
using System.Text.Json;
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

        public static T GetAsync<T>(string url) where T :class
        {
            var response = HttpClient.GetAsync(GetHttpClient() + url);
            var content = response.Result.Content.ReadAsStringAsync();
            if (content == null || content.Result == null || string.IsNullOrEmpty(content.Result))
                return null;
            var data = JsonSerializer.Deserialize<T>(content.Result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return data;
        }
    }
}
