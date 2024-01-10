using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionSubTeacher.Commands.Models
{
    public class EditDistributionSubTeacherCommand : IRequest<Response<string>>
    {
        public long DistrSubTeacherId { get; set; }

        public long DistrClassSubId { get; set; }

        public long TeacherId { get; set; }

        public long SemesterAcademicId { get; set; }

        public DateTime? DistrDate { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
