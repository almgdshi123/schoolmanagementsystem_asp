using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Specialization.Commands.Models
{
    public class AddSpecializationCommand : IRequest<Response<string>>
    {

        public string? SpecializationName { get; set; }

        public string? Note { get; set; }
    }
}
