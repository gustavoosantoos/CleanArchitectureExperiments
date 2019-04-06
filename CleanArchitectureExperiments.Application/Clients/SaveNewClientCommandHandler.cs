using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureExperiments.Application.Clients
{
    public class SaveNewClientCommandHandler : IRequestHandler<SaveNewClientCommand>
    {
        public Task<Unit> Handle(SaveNewClientCommand request, CancellationToken cancellationToken)
        {
            if (request.Id == 13)
                throw new ValidationException("Deu ruim.");

            return Unit.Task;
        }
    }
}
