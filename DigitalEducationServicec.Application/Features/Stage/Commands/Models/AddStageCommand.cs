using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Stage.Commands.Models
{
    public class AddStageCommand : IRequest<Response<string>>
    {

        public string? StageName { get; set; }

        public long? SchoolId { get; set; }

        public int? NumberOfClasses { get; set; }
    }
}
