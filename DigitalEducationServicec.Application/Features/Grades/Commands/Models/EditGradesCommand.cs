using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Grades.Commands.Models
{
    public class EditGradesCommand : IRequest<Response<string>>
    {
        public long GradesTypeId { get; set; }

        public string? GradesName { get; set; }

        public string? GradesType { get; set; }

        public string? Note { get; set; }
    }
}
