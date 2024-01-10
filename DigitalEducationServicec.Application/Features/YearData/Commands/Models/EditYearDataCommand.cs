using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.YearData.Commands.Models
{
    public class EditYearDataCommand : IRequest<Response<string>>
    {
        public string YearId { get; set; } = null!;

        public string? YearName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Status { get; set; }
    }
}
