using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Stage.Commands.Models
{
    public class DeleteStageCommand : IRequest<Response<string>>
    {
        public long StageId { get; set; }



    }
}
