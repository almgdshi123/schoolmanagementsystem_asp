using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.MonthAcademic.Commands.Models
{
    public class AddMonthAcademicCommand : IRequest<Response<string>>
    {

        public string? Note { get; set; }

        public long? MonthId { get; set; }

        public long? SemesterAcademicId { get; set; }

        public int? Status { get; set; }
    }
}
