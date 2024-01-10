namespace DigitalEducationServicec.Application.Features.GradesMonth.Queries.Results
{
    public class GetGradesMonthListResponse
    {
        public long GradesMonthId { get; set; }

        public long? GradesTypeId { get; set; }

        public long? DistrSubTeacherId { get; set; }

        public long? FileStudentId { get; set; }

        public long? MonthAcademicId { get; set; }

        public decimal? GradesValue { get; set; }

        public string? GradesText { get; set; }

        public string? Note { get; set; }
    }
}
