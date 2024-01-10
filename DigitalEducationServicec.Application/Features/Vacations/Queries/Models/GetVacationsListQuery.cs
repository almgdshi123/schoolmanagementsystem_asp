using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Vacations.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.Vacations.Queries.Models
{
    public class GetVacationsListQuery : IRequest<Response<List<GetVacationsListResponse>>>
    {
    }
}
