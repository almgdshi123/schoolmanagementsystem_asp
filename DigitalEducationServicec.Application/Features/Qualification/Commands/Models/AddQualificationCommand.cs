using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Qualification.Commands.Models
{
    public class AddQualificationCommand : IRequest<Response<string>>
    {

        public string? QualificationName { get; set; }

        public string? Note { get; set; }
    }
}
