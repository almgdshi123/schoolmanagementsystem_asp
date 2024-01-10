using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.TrafficLine.Commands.Models
{
    public class DeleteTrafficLineCommand : IRequest<Response<string>>
    {
        public long TrafficLineId { get; set; }


    }
}
