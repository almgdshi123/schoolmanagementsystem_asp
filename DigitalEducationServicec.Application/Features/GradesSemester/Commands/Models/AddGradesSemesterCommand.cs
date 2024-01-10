using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.GradesSemester.Commands.Models
{
    public class AddGradesSemesterCommand : IRequest<Response<string>>
    {

        public long? GradesTypeId { get; set; }

        public long? DistrSubTeacherId { get; set; }

        public long? FileStudentId { get; set; }

        public long? SemesterAcademicId { get; set; }

        public decimal? GradesValue { get; set; }

        public string? GradesText { get; set; }

        public string? Note { get; set; }
    }
}
