using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.FileStudent.Commands.Models
{
    public class DeleteFileStudentCommand : IRequest<Response<string>>
    {
        public long FileStudentId { get; set; }


    }
}
