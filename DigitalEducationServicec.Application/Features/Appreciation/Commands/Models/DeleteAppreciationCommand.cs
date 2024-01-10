using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Appreciation.Commands.Models
{
    public class DeleteAppreciationCommand : IRequest<Response<string>>
    {
        public long AppreciationId { get; set; }


    }
}
