using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionSubTeacher.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionSubTeacher.Queries.Models
{
    public class GetDistributionSubTeacherListQuery : IRequest<Response<List<GetDistributionSubTeacherListResponse>>>
    {
    }
}
