using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.MonthAcademic
{
    public partial class MonthAcademicProfile : Profile
    {
        public MonthAcademicProfile()
        {
            GetMonthAcademicListMapping();
            GetMonthAcademicByIDMapping();
            AddMonthAcademicCommandMapping();
            EditMonthAcademicCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
