using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Month.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Month.Queries.Models
{
    public class GetMonthListQuery : IRequest<Response<List<GetMonthListResponse>>>
    {
    }
}
