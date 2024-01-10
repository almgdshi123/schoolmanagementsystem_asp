namespace DigitalEducationServicec.Application.Features.YearData.Queries.Results
{
    public class GetYearDataListResponse
    {
        public string YearId { get; set; } = null!;

        public string? YearName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Status { get; set; }
    }
}
