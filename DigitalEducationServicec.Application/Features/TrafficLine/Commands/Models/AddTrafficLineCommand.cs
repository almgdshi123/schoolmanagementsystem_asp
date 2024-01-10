using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TrafficLine.Commands.Models
{
    public class AddTrafficLineCommand : IRequest<Response<string>>
    {

        public string? TrafficLineName { get; set; }

        public string? Description { get; set; }
    }
}
