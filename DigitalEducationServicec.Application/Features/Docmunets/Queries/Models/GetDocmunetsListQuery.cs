using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Docmunets.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Docmunets.Queries.Models
{
    public class GetDocmunetsListQuery : IRequest<Response<List<GetDocmunetsListResponse>>>
    {
    }
}
