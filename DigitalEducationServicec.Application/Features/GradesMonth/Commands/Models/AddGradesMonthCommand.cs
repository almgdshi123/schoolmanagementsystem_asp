using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.GradesMonth.Commands.Models
{
    public class AddGradesMonthCommand : IRequest<Response<string>>
    {

        public long? GradesTypeId { get; set; }

        public long? DistrSubTeacherId { get; set; }

        public long? FileStudentId { get; set; }

        public long? MonthAcademicId { get; set; }

        public decimal? GradesValue { get; set; }

        public string? GradesText { get; set; }

        public string? Note { get; set; }
    }
}
