using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Student.Commands.Models
{
    public class DeleteStudentCommand : IRequest<Response<string>>
    {
        public long StudentId { get; set; }

    }
}
