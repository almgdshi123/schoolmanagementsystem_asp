using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.ClassData.Commands.Models
{
    public class DeleteClassDataCommand : IRequest<Response<string>>
    {
        public long ClassId { get; set; }


    }
}
