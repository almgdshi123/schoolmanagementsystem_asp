using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SemesterAcademic.Commands.Models
{
    public class EditSemesterAcademicCommand : IRequest<Response<string>>
    {
        public long SemesterAcademicId { get; set; }

        public long SemesterId { get; set; }

        public string YearId { get; set; } = null!;

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
