using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SectionCode.Commands.Models
{
    public class EditSectionCodeCommand : IRequest<Response<string>>
    {
        public long SectionCodeId { get; set; }

        public string? SectionCodeName { get; set; }

        public string? SectionCodeCode { get; set; }


    }
}
