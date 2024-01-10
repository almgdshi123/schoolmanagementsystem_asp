using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Fines.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Fines.Queries.Models
{
    public class GetFinesListQuery : IRequest<Response<List<GetFinesListResponse>>>
    {
    }
}
