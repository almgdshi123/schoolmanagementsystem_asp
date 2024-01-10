using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Qualification.Commands.Models
{
    public class EditQualificationCommand : IRequest<Response<string>>
    {
        public long QualificationId { get; set; }

        public string? QualificationName { get; set; }

        public string? Note { get; set; }
    }
}
