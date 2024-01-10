using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Month
{
    public partial class MonthProfile : Profile
    {
        public MonthProfile()
        {
            GetMonthListMapping();
            GetMonthByIDMapping();
            AddMonthCommandMapping();
            EditMonthCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
