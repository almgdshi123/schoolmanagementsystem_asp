using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Grades.Commands.Models
{
    public class AddGradesCommand : IRequest<Response<string>>
    {

        public string? GradesName { get; set; }

        public string? GradesType { get; set; }

        public string? Note { get; set; }
    }
}
