using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.SectionCode
{
    public partial class SectionCodeProfile : Profile
    {
        public SectionCodeProfile()
        {
            GetSectionCodeListMapping();
            GetSectionCodeByIDMapping();
            AddSectionCodeCommandMapping();
            EditSectionCodeCommandMapping();
        }
    }







}
