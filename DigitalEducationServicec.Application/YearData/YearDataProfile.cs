using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.YearData
{
    public partial class YearDataProfile : Profile
    {
        public YearDataProfile()
        {
            GetYearDataListMapping();
            GetYearDataByIDMapping();
            AddYearDataCommandMapping();
            EditYearDataCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
