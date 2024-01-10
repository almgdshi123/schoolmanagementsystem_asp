using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Month.Commands.Models
{
    public class EditMonthCommand : IRequest<Response<string>>
    {
        public long MonthId { get; set; }

        public string? MonthName { get; set; }

        public int? MonthNumber { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
