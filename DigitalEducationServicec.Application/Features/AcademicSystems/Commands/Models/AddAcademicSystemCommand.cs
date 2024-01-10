using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Models
{
    public class AddAcademicSystemCommand : IRequest<Response<string>>
    {


        public string? SystemName { get; set; }

        public string? Note { get; set; }
    }

}
