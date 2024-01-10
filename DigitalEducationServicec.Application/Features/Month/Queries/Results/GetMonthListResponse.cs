namespace DigitalEducationServicec.Application.Features.Month.Queries.Results
{
    public class GetMonthListResponse
    {
        public long MonthId { get; set; }

        public string? MonthName { get; set; }

        public int? MonthNumber { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
