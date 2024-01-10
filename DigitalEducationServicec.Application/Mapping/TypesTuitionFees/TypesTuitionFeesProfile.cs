using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.TypesTuitionFees
{
    public partial class TypesTuitionFeesProfile : Profile
    {
        public TypesTuitionFeesProfile()
        {
            GetTypesTuitionFeesListMapping();
            GetTypesTuitionFeesByIDMapping();
            AddTypesTuitionFeesCommandMapping();
            EditTypesTuitionFeesCommandMapping();
        }
    }







}
