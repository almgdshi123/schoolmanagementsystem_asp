using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Qualification
{
    public partial class QualificationProfile : Profile
    {
        public QualificationProfile()
        {
            GetQualificationListMapping();
            GetQualificationByIDMapping();
            AddQualificationCommandMapping();
            EditQualificationCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
