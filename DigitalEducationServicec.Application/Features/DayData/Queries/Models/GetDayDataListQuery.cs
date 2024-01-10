using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DayData.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DayData.Queries.Models
{
    public class GetDayDataListQuery : IRequest<Response<List<GetDayDataListResponse>>>
    {
    }
}
