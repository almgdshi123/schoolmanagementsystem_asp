using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Specialization.Commands.Models
{
    public class EditSpecializationCommand : IRequest<Response<string>>
    {
        public int SpecializationId { get; set; }

        public string? SpecializationName { get; set; }

        public string? Note { get; set; }
    }
}
