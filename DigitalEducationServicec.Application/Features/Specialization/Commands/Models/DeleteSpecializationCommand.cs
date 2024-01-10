using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Specialization.Commands.Models
{
    public class DeleteSpecializationCommand : IRequest<Response<string>>
    {
        public int SpecializationId { get; set; }


    }
}
