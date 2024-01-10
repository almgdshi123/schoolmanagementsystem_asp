using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Specialization
{
    public partial class SpecializationProfile : Profile
    {
        public SpecializationProfile()
        {
            GetSpecializationListMapping();
            GetSpecializationByIDMapping();
            AddSpecializationCommandMapping();
            EditSpecializationCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
