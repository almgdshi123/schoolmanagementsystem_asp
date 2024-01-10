using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Models
{
    public class EditAcademicSystemCommand : IRequest<Response<string>>
    {

        public long SystemId { get; set; }

        public string? SystemName { get; set; }

        public string? Note { get; set; }
    }
}