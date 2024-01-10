using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Grades.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Grades.Queries.Models
{
    public class GetGradesListQuery : IRequest<Response<List<GetGradesListResponse>>>
    {
    }
}
