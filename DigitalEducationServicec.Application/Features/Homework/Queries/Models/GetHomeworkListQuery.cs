using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Homework.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Homework.Queries.Models
{
    public class GetHomeworkListQuery : IRequest<Response<List<GetHomeworkListResponse>>>
    {
    }
}
