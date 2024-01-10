using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicSystems.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.AcademicSystems.Queries.Models
{
    public class GetAcademicSystemsListQuery : IRequest<Response<List<GetAcademicSystemsListResponse>>>
    {
    }
}
