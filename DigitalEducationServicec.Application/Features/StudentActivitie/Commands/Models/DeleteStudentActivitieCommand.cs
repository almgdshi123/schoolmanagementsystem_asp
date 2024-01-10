using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.StudentActivitie.Commands.Models
{
    public class DeleteStudentActivitieCommand : IRequest<Response<string>>
    {
        public long StudentActivitieId { get; set; }



    }
}
