using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Queries.Models
{
    public class GetDistributionOfBuseStreetListQuery : IRequest<Response<List<GetDistributionOfBuseStreetListResponse>>>
    {
    }
}
