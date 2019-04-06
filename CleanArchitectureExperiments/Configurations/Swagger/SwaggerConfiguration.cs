using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureExperiments.Configurations.Swagger
{
    public static class SwaggerConfiguration
    {
        public static void AddApiSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument();
        }

        public static void UseApiSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUi3();
        }
    }
}
