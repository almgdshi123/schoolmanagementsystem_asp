using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Vacations.Commands.Models
{
    public class EditVacationsCommand : IRequest<Response<string>>
    {
        public long VacationId { get; set; }

        public string? VacationName { get; set; }

        public DateTime? VacationDateSt { get; set; }

        public DateTime? VacationDateEnd { get; set; }

        public string? YearId { get; set; }

        public string? VacationType { get; set; }
    }
}
