using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Student.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Student.Queries.Models
{

    public class GetStudentListQuery : IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
