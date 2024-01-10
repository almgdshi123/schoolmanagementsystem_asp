namespace DigitalEducationServicec.Application.Features.Installment.Queries.Results
{
    public class GetInstallmentListResponse
    {
        public long InstallmentId { get; set; }

        public string? InstallmentName { get; set; }

        public DateTime? InstallmentDateSt { get; set; }

        public DateTime? InstallmentDateEnd { get; set; }

        public DateTime? InstallmentDueDate { get; set; }

        public decimal? InstallmentRate { get; set; }

        public long? TuitionFeeInstallmentId { get; set; }
    }
}
