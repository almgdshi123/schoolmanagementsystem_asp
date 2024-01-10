using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Installment.Commands.Models
{
    public class AddInstallmentCommand : IRequest<Response<string>>
    {

        public string? InstallmentName { get; set; }

        public DateTime? InstallmentDateSt { get; set; }

        public DateTime? InstallmentDateEnd { get; set; }

        public DateTime? InstallmentDueDate { get; set; }

        public decimal? InstallmentRate { get; set; }

        public long? TuitionFeeInstallmentId { get; set; }
    }
}
