using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.StudentParticipationBus.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.StudentParticipationBus.Queries.Models
{
    public class GetStudentParticipationBusListQuery : IRequest<Response<List<GetStudentParticipationBusListResponse>>>
    {
    }
}
