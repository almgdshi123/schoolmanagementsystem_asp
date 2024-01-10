using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Vacations.Commands.Models
{
    public class DeleteVacationsCommand : IRequest<Response<string>>
    {
        public long VacationId { get; set; }


    }
}
