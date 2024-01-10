using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.SubmittedHomework
{
    public partial class SubmittedHomeworkProfile : Profile
    {
        public SubmittedHomeworkProfile()
        {
            GetSubmittedHomeworkListMapping();
            GetSubmittedHomeworkByIDMapping();
            AddSubmittedHomeworkCommandMapping();
            EditSubmittedHomeworkCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
