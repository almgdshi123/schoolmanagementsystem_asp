using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SubmittedHomework.Commands.Models
{
    public class AddSubmittedHomeworkCommand : IRequest<Response<string>>
    {

        public long? HomeworkId { get; set; }

        public long? FileStudentId { get; set; }

        public string? HomeworkTitle { get; set; }

        public string? HomeworkText { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }
    }
}
