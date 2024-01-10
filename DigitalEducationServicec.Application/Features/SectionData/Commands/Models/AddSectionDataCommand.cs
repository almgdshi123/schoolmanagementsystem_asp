using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SectionData.Commands.Models
{
    public class AddSectionDataCommand : IRequest<Response<string>>
    {

        public string? SectionName { get; set; }

        public string? SectionCode { get; set; }

        public long? ClassId { get; set; }

        public int? MaximumNumberOfStudents { get; set; }

        public int? MinimumNumberOfStudents { get; set; }

    }
}
