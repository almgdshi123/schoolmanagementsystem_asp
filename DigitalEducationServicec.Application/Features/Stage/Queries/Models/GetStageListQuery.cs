using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Stage.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Stage.Queries.Models
{
    public class GetStageListQuery : IRequest<Response<List<GetStageListResponse>>>
    {


    }
}
