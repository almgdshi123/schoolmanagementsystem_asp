using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Teacher
{
    public partial class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            GetTeacherListMapping();
            GetTeacherByIDMapping();
            AddTeacherCommandMapping();
            EditTeacherCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
