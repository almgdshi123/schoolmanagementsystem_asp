using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.AcademicDiscount
{
    public partial class AcademicDiscountProfile : Profile
    {
        public AcademicDiscountProfile()
        {
            GetAcademicDiscountListMapping();
            GetAcademicDiscountByIDMapping();
            AddAcademicDiscountCommandMapping();
            EditAcademicDiscountCommandMapping();
        }
    }


}