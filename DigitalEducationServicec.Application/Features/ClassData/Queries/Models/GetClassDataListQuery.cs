using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.ClassData.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.ClassData.Queries.Models
{
    public class GetClassDataListQuery : IRequest<Response<List<GetClassDataListResponse>>>
    {
    }
}
