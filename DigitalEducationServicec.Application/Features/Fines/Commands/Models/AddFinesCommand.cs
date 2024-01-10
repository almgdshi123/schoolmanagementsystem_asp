using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Fines.Commands.Models
{
    public class AddFinesCommand : IRequest<Response<string>>
    {

        public string? FinesName { get; set; }

        public decimal? FinesAmount { get; set; }

        public string? Status { get; set; }

        public string? YearId { get; set; }
    }
}
