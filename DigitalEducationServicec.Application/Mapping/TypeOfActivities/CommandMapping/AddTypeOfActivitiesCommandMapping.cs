using DigitalEducationServicec.Application.Features.TypeOfActivities.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TypeOfActivities
{
    public partial class TypeOfActivitiesProfile
    {
        void AddTypeOfActivitiesCommandMapping()
        {
            CreateMap<AddTypeOfActivitiesCommand, TypeOfActivitiesTb>();
        }

    }
}
