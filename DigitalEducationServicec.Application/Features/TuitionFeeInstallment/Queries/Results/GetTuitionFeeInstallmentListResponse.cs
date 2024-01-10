namespace DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Queries.Results
{
    public class GetTuitionFeeInstallmentListResponse
    {
        public long TuitionFeeInstallmentId { get; set; }

        public string? TuitionFeeInstallmentName { get; set; }

        public DateTime? DateFristInstallment { get; set; }

        public int? AlertPeriodPerDay { get; set; }

        public long? ClassTuitionFeesId { get; set; }

        public int? TuitionFeeInstallmentCount { get; set; }

        public string? YearId { get; set; }
    }
}
