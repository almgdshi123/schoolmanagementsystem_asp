using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Commands.Models
{
    public class DeleteTuitionFeeInstallmentCommand : IRequest<Response<string>>
    {
        public long TuitionFeeInstallmentId { get; set; }


    }
}
