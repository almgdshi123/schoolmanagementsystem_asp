using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Qualification.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Qualification.Queries.Models
{
    public class GetQualificationListQuery : IRequest<Response<List<GetQualificationListResponse>>>
    {
    }
}
