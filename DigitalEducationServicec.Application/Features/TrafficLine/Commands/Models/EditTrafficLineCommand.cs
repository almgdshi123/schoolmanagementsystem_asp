using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TrafficLine.Commands.Models
{
    public class EditTrafficLineCommand : IRequest<Response<string>>
    {
        public long TrafficLineId { get; set; }

        public string? TrafficLineName { get; set; }

        public string? Description { get; set; }
    }
}
