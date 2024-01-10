using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Month.Commands.Models
{
    public class AddMonthCommand : IRequest<Response<string>>
    {

        public string? MonthName { get; set; }

        public int? MonthNumber { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
