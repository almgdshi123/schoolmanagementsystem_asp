using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Models
{
    public class DeleteAcademicSystemCommand : IRequest<Response<string>>
    {

        public long SystemId { get; set; }

    }

}
