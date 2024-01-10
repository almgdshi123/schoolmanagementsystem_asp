using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.JopType.Commands.Models
{
    public class EditJopTypeCommand : IRequest<Response<string>>
    {
        public long JopTypeId { get; set; }

        public string? JopTypeName { get; set; }

        public string? JopTyp { get; set; }

        public string? Note { get; set; }
    }
}
