using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Models
{
    public class GetAcademicStatusesListQuery : IRequest<Response<List<GetAcademicStatusesListResponse>>>
    {
    }
}
