namespace DigitalEducationServicec.Application.Features.Subject.Queries.Results
{
    public class GetSingleSubjectResponse
    {
        public long SubjectId { get; set; }

        public string? SubjectNameArabic { get; set; }

        public string? SubjectNameEnglish { get; set; }

        public string? Note { get; set; }

    }
}
