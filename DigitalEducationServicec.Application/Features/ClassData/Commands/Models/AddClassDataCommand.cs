using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.ClassData.Commands.Models
{
    public class AddClassDataCommand : IRequest<Response<string>>
    {

        public string? ClassName { get; set; }

        public string? ClassCode { get; set; }

        public long? StageId { get; set; }
    }
}
