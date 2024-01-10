using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.Bus.Commands.Models
{
    public class DeleteBusCommand : IRequest<Response<string>>
    {
        public long BusId { get; set; }



    }
}
