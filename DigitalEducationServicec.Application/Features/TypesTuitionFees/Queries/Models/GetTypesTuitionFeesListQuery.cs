using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Models
{
    public class GetTypesTuitionFeesListQuery : IRequest<Response<List<GetTypesTuitionFeesListResponse>>>
    {
    }
}
