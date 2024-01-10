using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SemesterAcademic.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SemesterAcademic.Queries.Models
{
    public class GetSemesterAcademicListQuery : IRequest<Response<List<GetSemesterAcademicListResponse>>>
    {
    }
}
