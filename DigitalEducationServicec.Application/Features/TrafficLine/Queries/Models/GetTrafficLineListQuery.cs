using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TrafficLine.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.TrafficLine.Queries.Models
{
    public class GetTrafficLineListQuery : IRequest<Response<List<GetTrafficLineListResponse>>>
    {
    }
}
