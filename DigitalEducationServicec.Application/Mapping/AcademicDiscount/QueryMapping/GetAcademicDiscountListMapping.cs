using DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.AcademicDiscount
{
    public partial class AcademicDiscountProfile
    {
        public void GetAcademicDiscountListMapping()
        {
            CreateMap<AcademicDiscountTb, GetAcademicDiscountListResponse>();
        }
    }
}
