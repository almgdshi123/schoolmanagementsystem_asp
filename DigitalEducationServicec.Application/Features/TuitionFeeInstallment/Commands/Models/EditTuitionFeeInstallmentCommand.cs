using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Commands.Models
{
    public class EditTuitionFeeInstallmentCommand : IRequest<Response<string>>
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
