using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Appreciation
{
    public partial class AppreciationProfile : Profile
    {
        public AppreciationProfile()
        {
            GetAppreciationListMapping();
            GetAppreciationByIDMapping();
            AddAppreciationCommandMapping();
            EditAppreciationCommandMapping();
        }
    }


}
