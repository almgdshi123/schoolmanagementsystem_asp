using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Subject
{
    public partial class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            GetSubjectListMapping();
            GetSubjectByIDMapping();
            AddSubjectCommandMapping();
            EditSubjectCommandMapping();
        }
    }
}
