using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Semester
{
    public partial class SemesterProfile : Profile
    {
        public SemesterProfile()
        {
            GetSemesterListMapping();
            GetSemesterByIDMapping();
            AddSemesterCommandMapping();
            EditSemesterCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
