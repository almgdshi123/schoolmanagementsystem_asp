using DigitalEducationServicec.Application.Features.Vacations.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Vacations
{
    public partial class VacationsProfile
    {
        public void AddVacationCommandMapping()
        {
            CreateMap<AddVacationsCommand, VacationsTb>();
        }
    }
}