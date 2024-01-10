using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.ParticiStudentActiv.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.ParticiStudentActiv.Queries.Models
{
    public class GetParticiStudentActivListQuery : IRequest<Response<List<GetParticiStudentActivListResponse>>>
    {
    }
}
