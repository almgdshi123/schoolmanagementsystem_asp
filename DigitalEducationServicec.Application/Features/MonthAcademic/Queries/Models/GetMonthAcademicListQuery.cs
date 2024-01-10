using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.MonthAcademic.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.MonthAcademic.Queries.Models
{
    public class GetMonthAcademicListQuery : IRequest<Response<List<GetMonthAcademicListResponse>>>
    {
    }
}
