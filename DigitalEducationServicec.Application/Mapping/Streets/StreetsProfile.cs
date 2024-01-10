using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Streets
{
    public partial class StreetsProfile : Profile
    {
        public StreetsProfile()
        {
            GetStreetsListMapping();
            GetStreetByIDMapping();
            AddStreetCommandMapping();
            EditStreetCommandMapping();
        }
    }








}
