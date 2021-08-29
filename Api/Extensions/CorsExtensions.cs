using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Extensions
{
    public static class CorsExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "CorsPolicy",
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200", "http://localhost:8080", "http://localhost:8081", "http://192.168.0.103:8080", "http://192.168.0.103:8081", "http://www.mehedi-hasan.net", "https://www.mehedi-hasan.net", "http://mehedi-hasan.net", "https://admin.mehedi-hasan.net", "http://admin.mehedi-hasan.net","http://sandwipshop.com","https://www.sandwipshop.com")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod(); ;
                                  });
            });
        }
    }
}
