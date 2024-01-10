using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Bus.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Bus.Queries.Models
{
    public class GetBusListQuery : IRequest<Response<List<GetBusListResponse>>>
    {
    }
}
