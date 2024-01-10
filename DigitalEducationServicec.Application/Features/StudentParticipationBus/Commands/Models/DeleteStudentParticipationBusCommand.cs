using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.StudentParticipationBus.Commands.Models
{
    public class DeleteStudentParticipationBusCommand : IRequest<Response<string>>
    {
        public long StudentParticipationBusId { get; set; }


    }
}
