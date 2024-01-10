using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.GradesMonth.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.GradesMonth.Queries.Models
{
    public class GetGradesMonthListQuery : IRequest<Response<List<GetGradesMonthListResponse>>>
    {
    }
}
