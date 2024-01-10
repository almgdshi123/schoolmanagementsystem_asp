using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.GradesSemester.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.GradesSemester.Queries.Models
{
    public class GetGradesSemesterListQuery : IRequest<Response<List<GetGradesSemesterListResponse>>>
    {

    }
}
