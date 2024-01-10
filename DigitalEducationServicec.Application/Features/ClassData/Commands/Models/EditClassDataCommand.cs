using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.ClassData.Commands.Models
{
    public class EditClassDataCommand : IRequest<Response<string>>
    {
        public long ClassId { get; set; }

        public string? ClassName { get; set; }

        public string? ClassCode { get; set; }

        public long? StageId { get; set; }
    }
}
