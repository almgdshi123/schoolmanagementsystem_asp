using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.YearData.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.YearData.Queries.Models
{
    public class GetYearDataListQuery : IRequest<Response<List<GetYearDataListResponse>>>
    {
    }
}
