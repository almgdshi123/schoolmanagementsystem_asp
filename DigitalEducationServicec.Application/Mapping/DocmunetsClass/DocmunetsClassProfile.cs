using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.DocmunetsClass
{
    public partial class DocmunetsClassProfile : Profile
    {
        public DocmunetsClassProfile()
        {
            GetDocmunetsClassListMapping();
            GetDocmunetsClassByIDMapping();
            AddDocmunetsClassCommandMapping();
            EditDocmunetsClassCommandMapping();
        }
    }




}