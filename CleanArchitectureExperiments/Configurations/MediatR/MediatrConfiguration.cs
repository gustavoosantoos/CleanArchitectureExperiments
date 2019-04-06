using CleanArchitectureExperiments.Application.Behaviours;
using CleanArchitectureExperiments.Application.Clients;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureExperiments.Configurations.MediatR
{
    public static class MediatrConfiguration
    {
        public static void AddApiMediatR(this IServiceCollection services)
        {
            services.AddMediatR(typeof(SaveNewClientCommand).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));
        }
    }
}
