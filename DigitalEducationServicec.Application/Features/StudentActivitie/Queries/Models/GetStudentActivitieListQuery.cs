using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.StudentActivitie.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.StudentActivitie.Queries.Models
{
    public class GetStudentActivitieListQuery : IRequest<Response<List<GetStudentActivitieListResponse>>>
    {
    }
}
