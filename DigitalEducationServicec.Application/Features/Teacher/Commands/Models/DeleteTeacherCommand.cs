using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Teacher.Commands.Models
{
    public class DeleteTeacherCommand : IRequest<Response<string>>
    {
        public long TeacherId { get; set; }


    }
}
