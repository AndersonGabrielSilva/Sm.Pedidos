using Domain.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sm.Pedidos.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void AddAppOptions(this IServiceCollection services)
        {
            services.AddSingleton<AppSettings>(sp =>
            {
                var config = sp.GetService<IConfiguration>();
                return config.GetSection("AppSettings").Get<AppSettings>();
            });
        }
    }
}
