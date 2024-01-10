using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.ParticiStudentActiv.Commands.Models
{
    public class DeleteParticiStudentActivCommand : IRequest<Response<string>>
    {

        public long ParticiStudentActivId { get; set; }


    }
}
