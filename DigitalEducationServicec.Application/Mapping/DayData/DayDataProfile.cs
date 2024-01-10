using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.DayData
{
    public partial class DayDataProfile : Profile
    {
        public DayDataProfile()
        {
            GetDayDataListMapping();
            GetDayDataByIDMapping();
            AddDayDataCommandMapping();
            EditDayDataCommandMapping();
        }
    }


}