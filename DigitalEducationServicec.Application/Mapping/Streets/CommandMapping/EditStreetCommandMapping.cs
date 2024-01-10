using DigitalEducationServicec.Application.Features.Streets.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Streets
{
    public partial class StreetsProfile
    {
        public void EditStreetCommandMapping()
        {
            CreateMap<EditStreetsCommand, StreetsTb>();
        }
    }
}
