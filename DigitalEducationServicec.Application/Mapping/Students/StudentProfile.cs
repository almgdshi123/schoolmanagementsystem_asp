using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Students
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentListMapping();
            GetStudentByIDMapping();
            AddStudentCommandMapping();
            EditStudentCommandMapping();
            GetStudentPaginationMapping();
        }
    }
}
