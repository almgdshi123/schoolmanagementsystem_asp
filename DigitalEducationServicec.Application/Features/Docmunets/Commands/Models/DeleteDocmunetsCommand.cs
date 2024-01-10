using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.Docmunets.Commands.Models
{
    public class DeleteDocmunetsCommand : IRequest<Response<string>>
    {
        public long DocmunetId { get; set; }



    }
}
