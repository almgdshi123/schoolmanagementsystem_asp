

using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DocmunetStudent.Commands.Models
{
    public class DeleteDocmunetStudentCommand : IRequest<Response<string>>
    {
        public long DocmunetStudentId { get; set; }




    }
}
