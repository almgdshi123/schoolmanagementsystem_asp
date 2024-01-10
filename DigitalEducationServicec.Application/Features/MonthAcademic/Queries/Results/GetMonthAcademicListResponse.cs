namespace DigitalEducationServicec.Application.Features.MonthAcademic.Queries.Results
{
    public class GetMonthAcademicListResponse
    {
        public long MonthAcademicId { get; set; }

        public string? Note { get; set; }

        public long? MonthId { get; set; }

        public long? SemesterAcademicId { get; set; }

        public int? Status { get; set; }
    }
}
