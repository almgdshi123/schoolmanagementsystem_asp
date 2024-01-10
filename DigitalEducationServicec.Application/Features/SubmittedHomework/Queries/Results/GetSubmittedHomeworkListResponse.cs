namespace DigitalEducationServicec.Application.Features.SubmittedHomework.Queries.Results
{
    public class GetSubmittedHomeworkListResponse
    {
        public long SubmittedHomeworkId { get; set; }

        public long? HomeworkId { get; set; }

        public long? FileStudentId { get; set; }

        public string? HomeworkTitle { get; set; }

        public string? HomeworkText { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }
    }
}
