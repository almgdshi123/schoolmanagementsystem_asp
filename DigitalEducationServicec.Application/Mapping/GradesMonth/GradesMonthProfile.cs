using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.GradesMonth
{
    public partial class GradesMonthProfile : Profile
    {
        public GradesMonthProfile()
        {
            GetGradesMonthListMapping();
            GetGradesMonthByIDMapping();
            AddGradesMonthCommandMapping();
            EditGradesMonthCommandMapping();
            //    GetStudentPaginationMapping();
        }
    }
}
