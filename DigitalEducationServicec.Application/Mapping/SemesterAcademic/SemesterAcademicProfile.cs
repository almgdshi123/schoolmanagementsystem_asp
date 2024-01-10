using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.SemesterAcademic
{
    public partial class SemesterAcademicProfile : Profile
    {
        public SemesterAcademicProfile()
        {
            GetSemesterAcademicListMapping();
            GetSemesterAcademicByIDMapping();
            AddSemesterAcademicCommandMapping();
            EditSemesterAcademicCommandMapping();
        }
    }
}
