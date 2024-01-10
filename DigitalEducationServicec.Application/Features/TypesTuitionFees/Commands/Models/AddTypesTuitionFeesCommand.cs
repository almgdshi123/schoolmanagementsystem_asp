using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TypesTuitionFees.Commands.Models
{
    public class AddTypesTuitionFeesCommand : IRequest<Response<string>>
    {

        public string? TypesTuitionFeesName { get; set; }

        public bool? MonthlyService { get; set; }

        public bool? Installments { get; set; }

        public string? Notes { get; set; }
    }
}
