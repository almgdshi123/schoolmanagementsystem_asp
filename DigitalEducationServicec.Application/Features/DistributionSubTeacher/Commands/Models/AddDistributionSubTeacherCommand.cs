using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionSubTeacher.Commands.Models
{
    public class AddDistributionSubTeacherCommand : IRequest<Response<string>>
    {

        public long DistrClassSubId { get; set; }

        public long TeacherId { get; set; }

        public long SemesterAcademicId { get; set; }

        public DateTime? DistrDate { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
