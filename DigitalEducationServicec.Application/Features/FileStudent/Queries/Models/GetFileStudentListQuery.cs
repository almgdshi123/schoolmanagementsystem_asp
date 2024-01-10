using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.FileStudent.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.FileStudent.Queries.Models
{
    public class GetFileStudentListQuery : IRequest<Response<List<GetFileStudentListResponse>>>
    {
    }
}
