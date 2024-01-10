namespace DigitalEducationServicec.Application.Features.SemesterAcademic.Queries.Results
{
    public class GetSemesterAcademicListResponse
    {
        public long SemesterAcademicId { get; set; }

        public long SemesterId { get; set; }

        public string YearId { get; set; } = null!;

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
