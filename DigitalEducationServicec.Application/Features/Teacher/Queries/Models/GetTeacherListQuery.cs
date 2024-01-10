using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Teacher.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Teacher.Queries.Models
{
    public class GetTeacherListQuery : IRequest<Response<List<GetTeacherListResponse>>>
    {
    }
}
