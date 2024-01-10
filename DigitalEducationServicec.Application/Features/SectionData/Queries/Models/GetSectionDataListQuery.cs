using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SectionData.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SectionData.Queries.Models
{
    public class GetSectionDataListQuery : IRequest<Response<List<GetSectionDataListResponse>>>
    {

    }
}
