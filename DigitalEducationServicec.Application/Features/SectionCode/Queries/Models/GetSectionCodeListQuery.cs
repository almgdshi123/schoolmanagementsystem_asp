using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SectionCode.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SectionCode.Queries.Models
{
    public class GetSectionCodeListQuery : IRequest<Response<List<GetSectionCodeListResponse>>>
    {
    }
}
