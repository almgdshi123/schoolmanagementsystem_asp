using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.TypeOfActivities
{

    public partial class TypeOfActivitiesProfile : Profile
    {
        public TypeOfActivitiesProfile()
        {
            GetTypeOfActivitiesListMapping();
            GetTypeOfActivitiesByIDMapping();
            AddTypeOfActivitiesCommandMapping();
            EditTypeOfActivitiesCommandMapping();
        }

    }


}
