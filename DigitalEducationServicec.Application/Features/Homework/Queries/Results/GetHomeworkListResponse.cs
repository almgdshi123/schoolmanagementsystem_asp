namespace DigitalEducationServicec.Application.Features.Homework.Queries.Results
{
    public class GetHomeworkListResponse
    {
        public long HomeworkId { get; set; }

        public long DistrSubTeacherId { get; set; }

        public string? HomeworkTitle { get; set; }

        public string? HomeworkText { get; set; }

        public DateTime? SubmissionDate { get; set; }

        public long? MonthAcademicId { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
