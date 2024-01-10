using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.SectionData
{
    public partial class SectionDataProfile : Profile
    {
        public SectionDataProfile()
        {
            GetSectionDataListMapping();
            GetSectionDataByIDMapping();
            AddSectionDataCommandMapping();
            EditSectionDataCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
