

using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Subject.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Subject.Queries.Models
{

    public class GetSubjectListQuery : IRequest<Response<List<GetSubjectListResponse>>>
    {
    }
}
