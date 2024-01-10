using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Teacher.Commands.Models
{
    public class EditTeacherCommand : IRequest<Response<string>>
    {
        public long TeacherId { get; set; }

        public string? TeacherName { get; set; }

        public string? Address { get; set; }

        public int? SpecializationId { get; set; }

        public int? QualificationId { get; set; }

        public long? UserId { get; set; }

        public string? Gender { get; set; }
    }
}
