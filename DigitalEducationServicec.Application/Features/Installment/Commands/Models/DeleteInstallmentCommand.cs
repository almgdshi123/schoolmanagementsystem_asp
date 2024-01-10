using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.Installment.Commands.Models
{
    public class DeleteInstallmentCommand : IRequest<Response<string>>
    {
        public long InstallmentId { get; set; }


    }
}
