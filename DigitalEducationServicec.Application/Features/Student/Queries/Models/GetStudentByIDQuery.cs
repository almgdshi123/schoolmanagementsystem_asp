using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Student.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Student.Queries.Models
{
    public class GetStudentByIDQuery : IRequest<Response<GetSingleStudentResponse>>
    {
        public long StudentId { get; set; }
        public GetStudentByIDQuery(long id)
        {
            StudentId = id;
        }
    }
}
