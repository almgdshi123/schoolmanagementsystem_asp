using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SectionData.Commands.Models
{
    public class DeleteSectionDataCommand : IRequest<Response<string>>
    {
        public long SectionId { get; set; }



    }
}
