using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Models
{
    public class GetDistributionClassSubListQuery : IRequest<Response<List<GetDistributionClassSubListResponse>>>
    {


    }
}
