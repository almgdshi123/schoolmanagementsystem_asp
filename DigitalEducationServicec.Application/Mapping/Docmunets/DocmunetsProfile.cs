using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Docmunets
{
    public partial class DocmunetsProfile : Profile
    {

        public DocmunetsProfile()
        {
            GetDocmunetsListMapping();
            GetDocmunetsByIDMapping();
            AddDocmunetsCommandMapping();
            EditDocmunetsCommandMapping();
        }

    }
}





