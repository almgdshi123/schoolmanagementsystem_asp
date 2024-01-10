namespace DigitalEducationServicec.Application.Features.Fines.Queries.Results
{
    public class GetFinesListResponse
    {
        public long FinesId { get; set; }

        public string? FinesName { get; set; }

        public decimal? FinesAmount { get; set; }

        public string? Status { get; set; }

        public string? YearId { get; set; }
    }
}
