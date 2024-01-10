using DigitalEducationServicec.Application.Features.TypeOfActivities.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TypeOfActivities
{
    public partial class TypeOfActivitiesProfile
    {
        void GetTypeOfActivitiesListMapping()
        {
            CreateMap<TypeOfActivitiesTb, GetTypeOfActivitiesListResponse>();
        }
    }
}
