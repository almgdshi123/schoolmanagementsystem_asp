using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SectionCode.Commands.Models
{
    public class AddSectionCodeCommand : IRequest<Response<string>>
    {

        public string? SectionCodeName { get; set; }

        public string? SectionCodeCode { get; set; }

    }
}
