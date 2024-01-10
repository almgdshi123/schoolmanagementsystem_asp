using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.JopType.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.JopType.Queries.Models
{
    public class GetJopTypeListQuery : IRequest<Response<List<GetJopTypeListResponse>>>
    {
    }
}
