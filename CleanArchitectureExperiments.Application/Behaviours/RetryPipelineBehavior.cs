using MediatR;
using Polly;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureExperiments.Application.Behaviours
{
    public class RetryPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var policy = Policy
                .Handle<ValidationException>()
                .WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(3));

            var result = await policy
                .ExecuteAndCaptureAsync(async () => await next());

            if (result.Outcome == OutcomeType.Successful)
                return result.Result;

            throw new Exception("Deu ruim nos retry.");
        }
    }
}
