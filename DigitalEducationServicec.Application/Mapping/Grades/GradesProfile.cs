using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Grades
{
    public partial class GradesProfile : Profile
    {
        public GradesProfile()
        {
            GetGradesListMapping();
            GetGradesByIDMapping();
            AddGradesCommandMapping();
            EditGradesCommandMapping();
            //    GetStudentPaginationMapping();
        }
    }
}
