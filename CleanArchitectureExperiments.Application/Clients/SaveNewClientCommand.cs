using CleanArchitectureExperiments.Domain;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureExperiments.Application.Clients
{
    public class SaveNewClientCommand : IRequest
    {
        [Required]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Id must be greater than zero")]
        public int Id { get; set; }
    }
}
