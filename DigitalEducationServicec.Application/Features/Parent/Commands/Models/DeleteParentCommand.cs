using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Parent.Commands.Models
{
    public class DeleteParentCommand : IRequest<Response<string>>
    {

        public long ParentId { get; set; }


    }
}
