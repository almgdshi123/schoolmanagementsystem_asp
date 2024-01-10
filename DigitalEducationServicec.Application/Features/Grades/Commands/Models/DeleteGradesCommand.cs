using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Grades.Commands.Models
{
    public class DeleteGradesCommand : IRequest<Response<string>>
    {
        public long GradesTypeId { get; set; }


    }
}
