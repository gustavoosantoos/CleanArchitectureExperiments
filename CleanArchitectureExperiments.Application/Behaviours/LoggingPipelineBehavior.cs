using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureExperiments.Application.Behaviours
{
    public class LoggingPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Debug.WriteLine($"Handling {typeof(TRequest).Name}");
            var response = await next();
            Debug.WriteLine($"Handled {typeof(TRequest).Name}");

            return response;
        }
    }
}
