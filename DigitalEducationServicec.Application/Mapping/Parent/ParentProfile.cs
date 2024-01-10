using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Parent
{
    public partial class ParentProfile : Profile
    {
        public ParentProfile()
        {
            GetParentListMapping();
            GetParentByIDMapping();
            AddParentCommandMapping();
            EditParentCommandMapping();
        }
    }
}
