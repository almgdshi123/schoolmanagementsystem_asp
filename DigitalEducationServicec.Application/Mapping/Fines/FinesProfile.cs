using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Fines
{
    public partial class FinesProfile : Profile
    {
        public FinesProfile()
        {
            GetFinesListMapping();
            GetFinesByIDMapping();
            AddFineCommandMapping();
            EditFineCommandMapping();
        }
    }



}