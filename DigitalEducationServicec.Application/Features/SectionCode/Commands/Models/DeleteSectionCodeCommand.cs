using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.SectionCode.Commands.Models
{
    public class DeleteSectionCodeCommand : IRequest<Response<string>>
    {
        public long SectionCodeId { get; set; }



    }
}
