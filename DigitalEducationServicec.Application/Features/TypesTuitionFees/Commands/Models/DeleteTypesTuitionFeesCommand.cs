using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TypesTuitionFees.Commands.Models
{
    public class DeleteTypesTuitionFeesCommand : IRequest<Response<string>>
    {
        public long TypesTuitionFeesId { get; set; }



    }
}
