using DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.AcademicSystems
{
    public partial class AcademicSystemsProfile
    {
        public void EditAcademicSystemsCommandMapping()
        {
            CreateMap<EditAcademicSystemCommand, AcademicSystemsTb>();

        }
    }
}
