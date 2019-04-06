using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureExperiments.Configurations.MediatR
{
    public static class MediatrConfiguration
    {
        public static void AddApiMediatR(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup).Assembly);
        }
    }
}
