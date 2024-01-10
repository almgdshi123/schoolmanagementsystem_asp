using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Qualification.Commands.Models
{
    public class DeleteQualificationCommand : IRequest<Response<string>>
    {
        public int QualificationId { get; set; }


    }
}
