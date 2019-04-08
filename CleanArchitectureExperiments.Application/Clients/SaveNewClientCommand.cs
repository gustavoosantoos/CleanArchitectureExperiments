using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureExperiments.Application.Clients
{
    public class SaveNewClientCommand : IRequest
    {
        [Required]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Id must be greater than zero")]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The client name must not be null or empty")]
        [MaxLength(50, ErrorMessage = "The client name must be at maximum 50 characters")]
        public string Name { get; set; }

    }
}
