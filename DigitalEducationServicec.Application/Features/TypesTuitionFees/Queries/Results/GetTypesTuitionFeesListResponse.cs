namespace DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Results
{
    public class GetTypesTuitionFeesListResponse
    {
        public long TypesTuitionFeesId { get; set; }

        public string? TypesTuitionFeesName { get; set; }

        public bool? MonthlyService { get; set; }

        public bool? Installments { get; set; }

        public string? Notes { get; set; }
    }
}
