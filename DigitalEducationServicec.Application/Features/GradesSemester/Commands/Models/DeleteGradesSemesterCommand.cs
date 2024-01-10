using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.GradesSemester.Commands.Models
{
    public class DeleteGradesSemesterCommand : IRequest<Response<string>>
    {
        public long GradesSemesterId { get; set; }


    }
}
