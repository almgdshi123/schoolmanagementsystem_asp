namespace DigitalEducationServicec.Application.Features.Subject.Queries.Results
{
    public class GetSubjectListResponse
    {
        public long SubjectId { get; set; }

        public string? SubjectNameArabic { get; set; }

        public string? SubjectNameEnglish { get; set; }

        public string? SubjectType { get; set; }

        public bool? SubjectIncludedInRate { get; set; }

        public decimal? LowScore { get; set; }

        public decimal? HighScore { get; set; }

        public string? Note { get; set; }

    }
}
