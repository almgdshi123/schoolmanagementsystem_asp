using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.JopType.Commands.Models
{
    public class AddJopTypeCommand : IRequest<Response<string>>
    {

        public string? JopTypeName { get; set; }

        public string? JopTyp { get; set; }

        public string? Note { get; set; }
    }
}
