using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.JopType.Commands.Models
{
    public class DeleteJopTypeCommand : IRequest<Response<string>>
    {
        public long JopTypeId { get; set; }


    }
}
