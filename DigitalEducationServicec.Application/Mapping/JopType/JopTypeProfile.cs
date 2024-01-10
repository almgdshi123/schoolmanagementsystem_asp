using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.JopType
{
    public partial class JopTypeProfile : Profile
    {
        public JopTypeProfile()
        {
            GetJopTypeListMapping();
            GetJopTypeByIDMapping();
            AddJopTypeCommandMapping();
            EditJopTypeCommandMapping();
        }
    }








}
