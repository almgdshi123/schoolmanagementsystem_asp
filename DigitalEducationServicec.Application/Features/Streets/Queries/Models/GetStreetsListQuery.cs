using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Streets.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.Streets.Queries.Models
{
    public class GetStreetsListQuery : IRequest<Response<List<GetStreetsListResponse>>>
    {
    }
}
