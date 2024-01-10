using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.ParticiStudentActiv.Commands.Models
{
    public class AddParticiStudentActivCommand : IRequest<Response<string>>
    {

        public long StudentActivitieId { get; set; }

        public long FileStudentId { get; set; }

        public string DocmunetStatus { get; set; } = null!;

        public string? Notes { get; set; }
    }
}
