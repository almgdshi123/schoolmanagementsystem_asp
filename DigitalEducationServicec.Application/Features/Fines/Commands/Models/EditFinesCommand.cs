using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Fines.Commands.Models
{
    public class EditFinesCommand : IRequest<Response<string>>
    {
        public long FinesId { get; set; }

        public string? FinesName { get; set; }

        public decimal? FinesAmount { get; set; }

        public string? Status { get; set; }

        public string? YearId { get; set; }
    }
}
