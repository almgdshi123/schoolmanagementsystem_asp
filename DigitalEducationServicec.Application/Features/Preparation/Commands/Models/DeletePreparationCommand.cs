using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Preparation.Commands.Models
{
    public class DeletePreparationCommand : IRequest<Response<string>>
    {
        public long PreparationId { get; set; }


    }
}
