using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.StudentActivitie
{
    public partial class StudentActivityProfile : Profile
    {
        public StudentActivityProfile()
        {
            GetStudentActivityListMapping();
            GetStudentActivityByIDMapping();
            AddStudentActivityCommandMapping();
            EditStudentActivityCommandMapping();
        }
    }







}
