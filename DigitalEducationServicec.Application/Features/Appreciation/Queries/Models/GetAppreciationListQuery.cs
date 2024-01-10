using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Appreciation.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Appreciation.Queries.Models
{
    public class GetAppreciationListQuery : IRequest<Response<List<GetAppreciationListResponse>>>
    {
    }
}
