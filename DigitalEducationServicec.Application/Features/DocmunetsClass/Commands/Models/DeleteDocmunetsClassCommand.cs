using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.DocmunetsClass.Commands.Models
{
    public class DeleteDocmunetsClassCommand : IRequest<Response<string>>
    {
        public long DocmunetsClassId { get; set; }


    }
}
