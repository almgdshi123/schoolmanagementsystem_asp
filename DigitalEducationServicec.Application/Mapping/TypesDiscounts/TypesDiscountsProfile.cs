using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.TypesDiscounts
{
    public partial class TypesDiscountsProfile : Profile
    {
        public TypesDiscountsProfile()
        {
            GetTypesDiscountsListMapping();
            GetTypesDiscountsByIDMapping();
            AddTypesDiscountsCommandMapping();
            EditTypesDiscountsCommandMapping();
        }
    }




}
