using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SubmittedHomework.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SubmittedHomework.Queries.Models
{
    public class GetSubmittedHomeworkListQuery : IRequest<Response<List<GetSubmittedHomeworkListResponse>>>
    {
    }
}
