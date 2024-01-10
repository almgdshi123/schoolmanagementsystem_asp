using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Homework
{
    public partial class HomeworkProfile : Profile
    {
        public HomeworkProfile()
        {
            GetHomeworkListMapping();
            GetHomeworkByIDMapping();
            AddHomeworkCommandMapping();
            EditHomeworkCommandMapping();
            //  GetStudentPaginationMapping();
        }
    }
}
